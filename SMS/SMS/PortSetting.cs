using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace SMS
{
    public class PortSetting
    {
        public SerialPort SerialPort;
        public int p_uReadTimeout;
        public int P_uWriteTimeout;
        public PortSetting() {
        }
        public PortSetting(
        SerialPort SerialPort,
        int p_uReadTimeout,
        int P_uWriteTimeout) {
            this.SerialPort = SerialPort;
            this.p_uReadTimeout = p_uReadTimeout;
            this.P_uWriteTimeout = P_uWriteTimeout;
        }
    }
}
