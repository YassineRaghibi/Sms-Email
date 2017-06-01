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
    public partial class FrmCompagne : Form
    {
        public FrmCompagne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddCompagne(this).ShowDialog();
        }

        private void FrmCompagne_Load(object sender, EventArgs e)
        {
            Parametre.OpenForms.Add(this);
            Parametre.ChangeColor();
            SetData();
        }

        public void SetData(){
            CompagneDgv.Rows.Clear();
            foreach (Compagne C in AllListSms.Compagne)
                CompagneDgv.Rows.Add(C.Num, C.Nom, C.DateDebut, C.DateFin);
        }
        private void Modifier_Click(object sender, EventArgs e)
        {
            new AddCompagne(CompagneDgv).ShowDialog();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult Info = MessageBox.Show("Voullez vous supprimer ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Info==DialogResult.Yes)
            {
                AllListSms.Compagne.Remove(AllListSms.FindCompagne(int.Parse(CompagneDgv.CurrentRow.Cells[0].Value.ToString())));
                CompagneDgv.Rows.Remove(CompagneDgv.CurrentRow);
            }
        }

        private void FrmCompagne_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parametre.OpenForms.Remove(this);
        }
    }
}
