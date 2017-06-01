using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace SMS
{
    class Parametre 
    {
        public static Color BackColor = Color.FromName("ControlLight");
        public static Color FontColor = Color.FromName("ControlText");
        public static List<Form> OpenForms = new List<Form>();
        public static void ChangeColor() {
            foreach (Form F in OpenForms) {
                F.BackColor = BackColor;
                F.ForeColor = FontColor;
            }
        }
        
    }
}
