using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_port_assistant
{
    public abstract class DecodeData
    {
        public abstract byte[] DecodeDataFrame(Queue<byte> buffer);
    }
}
