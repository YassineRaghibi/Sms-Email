using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class EmailFrm : Form
    {
        public EmailFrm()
        {
            InitializeComponent();
        }

        private void EmailFrm_Load(object sender, EventArgs e)
        {
            foreach (EmailInfo Email in AllListSms.EmailInfo) {
                EmailInfo.Rows.Add(Email.EmailNum,Email.Messge,Email.Time,Email.AllContact.Count,(Email.Cmp!=null)? Email.Cmp.Nom:"Null");
            }
            Parametre.OpenForms.Add(this);
            Parametre.ChangeColor();
        }

        

        private void EmailInfo_SelectionChanged(object sender, EventArgs e)
        {
            EmailInfo EmailInfoFind = AllListSms.FindEmailByNum(int.Parse(EmailInfo.CurrentRow.Cells[0].Value.ToString()));
            if (EmailInfoFind != null)
            {
                DgvContact.Rows.Clear();
                Obj.Text = (EmailInfoFind.Obj != "") ? "Objet: " + EmailInfoFind.Obj: "";
                From.Text = EmailInfoFind.From;
                TxtMessageText.Text = "Message: "+EmailInfoFind.Messge;
                int Row;
                dataGridView1.Rows.Clear();
                foreach (string Attachment in EmailInfoFind.Attachment) {
                    dataGridView1.Rows.Add(Attachment);
                }
                foreach (Contact c in EmailInfoFind.AllContact)
                {
                    Row = DgvContact.Rows.Add("", c.NumC, c.PrenomC, c.NomC, c.Email, c.VilleC, c.PayerC, c.FonctionC);
                    if (EmailInfoFind.SendContact.SingleOrDefault(S => S.NumC == c.NumC) == null)
                    {
                        DgvContact.Rows[Row].Cells[0].Style.BackColor = Color.Red;
                    }
                    else
                        DgvContact.Rows[Row].Cells[0].Style.BackColor = Color.Green;
                }
                if (EmailInfoFind.AllContact.Count - EmailInfoFind.SendContact.Count > 0)
                    BtnRenvoi.Enabled = true;
                else
                    BtnRenvoi.Enabled = false;
            }
            DgvContact.Rows[0].Selected = true;
            SetData();
        }
        private void SetData()
        {
            int i = 2;
            Label[] L = { LblPrenomC, LblNonC, LblTelec, LblVilleC, LblPayeC, LblFonctionC };
            foreach (Label l in L)
            {
                l.Text = DgvContact.CurrentRow.Cells[i].Value.ToString();
                i++;
                /*if (AllListSms.FindContactSmsByNum(int.Parse(SmsInfo.CurrentRow.Cells[0].Value.ToString()), int.Parse(DgvContact.CurrentRow.Cells["Num"].Value.ToString())).Segment1!=null)
                {
                    List<Segment> S = new List<Segment>();
                    S.AddRange(AllListSms.FindContactSmsByNum(int.Parse(SmsInfo.CurrentRow.Cells[0].Value.ToString()), int.Parse(DgvContact.CurrentRow.Cells["Num"].Value.ToString())).Segment1);
                    SegDgv.Rows.Clear();
                    foreach (Segment s in S)
                        SegDgv.Rows.Add(s.NomS);
                }*/
            }
        }

        private void DgvContact_SelectionChanged(object sender, EventArgs e)
        {
            SetData();
        }
    }
}
