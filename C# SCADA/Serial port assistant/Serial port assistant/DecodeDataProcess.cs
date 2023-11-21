using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_port_assistant
{
    public class DecodeDataProcess
    {
        private DecodeData decodeData;
        public DecodeDataProcess(DecodeData decodeData)
        {
            this.decodeData = decodeData;
        }
        public byte[] getDataFrame(Queue<byte> buffer)
        {
            return decodeData.DecodeDataFrame(buffer);
        }
    }
}
