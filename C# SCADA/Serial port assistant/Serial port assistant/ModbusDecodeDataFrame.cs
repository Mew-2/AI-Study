using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_port_assistant
{
    public class ModbusDecodeDataFrame: DecodeData
    {
        public override byte[] DecodeDataFrame(Queue<byte> buffer)
        {
            // Modebus解析算法
            // codes here
            return null;
        }
    }
}
