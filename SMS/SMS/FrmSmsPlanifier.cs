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
    public partial class FrmSmsPlanifier : Form
    {
        public FrmSmsPlanifier()
        {
            InitializeComponent();
        }

        private void FrmSmsPlanifier_Load(object sender, EventArgs e)
        {
            foreach (ClsTimeSms Sp in AllListSms.SmsTime) {
                DgvSmsP.Rows.Add(Sp.num,Sp.SmsTime,Sp.SmsInfoTime.SmsMessage);
            }
            Parametre.OpenForms.Add(this);
            Parametre.ChangeColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AllListSms.BGWSms.IsBusy)
            {
                AllListSms.BGWSms.CancelAsync();
            }
            AllListSms.SmsTime.Remove(AllListSms.FindFromSmsPlanifier(int.Parse(DgvSmsP.CurrentRow.Cells[0].Value.ToString())));
            if (AllListSms.SmsTime.Count>0) {
                AllListSms.BGWSms.RunWorkerAsync();
            }
            DgvSmsP.Rows.Remove(DgvSmsP.CurrentRow);
        }
    }
}
