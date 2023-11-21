using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_port_assistant
{
    // 创建委托
    public delegate void TransmitData(byte[] data);

    public delegate void TransmitEventHandle(object sender, TransmitEventArgs e);
    public class TransmitEventArgs: EventArgs
    {
        public byte[] data { get; set; }
    }
}
