using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace SMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public DateTime SendDateCurrent = DateTime.Now.AddSeconds(3);
        private void modifierColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                Parametre.FontColor = colorDialog1.Color;
                AllListSms.Param[0].ColorFont = colorDialog1.Color.ToArgb().ToString() ;
                Parametre.ChangeColor();
            }
        }

        private void modifierBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Parametre.BackColor = colorDialog1.Color;
                AllListSms.Param[0].ColorBack = colorDialog1.Color.ToArgb().ToString();
                Parametre.ChangeColor();
            }
        }

        private void segmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listeDesContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmListContact().ShowDialog();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ContactFrm().ShowDialog();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new SendFrm().ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AllListSms.SegmentList = AllListSms.Deserialize<Segment>(AllListSms.SegmentList,"Segment");
            AllListSms.Contacts = AllListSms.Deserialize<Contact>(AllListSms.Contacts, "Contact");
            AllListSms.Compagne = AllListSms.Deserialize<Compagne>(AllListSms.Compagne, "Compagne");
            AllListSms.SmsList = AllListSms.Deserialize<SMSCls>(AllListSms.SmsList, "SmsInfo");
            AllListSms.Param = AllListSms.Deserialize<ColorParam>(AllListSms.Param, "Color");
            AllListSms.EmailInfo = AllListSms.Deserialize<EmailInfo>(AllListSms.EmailInfo, "EmailInfo");
            AllListSms.SmsTime = AllListSms.Deserialize<ClsTimeSms>(AllListSms.SmsTime, "SmsTimeSend");
            AllListSms.EmailTime = AllListSms.Deserialize<ClsTimeEmail>(AllListSms.EmailTime, "EmailTimeSend");
            if (AllListSms.Param.Count <= 0)
            {
                ColorParam C = new ColorParam();
                C.ColorFont = SystemColors.ControlText.ToArgb().ToString();
                C.ColorBack = SystemColors.ControlLight.ToArgb().ToString();
                AllListSms.Param.Add(C);
            }
            foreach (Segment S in AllListSms.SegmentList)
                DgvSegement.Rows.Add(S.NumS.ToString(), S.NomS, S.DateCreationS);
            Parametre.OpenForms.Add(this);
            bool IsNotSend = false;
            int NbrMes = 0;
            int SmsNotSend = 0;
            foreach (SMSCls S in AllListSms.SmsList) {
                if (S.SendContact.Count<S.AllContact.Count) {
                    IsNotSend = true;
                    break;
                }
                NbrMes += S.SendContact.Count;
                SmsNotSend += S.AllContact.Count - S.SendContact.Count;
            }
            NbrMessage.Text = NbrMes.ToString();
            NbrCompagne.Text = AllListSms.Compagne.Count.ToString();
            NbrSegment.Text = AllListSms.SegmentList.Count.ToString();
            if (IsNotSend)
                RnvMessage.Enabled = true;
            else
            {
                RnvMessage.Enabled = true;
                RnvMessage.BackColor = Color.Gray;
                RnvMessage.Visible = false;
            }
            
            //new SmsParametre().ShowDialog();
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
            AllListSms.BGWSms = backgroundWorker1;
            AllListSms.BGWEmail = backgroundWorker2;
            timer1.Start();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AddSegment(DgvSegement).ShowDialog();
        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new AddCompagne().ShowDialog();
        }

        private void smsParametreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SmsParametre().ShowDialog();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            //List<Order> SortedList = objListOrder.OrderBy(o=>o.OrderDate).ToList();
            AllListSms.Serialize<Segment>(AllListSms.SegmentList.OrderBy(c => c.NumS).ToList(), "Segment");
            AllListSms.Serialize<Contact>(AllListSms.Contacts.OrderBy(c => c.NumC).ToList(), "Contact");
            AllListSms.Serialize<Compagne>(AllListSms.Compagne.OrderBy(c => c.Num).ToList(), "Compagne");
            AllListSms.Serialize<SMSCls>(AllListSms.SmsList.OrderBy(c => c.SmsNum).ToList(), "SmsInfo");
            AllListSms.Serialize<ColorParam>(AllListSms.Param.ToList(), "Color");
            AllListSms.Serialize<EmailInfo>(AllListSms.EmailInfo, "EmailInfo");
            AllListSms.Serialize<ClsTimeSms>(AllListSms.SmsTime, "SmsTimeSend");
            AllListSms.Serialize<ClsTimeEmail>(AllListSms.EmailTime, "EmailTimeSend");
            Application.Exit();
        }

        private void laListeDesCompagneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCompagne().ShowDialog();
        }

        private void laListeDesSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SmsForm().ShowDialog();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            new SmsForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllListSms.InsertFromSegment(int.Parse(DgvSegement.CurrentRow.Cells[0].Value.ToString()));
            new SendFrm().ShowDialog();
        }

        private void RnvMessage_Click(object sender, EventArgs e)
        {
            if (!AllListSms.IsConfig)
            {
                new SmsParametre().ShowDialog();
            }
            foreach (SMSCls S in AllListSms.SmsList)
            {
                AllListSms.ContactForSms.Clear();
                AllListSms.ContactForSms.AddRange(AllListSms.FindUnSendSms(S.SmsNum));
                foreach (Contact C in AllListSms.ContactForSms)
                {
                    if (SendSmsToPhone.Send(S.SmsMessage, C.Tel) == 2)
                    {
                        S.SendContact.Add(C);
                    }
                    else {
                        MessageBox.Show("Erreur d'envoi");
                        break;
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new FrmListContact(int.Parse(DgvSegement.CurrentRow.Cells[0].Value.ToString())).ShowDialog();
        }

        private void emailParamétreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmailSetting().ShowDialog();
        }
        private void SendPlanifierMethod() {
            
        }
        //Background Work For SMS
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            if (!AllListSms.IsConfig && AllListSms.SmsTime.Count > 0)
            {
                new SmsParametre().ShowDialog();
            }
            StepReload:
            while (AllListSms.SmsTime.Count>0) {
                List<Contact> SendTime = new List<Contact>();
                if (AllListSms.SmsTime.Count > 0)
                {
                    foreach (ClsTimeSms ST in AllListSms.SmsTime)
                    {
                        if (DateTime.Now >= ST.SmsTime)
                        {
                            foreach (Contact C in ST.SmsInfoTime.AllContact)
                            {
                                if (ST.SmsInfoTime.SendContact.SingleOrDefault(S => S.NumC == C.NumC) == null)
                                    SendTime.Add(C);
                            }
                            foreach (Contact SendC in SendTime)
                            {
                                if (SendSmsToPhone.Send(AllListSms.ChangeInfo(SendC,ST.SmsInfoTime.SmsMessage), SendC.Tel) == 2)
                                {
                                    ST.SmsInfoTime.SendContact.Add(SendC);
                                }
                            }
                            if (ST.SmsInfoTime.SendContact.Count == ST.SmsInfoTime.AllContact.Count)
                            {
                                ST.SmsInfoTime.SmsNum = (AllListSms.SmsList.Count > 0) ? AllListSms.SmsList[AllListSms.SmsList.Count - 1].SmsNum + 1 : 1;
                                AllListSms.SmsList.Add(ST.SmsInfoTime);
                                AllListSms.SmsTime.Remove(ST);
                                
                                goto StepReload;
                            }
                        }
                    }
                }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new EmailFrm().Show();
        }

        private void listeDesEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmailFrm().ShowDialog();
        }
        //Background Work For Email
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            if (!AllListSms.EmailIsConfig && AllListSms.EmailTime.Count > 0)
            {
                new EmailSetting().ShowDialog();
            }
            StepReload:
            while (AllListSms.EmailTime.Count>0) {
                foreach (ClsTimeEmail EmailTime in AllListSms.EmailTime) {
                    if (EmailTime.SmsTime>=DateTime.Now) {
                        if (SendEmail.Send(EmailTime.EmailInfoTime.AllContact, EmailTime.EmailInfoTime.Obj, EmailTime.EmailInfoTime.Messge, EmailTime.EmailInfoTime.Attachment,EmailTime.IsHTML)) {
                            EmailTime.EmailInfoTime.EmailNum = (AllListSms.EmailInfo.Count > 0) ? AllListSms.EmailInfo[AllListSms.EmailInfo.Count - 1].EmailNum + 1 : 1;
                            EmailTime.EmailInfoTime.From = AllListSms.SelectedEmail.UserName;
                            AllListSms.EmailInfo.Add(EmailTime.EmailInfoTime);
                            AllListSms.EmailTime.Remove(EmailTime);
                            goto StepReload;
                        }
                    }
                }
            }
        }

        private void listeDesSmsPlanifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSmsPlanifier().ShowDialog();
        }

        private void listeDesEmailsPlanifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEmailPlanifier().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Parametre.BackColor = Color.FromArgb(int.Parse(AllListSms.Param[0].ColorBack));
            Parametre.FontColor = Color.FromArgb(int.Parse(AllListSms.Param[0].ColorFont));
            Parametre.ChangeColor();
            timer1.Stop();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            new InfoPlanifier().Show();
        }
    }
}