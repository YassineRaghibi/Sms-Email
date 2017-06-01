using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class Email
    {
        public int Id;
        public string StmpServer;
        public string StmpPort;
        public string UserName;
        public string Password;
        public Email(    int Id, string StmpServer, string StmpPort, string User ,string Password)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.StmpPort = StmpPort;
            this.StmpServer = StmpServer;
            this.Password = Password;
        }
        public Email() { }
    }
}
