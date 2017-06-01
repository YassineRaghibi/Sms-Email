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
    public partial class FrmEmailPlanifier : Form
    {
        public FrmEmailPlanifier()
        {
            InitializeComponent();
        }

        private void FrmEmailPlanifier_Load(object sender, EventArgs e)
        {
            foreach (ClsTimeEmail Sp in AllListSms.EmailTime)
            {
                DgvSmsP.Rows.Add(Sp.Num, Sp.SmsTime, Sp.EmailInfoTime.Messge);
            }
            Parametre.OpenForms.Add(this);
            Parametre.ChangeColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AllListSms.BGWEmail.IsBusy)
            {
                AllListSms.BGWEmail.CancelAsync();
            }
            AllListSms.EmailTime.Remove(AllListSms.FindFromEmailPlanifier(int.Parse(DgvSmsP.CurrentRow.Cells[0].Value.ToString())));
            if (AllListSms.EmailTime.Count > 0)
            {
                AllListSms.BGWEmail.RunWorkerAsync();
            }
            DgvSmsP.Rows.Remove(DgvSmsP.CurrentRow);
        }
    }
}
