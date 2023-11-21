using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_port_assistant
{
    public partial class Child_Window : Form
    {
        public TransmitData childSend;

        public event TransmitEventHandle childSendEvent;

        public Child_Window()
        {
            InitializeComponent();
        }

        public void ReceiveData(byte[] dataBytes)
        {
            string dataString = Encoding.GetEncoding("GB2312").GetString(dataBytes);
            dataString = dataString.Replace("\0", "\\0");
            richTextBoxReceive.AppendText(dataString);
        }

        internal void ReceiveBytes(object sender, TransmitEventArgs e)
        {
            string dataString = Encoding.GetEncoding("GB2312").GetString(e.data);
            dataString = dataString.Replace("\0", "\\0");
            richTextBoxReceive.AppendText(dataString);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            byte[] dataBytes = Encoding.GetEncoding("GB2312").GetBytes(textBoxSend.Text);
            childSend?.Invoke(dataBytes);
            childSendEvent?.Invoke(this, new TransmitEventArgs() { data = dataBytes });
        }
    }
}
