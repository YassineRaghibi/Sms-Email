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
    public partial class AddCompagne : Form
    {
        public DataGridView Dgv = null;
        public AddCompagne()
        {
            InitializeComponent();
        }
        public AddCompagne(DataGridView Dgv) {
            InitializeComponent();
            AddButton.Text = "Modifier";
            this.Dgv = Dgv;
            Compagne CF = AllListSms.FindCompagne(int.Parse(Dgv.CurrentRow.Cells[0].Value.ToString()));
            txtNom.Text = CF.Nom;
            Debut.Value = CF.DateDebut;
            Fin.Value = CF.DateFin;
        }
        public FrmCompagne F = null;
        public AddCompagne(FrmCompagne F) {
            InitializeComponent();
            this.F = F;
        }
        private void AddCompagne_Load(object sender, EventArgs e)
        {
            Parametre.OpenForms.Add(this);
            Parametre.ChangeColor();
        }

        private void AddCompagne_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parametre.OpenForms.Remove(this);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Debut.Value < Fin.Value && txtNom.Text != "")
            {
                Compagne C = new Compagne((AllListSms.Compagne.Count > 0) ? AllListSms.Compagne[AllListSms.Compagne.Count - 1].Num + 1 : 1, txtNom.Text, Debut.Value, Fin.Value);
                if (Dgv == null)
                {
                    AllListSms.Compagne.Add(C);
                    if (F!=null) {
                        F.SetData();
                    }
                }
                else {
                    Compagne CF = AllListSms.FindCompagne(int.Parse(Dgv.CurrentRow.Cells[0].Value.ToString()));
                    C.Num = CF.Num = int.Parse(Dgv.CurrentRow.Cells[0].Value.ToString());
                    CF.Nom = C.Nom;
                    CF.DateDebut = C.DateDebut;
                    CF.DateFin = C.DateFin;
                    Dgv.CurrentRow.SetValues(C.Num, C.Nom, C.DateDebut, C.DateFin);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Les données incorrect");
            }
        }
    }
}
