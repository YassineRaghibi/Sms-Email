using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace SMS
{
    public partial class AddSegment : MaterialForm
    {
        DataGridView Dgv;
        public AddSegment(DataGridView Dgv)
        {
            InitializeComponent();
            this.Dgv = Dgv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NomSegement.Text.Trim() != "")
            {
                Segment S;
                if (Dgv.Rows.Count > 0)
                    S = new Segment(int.Parse(Dgv.Rows[Dgv.Rows.Count - 1].Cells[0].Value.ToString()) + 1, NomSegement.Text, DateTime.Now.ToString());
                else
                    S = S = new Segment(1, NomSegement.Text, DateTime.Now.ToString());
                AllListSms.SegmentList.Add(S);
                Dgv.Rows.Add(S.NumS.ToString(), S.NomS, S.DateCreationS);
                this.Close();
            }
            else {
                MessageBox.Show("Remplire le champs");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSegment_Load(object sender, EventArgs e)
        {
            NomSegement.Focus();
            Parametre.OpenForms.Add(this);
            Parametre.ChangeColor();
        }
    }
}
