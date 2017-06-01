using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class EmailInfo
    {
        public int EmailNum;
        public String From;
        public string Obj;
        public string Messge;
        public List<Contact> AllContact = new List<Contact>();
        public List<Contact> SendContact = new List<Contact>();
        public List<string> Attachment = new List<string>();
        public DateTime Time;
        public Compagne Cmp;
        public EmailInfo(int EmailNum,
        string Obj,
        string Messge,
        List<Contact> AllContact,
        List<string> Attachment,
        DateTime Time,
        string From)
        {
            this.Time = Time;
            this.EmailNum = EmailNum;
            this.Obj = Obj;
            this.From = From;
            this.Messge = Messge;
            this.AllContact.AddRange(AllContact);
            this.Attachment.AddRange(Attachment);
        }
        public EmailInfo(int EmailNum,
        string Obj,
        string Messge,
        List<Contact> AllContact,
        List<string> Attachment,
        DateTime Time)
        {
            this.Time = Time;
            this.EmailNum = EmailNum;
            this.Obj = Obj;
            this.Messge = Messge;
            this.AllContact.AddRange(AllContact);
            this.Attachment.AddRange(Attachment);
        }
        public EmailInfo() { }
    }
}
