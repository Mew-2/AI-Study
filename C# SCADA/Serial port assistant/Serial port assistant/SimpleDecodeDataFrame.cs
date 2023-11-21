using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_port_assistant
{
    public class SimpleDecodeDataFrame: DecodeData
    {
        private bool isHeadReceived = false;
        private byte frameLength;

        // CRC校验
        private bool crcCheck(byte[] dataFrame)
        {
            byte[] temp = new byte[dataFrame.Length - 2];
            Array.Copy(dataFrame, temp, dataFrame.Length - 2);
            byte[] crc = DataCheck.DataCrc16_Ccitt(temp, DataCheck.BigOrLittle.BigEndian);

            if (crc[0] == dataFrame[dataFrame.Length - 2] && crc[1] == dataFrame[dataFrame.Length - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override byte[] DecodeDataFrame(Queue<byte> buffer)
        {
            // 实现算法解析数据帧，返回解析后的数据
            if (!isHeadReceived)
            {
                while (buffer.Count > 0)
                {
                    byte dataByte = buffer.Peek();
                    if (dataByte == 0x7f)
                    {
                        isHeadReceived = true;
                        Console.WriteLine("Head received");
                        break;
                    }
                    else
                    {
                        buffer.Dequeue();
                        Console.WriteLine("Not 0x7f, dequeue!");
                    }
                }
            }

            if (isHeadReceived && buffer.Count >= 2)
            {
                byte[] queueArray = buffer.ToArray();
                Console.WriteLine(DateTime.Now.ToString());
                Console.WriteLine($"Show dataFrameQueue: {Transform.ToHexString(queueArray, " ")}");
                frameLength = queueArray[1];
                Console.WriteLine($"Frame length: {String.Format("{0:X2}", frameLength)}");

                // 判断数据帧是否完整
                if (buffer.Count >= frameLength + 4)
                {
                    // 完整
                    byte[] dataFrame = new byte[frameLength + 4];
                    Array.Copy(queueArray, dataFrame, frameLength + 4);

                    // TODO: 数据帧处理
                    if (crcCheck(dataFrame))
                    {
                        Console.WriteLine("Frame check passed.");

                        return dataFrame;
                    }
                    else
                    {
                        Console.WriteLine("Bad frame, drop it. ");

                        for (int i = 0; i < dataFrame.Length; i++)
                        {
                            buffer.Dequeue();
                        }
                    }

                   
                }
                else
                {
                    // 不完整
                    Console.WriteLine("Not enough data, wait for next data");
                }
            }

            return null;
        }
    }
}
