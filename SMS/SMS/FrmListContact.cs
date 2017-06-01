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
    public partial class FrmListContact : Form
    {
        public bool Ok;
        public FrmListContact()
        {
            InitializeComponent();
        }
        public int NumSegment = -1;
        public FrmListContact(int NumSegment) {
            InitializeComponent();
            this.NumSegment = NumSegment;
        }
        private void FrmListContact_Load(object sender, EventArgs e)
        {
            Parametre.OpenForms.Add(this);
            Parametre.ChangeColor();
            DataSelect();
            foreach(Segment S in AllListSms.SegmentList)
            SegmentListCom.Items.Add(S.NumS+"-"+S.NomS);
            foreach (DataGridViewColumn DgvC in DgvContact.Columns)
            {
                if (DgvC.HeaderText.Trim() != "")
                {
                    comboBox1.Items.Add(DgvC.HeaderText);
                    comboBox1.SelectedIndex = 0;
                }
            }
            if (NumSegment > 0)
            {
                SegmentListCom.SelectedItem = comboBox1.Items[0];
                SegmentListCom.SelectedText = AllListSms.FindSegment(NumSegment).NumS + "-" + AllListSms.FindSegment(NumSegment).NomS;
                DgvContact.Rows.Clear();
                foreach (Contact C in AllListSms.Contacts)
                {
                    foreach (Segment S in C.Segment1)
                    {
                        if (S.NomS == SegmentListCom.SelectedItem.ToString().Split('-')[1])
                        {
                            DgvContact.Rows.Add(false, C.NumC, C.PrenomC, C.NomC, C.Tel, C.VilleC, C.PayerC, C.FonctionC);
                        }
                    }
                }
            }
        }
        public void DataSelect() {
            DgvContact.Rows.Clear();
            foreach (Contact C in AllListSms.Contacts)
            {
                DgvContact.Rows.Add(false, C.NumC, C.PrenomC, C.NomC, C.Tel, C.VilleC, C.PayerC, C.FonctionC);
            }
            DgvContact.Sort(DgvContact.Columns[1], ListSortDirection.Ascending);
        }
        private void FrmListContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parametre.OpenForms.Remove(this);
        }

        private void DgvContact_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvContact.CurrentRow != null)
            {
                int i = 2;
                Label[] L = { LblPrenomC, LblNonC, LblTelec, LblVilleC, LblPayeC, LblFonctionC };
                foreach (Label l in L)
                {
                    l.Text = DgvContact.CurrentRow.Cells[i].Value.ToString();
                    i++;
                    List<Segment> S = AllListSms.Findcontact(int.Parse(DgvContact.CurrentRow.Cells[1].Value.ToString())).Segment1;
                    SegDgv.Rows.Clear();
                    foreach (Segment s in S)
                        SegDgv.Rows.Add(s.NomS);
                }
            }
            else
            {
                Label[] L = { LblPrenomC, LblNonC, LblTelec, LblVilleC, LblPayeC, LblFonctionC };
                foreach (Label l in L)
                {
                    l.Text = "none";
                }
            }
        }

        private void ButtonSup_Click(object sender, EventArgs e)
        {
                DialogResult Info = MessageBox.Show("Voullez vous supprimer ce contact", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Info == DialogResult.Yes)
                {
                    AllListSms.Contacts.Remove(AllListSms.Findcontact(int.Parse(DgvContact.CurrentRow.Cells[1].Value.ToString())));
                    DgvContact.Rows.Remove(DgvContact.CurrentRow);
                }
        }

        

        private void ButtonMod_Click(object sender, EventArgs e)
        {
            new ContactFrm(int.Parse(DgvContact.CurrentRow.Cells[1].Value.ToString()),this,DgvContact).ShowDialog();
        }

        public bool Verification() {
            Ok = false;
            foreach (DataGridViewRow D in DgvContact.Rows)
            {
                if (Convert.ToBoolean(D.Cells[0].Value))
                {
                    Ok = true;
                    break;
                }
            }
            return Ok;
        }

        private void ButtonEnv_Click(object sender, EventArgs e)
        {
            AllListSms.ContactForSms.Clear();
            foreach (DataGridViewRow DgvR in DgvContact.Rows)
            {
                if (Convert.ToBoolean(DgvR.Cells[0].Value))
                {
                    AllListSms.ContactForSms.Add(AllListSms.Findcontact(int.Parse(DgvR.Cells["Num"].Value.ToString())));
                    DgvR.Cells[0].Value = false;
                }
            }
            if (AllListSms.ContactForSms.Count > 0)
                new SendFrm().Show();
            else
                MessageBox.Show("Selectionner les contacts");
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            new ContactFrm(this).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            new Recherche(DgvContact).ShowDialog();
        }

        private void SegmentListCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DgvContact.Rows.Clear();
            //foreach (Contact C in AllListSms.Contacts)
            //{
            //    foreach (Segment S in C.Segment1)
            //    {
            //        if (S.NomS == SegmentListCom.SelectedItem.ToString().Split('-')[1])
            //        {
            //            DgvContact.Rows.Add(false, C.NumC, C.PrenomC, C.NomC, C.Tel, C.VilleC, C.PayerC, C.FonctionC);
            //        }
            //    }
            //}
        }

        private void SegmentListCom_SelectedValueChanged(object sender, EventArgs e)
        {
            /*DgvContact.Rows.Clear();
            foreach (Contact C in AllListSms.Contacts)
            {
                foreach (Segment S in C.Segment1)
                {
                    if (S.NomS == SegmentListCom.SelectedItem.ToString().Split('-')[1])
                    {
                        DgvContact.Rows.Add(false, C.NumC, C.PrenomC, C.NomC, C.Tel, C.VilleC, C.PayerC, C.FonctionC);
                    }
                }
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int selected = 0;
            foreach (DataGridViewColumn DgvC in DgvContact.Columns)
            {

                if (DgvC.HeaderText == comboBox1.Text)
                {
                    break;
                }
                selected++;
            }
            foreach (DataGridViewRow DgvR in DgvContact.Rows)
            {
                DgvR.Visible = false;
            }
            foreach (DataGridViewRow DgvR in DgvContact.Rows)
            {
                if (DgvR.Cells[selected].Value.ToString().Length >= textBox1.Text.Length)
                {
                    if (DgvR.Cells[selected].Value.ToString().Substring(0, textBox1.Text.Length).ToUpper() == textBox1.Text.ToUpper())
                    {
                        DgvR.Visible = true;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow DgvR in DgvContact.Rows){
                DgvR.Cells[0].Value = checkBox1.Checked;
            }
        }

        private void SegmentListCom_TextChanged(object sender, EventArgs e)
        {
            List<Contact> L = new List<Contact>();
            foreach (Contact C in AllListSms.Contacts)
            {
                foreach (Segment S in C.Segment1)
                {
                    if (S.NomS == SegmentListCom.SelectedItem.ToString().Split('-')[1])
                    {
                        L.Add(C);
                    }
                }
            }
            foreach (DataGridViewRow DgvR in DgvContact.Rows)
            {
                DgvR.Visible = false;
            }
                foreach (DataGridViewRow DgvR in DgvContact.Rows)
            {
                foreach (Contact item in L)
                {
                    if (DgvR.Cells[1].Value.ToString() == item.NumC.ToString())
                    {
                        DgvR.Visible = true;
                    }
                }
            }
        }
    }
}
