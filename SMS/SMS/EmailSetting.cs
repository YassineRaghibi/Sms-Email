using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
namespace SMS
{
    public partial class EmailSetting : Form
    {
        private string PasswordHash;
        private string SaltKey;
        private string VIKey;
        public EmailSetting()
        {
            InitializeComponent();
        }
        public int SelectedIndex = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            this.PasswordHash = "PasswordHash" + CodeSecure.Text;
            this.SaltKey = CodeSecure.Text+"@(-)963+-*5+'("+this.PasswordHash;
            this.VIKey = "@1B2c3D4e5F6g7HGd";
            if(SelectedIndex<0){
                Email E = new Email((AllListSms.EmailSettingList.Count > 0) ? AllListSms.EmailSettingList[AllListSms.EmailSettingList.Count - 1].Id + 1 : 1,ServerName.Text, PortName.Text,Email.Text, Encrypt(Password.Text));
                AllListSms.EmailSettingList.Add(E);
                AllListSms.SelectedEmail = E;
                AllListSms.Password = Password.Text;
            }else{
                AllListSms.SelectedEmail = AllListSms.FindEmail(SelectedIndex);
                AllListSms.Password = Password.Text;
            }
            AllListSms.EmailIsConfig = true;
            this.Close();
        }
        private void EmailSetting_Load(object sender, EventArgs e)
        {
            AllListSms.EmailSettingList = AllListSms.Deserialize<Email>(AllListSms.EmailSettingList, "EmailList");
            foreach (Email E in AllListSms.EmailSettingList)
                EmailBox.Items.Add(E.Id+"-"+E.UserName);
            Parametre.OpenForms.Add(this);
            Parametre.ChangeColor();
        }
        private string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }
        private string Decrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        private void EmailBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           int Id = int.Parse(EmailBox.GetItemText(EmailBox.Items[EmailBox.SelectedIndex]).Split('-')[0]);
           Email Ef= AllListSms.FindEmail(Id);
            if (Ef != null) {
                ServerName.Text = Ef.StmpServer;
                PortName.Text = Ef.StmpPort;
                Email.Text = Ef.UserName;
                ServerName.Enabled = false;
                PortName.Enabled = false;
                Email.Enabled = false;
                Password.Enabled = false;
                CodeSecure.Enabled = false;
                Stop:
                string CodeValue = "";
                DialogResult Code = Prompt.InputBox("Secure Code", "Donnéer le code de securite", ref CodeValue);
                if (Code==DialogResult.Cancel)
                {
                    ServerName.Text = "";
                    PortName.Text = "";
                    Email.Text = "";
                    Password.Text = "";
                    CodeSecure.Text = "";
                    ServerName.Enabled = true;
                    PortName.Enabled = true;
                    Email.Enabled = true;
                    Password.Enabled = true;
                    CodeSecure.Enabled = true;
                    return;
                }
                if (Code == DialogResult.OK && CodeValue.Trim() != "")
                {
                    CodeSecure.Text = CodeValue;
                    this.PasswordHash = "PasswordHash" + CodeSecure.Text;
                    this.SaltKey = CodeSecure.Text + "@(-)963+-*5+'(" + this.PasswordHash;
                    this.VIKey = "@1B2c3D4e5F6g7HGd";
                    Password.Text = Decrypt(Ef.Password);
                    if (Ef.Password != Encrypt(Password.Text))
                    {
                        MessageBox.Show("Invalide Secure Code");
                        goto Stop;
                    }
                    else
                    {
                        MessageBox.Show("Email est selectionner: "+Email.Text);
                        SelectedIndex = int.Parse(EmailBox.GetItemText(EmailBox.Items[EmailBox.SelectedIndex]).Split('-')[0]);
                    }
                }
                else {
                    goto Stop;
                }
                
            }
        }

        private void EmailSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            AllListSms.Serialize<Email>(AllListSms.EmailSettingList, "EmailList");
        }
    }
}
