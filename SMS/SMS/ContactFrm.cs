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
    public partial class ContactFrm : Form
    {
        public int Id = -1;
        public FrmListContact FrmContact = null;
        public DataGridView Dgv;
        public ContactFrm()
        {
            InitializeComponent();
        }
        public ContactFrm(int Id,FrmListContact FrmContact,DataGridView Dgv)
        {
            InitializeComponent();
            button5.Text = "Modifier";
            Contact Ct = AllListSms.Findcontact(Id);
            TxtNom.Text = Ct.NomC;
            TxtPrenom.Text = Ct.PrenomC;
            TxtEmail.Text = Ct.Email;
            txtFonction.Text = Ct.FonctionC;
            TxtTel.Text = Ct.Tel;
            TxtVille.Text = Ct.VilleC;
            int i = 1;
            string TextSegement = "";
            foreach (Segment S in Ct.Segment1)
            {
                if(Ct.Segment1.Count>i)
                    TextSegement += S.NumS+"-"+S.NomS+"|";
                else
                    TextSegement += S.NumS + "-" + S.NomS;
                i++;
            }
            txtSegment.Text = TextSegement;
            TxtPaye.Text = Ct.PayerC;
            this.Id = Id;
            this.FrmContact = FrmContact;
            this.Dgv = Dgv;
        }
        public ContactFrm(FrmListContact Frm)
        {
            InitializeComponent();
            this.FrmContact = Frm;
        }
        private void ContactFrm_Load(object sender, EventArgs e)
        {
            Parametre.OpenForms.Add(this);
            Parametre.ChangeColor();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void Abdelah<T>(List<T> Lis){
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Verification.GetVerification(this)) {
                try
                {
                    int.Parse(TxtTel.Text);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erreur des donnée");
                    return;
                }
                Contact C = new Contact((AllListSms.Contacts.Count > 0) ? AllListSms.Contacts[AllListSms.Contacts.Count - 1].NumC + 1 : 1, TxtNom.Text, TxtPrenom.Text, TxtTel.Text, TxtEmail.Text, TxtVille.Text, TxtPaye.Text, txtFonction.Text, (txtSegment.Text!="")?AllListSms.GetListSegment(txtSegment.Text):new List<Segment>());
                if (Id<0) {
                    if (AllListSms.FindcontactByNum(TxtTel.Text) == null)
                    {
                        AllListSms.Contacts.Add(C);
                        MessageBox.Show("Le contact est ajouter");
                    }
                    else {
                        MessageBox.Show("Le numéro est déja ajouter");
                    }
                    if (FrmContact!=null) {
                        FrmContact.DataSelect();
                    }
                }
                else
                {
                    Contact NewC = AllListSms.Findcontact(Id);
                    if (NewC != null)
                    {
                        NewC.NomC = TxtNom.Text;
                        NewC.PrenomC = TxtPrenom.Text;
                        NewC.Email = TxtEmail.Text;
                        NewC.FonctionC = txtFonction.Text;
                        NewC.Tel = TxtTel.Text;
                        NewC.VilleC = TxtVille.Text;
                        NewC.PayerC =TxtPaye.Text;
                        NewC.Segment1 = AllListSms.GetListSegment(txtSegment.Text);
                        Dgv.CurrentRow.SetValues(false, NewC.NumC, NewC.NomC, NewC.PrenomC, NewC.Tel, NewC.VilleC, NewC.PayerC, NewC.FonctionC);
                    }
                    else {
                        this.Close();
                    }
                }
                this.Close();
            }
        }

        private void ContactFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parametre.OpenForms.Remove(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new SegementSelect(txtSegment).ShowDialog();
        }
    }
}
