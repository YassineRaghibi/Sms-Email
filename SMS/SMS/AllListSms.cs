using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Xml;
using System.Xml.Serialization;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
namespace SMS
{
    public class AllListSms
    {
        public static List<Contact> Contacts = new List<Contact>();
        public static List<Contact> ContactForSms = new List<Contact>();
        public static List<Segment> SegmentList = new List<Segment>();
        public static List<Compagne> Compagne = new List<Compagne>();
        public static List<SMSCls> SmsList = new List<SMSCls>();
        public static List<ColorParam> Param = new List<ColorParam>();
        public static List<Email> EmailSettingList = new List<Email>();
        public static List<string> Attachment = new List<string>();
        public static Email SelectedEmail = null;
        public static string Password;
        public static string Port = "";
        public static bool IsConfig = false;
        public static bool EmailIsConfig = false;
        public static List<EmailInfo> EmailInfo = new List<EmailInfo>();
        public static List<ClsTimeSms> SmsTime = new List<ClsTimeSms>();
        public static List<ClsTimeEmail> EmailTime = new List<ClsTimeEmail>();
        public static BackgroundWorker BGWSms;
        public static BackgroundWorker BGWEmail;
        public static string ChangeInfo(Contact C,string Message){
            string TxtMessageReplace = Message;
            TxtMessageReplace = TxtMessageReplace.Replace("**Nom**", C.NomC);
            TxtMessageReplace = TxtMessageReplace.Replace("**Prenom**", C.PrenomC);
            TxtMessageReplace = TxtMessageReplace.Replace("**Email**", C.Email);
            TxtMessageReplace = TxtMessageReplace.Replace("**Tel**", C.Tel);
            TxtMessageReplace = TxtMessageReplace.Replace("**Fonction**", C.FonctionC);
            return TxtMessageReplace;
        }
        public static void InsertFromSegment(int Id) {
            ContactForSms.Clear();
            foreach(Contact C in Contacts){
                foreach(Segment S in C.Segment1 ){
                    if(S.NumS==Id){
                        ContactForSms.Add(C);
                    }
                }
            }
        }
        public static SMSCls FindSmsByNum(int Num){
            SMSCls sms = null;
            foreach (SMSCls S in SmsList) {
                if (S.SmsNum==Num) {
                    sms = S;
                }
            }
            return sms;
        }
        public static EmailInfo FindEmailByNum(int Num)
        {
            EmailInfo sms = null;
            foreach (EmailInfo S in EmailInfo)
            {
                if (S.EmailNum == Num)
                {
                    sms = S;
                }
            }
            return sms;
        }
        public static Contact FindContactSmsByNum(int NumSms,  int Num)
        {
            Contact sms = null;
            foreach (Contact C in FindSmsByNum(NumSms).AllContact)
            {
                if (C.NumC==Num)
                {
                    sms = C;
                    break;
                }
            }
            return sms;
        }
        public static List<Contact> FindUnSendSms(int NumSms) {
            List<Contact> Con = new List<Contact>();
            SMSCls FSms = FindSmsByNum(NumSms);
            if (FSms != null)
            {
                foreach (Contact C in FSms.AllContact)
                {
                    bool IsExist = false;
                    foreach (Contact SendC in FSms.SendContact) {
                        if (SendC.NumC==C.NumC) {
                            IsExist = true;
                        }
                    }
                    if(!IsExist)
                        Con.Add(C);
                }
            }
            return Con;
        }
        #region Serialisation 
        public static List<T> Deserialize<T>(List<T> list, string FileName)
        {
            if (File.Exists(FileName))
            {
                XmlSerializer serializer = new XmlSerializer(list.GetType());
                StreamReader lecteur = new StreamReader(FileName);
                list = (List<T>)serializer.Deserialize(lecteur);
                lecteur.Close();
            }
            return list;
        }
        public static void Serialize<T>(List<T> list, string FileName)
        {
            XmlSerializer serializer = new XmlSerializer(list.GetType());
            StreamWriter ecrivain = new StreamWriter(FileName, false);
            serializer.Serialize(ecrivain, list);
            ecrivain.Close();
        }

        #endregion
        public static Compagne FindCompagne(int Id)
        {
            Compagne FindCompagne = null;
            foreach (Compagne C in Compagne)
            {
                if (C.Num == Id)
                {
                    FindCompagne = C;
                    break;
                }
            }
            return FindCompagne;
        }

        #region Contact
        public static Contact Findcontact(int Id) {
            Contact FindCont = null;
            foreach (Contact C in Contacts) { 
                if(C.NumC==Id){
                    FindCont = C;
                    break;
                }
            }
            return FindCont;
        }
        public static Contact FindcontactByNum(string Id)
        {
            Contact FindCont = null;
            foreach (Contact C in Contacts)
            {
                if (C.Tel == Id)
                {
                    FindCont = C;
                    break;
                }
            }
            return FindCont;
        }

        public static Contact FindIfThisContactIsAddInList(int id) {
            Contact C = null;
            foreach (Contact CT in ContactForSms) {
                if (CT.NumC==id) {
                    C = CT;
                    break;
                }
            }
            return C;
        }
    #endregion
    #region Segment
        public static List<Segment> GetListSegment(string SegmentString) {
            List<Segment> ListS = new List<Segment>();
            if (SegmentString.Trim() != "")
            {
                string[] SegmentSplit = SegmentString.Split('|');
                foreach (string S in SegmentSplit)
                {
                    ListS.Add(FindSegment(int.Parse(S.Split('-')[0])));
                }
            }
            return ListS;
        }
        public static Segment FindSegment(int id)
        {
            Segment SF = null;
            foreach (Segment S in SegmentList)
            {
                if (S.NumS==id) {
                    SF = S;
                    break;
                }
            }
            return SF;
        }
        #endregion
        #region Email
        public static Email FindEmail(int id) {
            Email E = null;
            foreach(Email EF in EmailSettingList)
            {
                if(EF.Id==id)
                {
                    E = EF;
                    break;
                }
            }
            return E;
        }
        #endregion
        public static ClsTimeSms FindFromSmsPlanifier(int ID) {
            ClsTimeSms Find = null;
            foreach (ClsTimeSms Sp in SmsTime) {
                if (Sp.num==ID) {
                    Find = Sp;
                    break;
                }
            }
            return Find;
        }

        public static ClsTimeEmail FindFromEmailPlanifier(int ID)
        {
            ClsTimeEmail Find = null;
            foreach (ClsTimeEmail Sp in EmailTime)
            {
                if (Sp.Num == ID)
                {
                    Find = Sp;
                    break;
                }
            }
            return Find;
        }

    }
}
