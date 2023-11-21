using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_port_assistant
{
    public partial class FormSerialPortTool : Form
    {
        private List<byte> receiveBuffer = new List<byte>();

        private List<byte> sendBuffer = new List<byte>();

        private int receiveCount = 0;

        private int sendCount = 0;

        bool isDataReceiving = true;

        private Queue<byte> dataFrameQueue = new Queue<byte>();

        private bool isHeadReceived = false;

        private int frameLength = 0;

        public TransmitData transmitData;

        public event TransmitEventHandle transmitBytes;

        public DecodeDataProcess decodeDataProcess;
        
        private string fileRead;

        public FormSerialPortTool()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        // 界面初始化
        private void FormSerialPortTool_Load(object sender, EventArgs e)
        {
            // 获取串口信息
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\Serialcomm");

            string[] portNames = key.GetValueNames();
            foreach (string portName in portNames)
            {
                comboBoxPortNumber.Items.Add((string)key.GetValue(portName));
            }

            // 加载默认值
            comboBoxPortNumber.SelectedIndex = 0;
            comboBoxBaudRate.SelectedIndex = 1;
            comboBoxParityBit.SelectedIndex = 0;
            comboBoxDataBits.SelectedIndex = 3;
            comboBoxStopBit.SelectedIndex = 0;

            // 子窗口
            Child_Window child_Window = new Child_Window();

            // 传递委托
            //transmitData += child_Window.ReceiveData;
            //child_Window.childSend += sendBytes;
            transmitBytes += new TransmitEventHandle(child_Window.ReceiveBytes);
            child_Window.childSendEvent += new TransmitEventHandle(sendBytes2);
            
            child_Window.Show();

            decodeDataProcess = new DecodeDataProcess(new SimpleDecodeDataFrame());
        }

        private void sendBytes2(object sender, TransmitEventArgs e)
        {
            if (e.data.Length > 0)
            {
                serialPort1.Write(e.data, 0, e.data.Length);
                sendCount += e.data.Length;
                toolStripStatusLabelSendCount.Text = sendCount.ToString();
            }
        }

        private void sendBytes(byte[] data)
        {
            if (data.Length > 0)
            {
                serialPort1.Write(data, 0, data.Length);
                sendCount += data.Length;
                toolStripStatusLabelSendCount.Text = sendCount.ToString();
            }
        }

        // 串口打开关闭
        private void buttonOpenSerialPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    // 传参
                    serialPort1.PortName = comboBoxPortNumber.Text;
                    
                    serialPort1.BaudRate = int.Parse(comboBoxBaudRate.Text);
                    
                    switch(comboBoxParityBit.SelectedIndex)
                    {
                        // NONE ODD EVEN
                        case 0:
                            serialPort1.Parity = Parity.None; 
                            break;
                        case 1:
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case 2:
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            serialPort1.Parity = Parity.None;
                            break;
                    }
                    
                    serialPort1.DataBits = int.Parse(comboBoxDataBits.Text);
                    
                    switch (comboBoxStopBit.SelectedIndex)
                    {
                        // 1 1.5 2
                        case 0:
                            serialPort1.StopBits = StopBits.One;
                            break;
                        case 1:
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case 2:
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default :
                            serialPort1.StopBits = StopBits.One;
                            break;
                    }

                    serialPort1.Open();
                    buttonOpenSerialPort.Text = "关闭串口";
                    toolStripStatusLabelStatus.Text = $"{comboBoxPortNumber.Text}串口已打开";
                }
                
               else
                {
                    serialPort1.Close();
                    buttonOpenSerialPort.Text = "打开串口";
                    toolStripStatusLabelStatus.Text = $"{comboBoxPortNumber.Text}串口已关闭";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelStatus.Text = "串口异常";
                MessageBox.Show(ex.ToString());
            }
        }

        // 发送数据
        public void SendData()
        {
            string text = richTextBoxSend.Text.Replace(" ", "");
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("请输入发送数据");
                richTextBoxSend.Focus();
                return;
            }

            if (checkBoxHexSend.Checked)
            {
                if (!DataEncoding.IsHexString(text))
                {
                    MessageBox.Show("请输入正确的十六进制字符串");
                    richTextBoxSend.Focus();
                    return;
                }
                sendBuffer.Clear();
                sendBuffer.AddRange(Transform.ToBytes(text));
            }
            else
            {
                sendBuffer.Clear();
                sendBuffer.AddRange(Encoding.GetEncoding("GB2312").GetBytes(text));
            }
        }

        private void buttonManualSend_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("请先打开串口");
                return;
            }

            SendData();
            sendBytes(sendBuffer.ToArray());
        }

        // 接收数据
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (isDataReceiving)
            {
                byte[] dataBytes = new byte[serialPort1.BytesToRead];
                serialPort1.Read(dataBytes, 0, dataBytes.Length);
                receiveBuffer.AddRange(dataBytes);
                receiveCount += dataBytes.Length;

                // ?.表示如果transmitData不为空则调用
                //transmitData?.Invoke(dataBytes);
                transmitBytes?.Invoke(this, new TransmitEventArgs() { data = dataBytes });

                this.Invoke((EventHandler)(delegate
                {
                    if (!checkBoxDataFrameReception.Checked)
                    {
                        if (!checkBoxHexReceive.Checked)
                        {
                            string dataString = Encoding.GetEncoding("GB2312").GetString(dataBytes);
                            dataString = dataString.Replace("\0", "\\0");
                            richTextBoxReceive.AppendText(dataString);
                        }
                        else
                        {
                            // 十六进制显示
                            richTextBoxReceive.AppendText(Transform.ToHexString(dataBytes, " "));
                        } 
                    }
                    else
                    {
                        // 解析数据帧

                        foreach (byte dataByte in dataBytes)
                        {
                            // 入列
                            dataFrameQueue.Enqueue(dataByte);
                        }

                        
                        byte[] dataFrame = decodeDataProcess.getDataFrame(dataFrameQueue);
                        
                        if (dataFrame != null)
                        {
                            richTextBoxDataFrame.AppendText(Transform.ToHexString(dataFrame, " "));
                            textBoxData1.Text = String.Format("{0:X2}", dataFrame[2]);
                            textBoxData2.Text = String.Format("{0:X2}", dataFrame[3]);
                            textBoxData3.Text = String.Format("{0:X2}", dataFrame[4]);
                            textBoxData4.Text = String.Format("{0:X2}", dataFrame[5]);
                        }

                        for (int i = 0; i < dataFrame.Length; i++)
                        {
                            dataFrameQueue.Dequeue();
                        }

#if old
                        if (!isHeadReceived)
                        {
                            while (dataFrameQueue.Count > 0)
                            {
                                byte dataByte = dataFrameQueue.Peek();
                                if (dataByte == 0x7f)
                                {
                                    isHeadReceived = true;
                                    Console.WriteLine("Head received");
                                    break;
                                }
                                else
                                {
                                    dataFrameQueue.Dequeue();
                                    Console.WriteLine("Not 0x7f, dequeue!");
                                }
                            }
                        }

                        if (isHeadReceived && dataFrameQueue.Count >= 2)
                        {
                            byte[] queueArray = dataFrameQueue.ToArray();
                            Console.WriteLine(DateTime.Now.ToString());
                            Console.WriteLine($"Show dataFrameQueue: {Transform.ToHexString(queueArray, " ")}");
                            frameLength = queueArray[1];
                            Console.WriteLine($"Frame length: {String.Format("{0:X2}", frameLength)}");

                            // 判断数据帧是否完整
                            if (dataFrameQueue.Count >= frameLength + 4)
                            {
                                // 完整
                                byte[] dataFrame = new byte[frameLength + 4];
                                Array.Copy(queueArray, dataFrame, frameLength + 4);

                                // TODO: 数据帧处理
                                if (crcCheck(dataFrame))
                                {
                                    Console.WriteLine("Frame check passed.");
                                    richTextBoxDataFrame.AppendText(Transform.ToHexString(dataFrame, " "));
                                    textBoxData1.Text = String.Format("{0:X2}", dataFrame[2]);
                                    textBoxData2.Text = String.Format("{0:X2}", dataFrame[3]);
                                    textBoxData3.Text = String.Format("{0:X2}", dataFrame[4]);
                                    textBoxData4.Text = String.Format("{0:X2}", dataFrame[5]);
                                }
                                else
                                {
                                    Console.WriteLine("Bad frame, drop it. ");
                                }

                                // 出列
                                for (int i = 0; i < frameLength + 4; i++)
                                {
                                    dataFrameQueue.Dequeue();
                                }
                            }
                            else
                            {
                                // 不完整
                                Console.WriteLine("Not enough data, wait for next data");
                            }
                        } 
#endif
                    }

                    toolStripStatusLabelReceiveCount.Text = receiveCount.ToString();
                }));
                //string datareceive = serialPort1.ReadExisting();
                //richTextBoxReceive.AppendText(datareceive);
            }
        }

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

        // 暂停接收
        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (buttonPause.Text == "暂停")
            {
                buttonPause.Text = "继续";
                isDataReceiving = false;
            }
            else
            {
                buttonPause.Text = "暂停";
                isDataReceiving = true;
                serialPort1.DiscardInBuffer();
            }
        }

        // 接收区十六进制显示
        private void checkBoxHexReceive_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBoxReceive.Text != "")
            {
                if (checkBoxHexReceive.Checked)
                {
                    richTextBoxReceive.Text = Transform.ToHexString(receiveBuffer.ToArray(), " ");
                }
                else
                {
                    richTextBoxReceive.Text = Encoding.GetEncoding("GB2312").GetString(receiveBuffer.ToArray()).Replace("\0", "\\0");
                }
            }
        }

        // 手动清空接收区
        private void buttonManualClear_Click(object sender, EventArgs e)
        {
            receiveBuffer.Clear();
            receiveCount = 0;
            toolStripStatusLabelReceiveCount.Text = "0";
            richTextBoxReceive.Clear();
        }

        // 自动清空接收区
        private void checkBoxAutoClear_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoClear.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (richTextBoxReceive.Text.Length > 4096)
            {
                receiveBuffer.Clear();
                receiveCount = 0;
                toolStripStatusLabelReceiveCount.Text = "0";
                richTextBoxReceive.Clear();
            }
        }

        // 发送区十六进制显示
        private void checkBoxHexSend_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBoxSend.Text != "")
            {
                if (checkBoxHexSend.Checked)
                {
                    // 将文本转换为十六进制
                    byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(richTextBoxSend.Text);
                    richTextBoxSend.Text = Transform.ToHexString(bytes, " ");
                }
                else
                {
                    // 将十六进制转换为文本
                    byte[] bytes = Transform.ToBytes(richTextBoxSend.Text.Replace(" ", ""));
                    richTextBoxSend.Text = Encoding.GetEncoding("GB2312").GetString(bytes).Replace("\0", "\\0");
                }
            }
        }

        // 手动清空发送区
        private void buttonClearSend_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            sendCount = 0;
            toolStripStatusLabelSendCount.Text = "0";
            richTextBoxSend.Clear();
        }

        private void checkBoxAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            // 串口未打开
            if (!serialPort1.IsOpen && checkBoxAutoSend.Checked)
            {
                MessageBox.Show("请先打开串口");
                checkBoxAutoSend.Checked = false;
                if (timer2 != null)
                {
                    timer2.Enabled = false;
                    timer2.Stop();
                    timer2 = null;
                }
                return;
            }
            
            if (checkBoxAutoSend.Checked)
            {
                textBoxAutoSendInterval.Enabled = false;
                buttonManualSend.Enabled = false;

                int interval = Convert.ToInt32(textBoxAutoSendInterval.Text);
                if (interval < 10 || interval > 60*1000)
                {
                    MessageBox.Show("自动发送数据的周期范围是10-60000毫秒", "警告");
                    textBoxAutoSendInterval.Text = "1000";
                    interval = 1000;
                }
                timer2.Interval = interval;
                timer2.Start();
            }
            else
            {
                textBoxAutoSendInterval.Enabled = true;
                buttonManualSend.Enabled = true;
                
                if (timer2 != null)
                {
                    timer2.Enabled = false;
                    timer2.Stop();
                    timer2 = null;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("请先打开串口");
                return;
            }

            SendData();
            sendBytes(sendBuffer.ToArray());
        }

        private void toolStripStatusLabelClearCount_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            sendCount = 0;
            toolStripStatusLabelSendCount.Text = "0";

            receiveBuffer.Clear();
            receiveCount = 0;
            toolStripStatusLabelReceiveCount.Text = "0";
        }

        private void checkBoxRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRTS.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void checkBoxDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDTR.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择文件保存路径";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveData.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSaveData.Text))
            {
                return;
            }
            
            string fileName = textBoxSaveData.Text + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            StreamWriter streamWriter = new StreamWriter(fileName, true, Encoding.GetEncoding("GB2312"));
            streamWriter.Write(richTextBoxReceive.Text);
            streamWriter.Flush();
            streamWriter.Close();
            MessageBox.Show("保存成功");
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开文件";
            openFileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFile.Text = openFileDialog.FileName;
                StreamReader streamReader = new StreamReader(textBoxOpenFile.Text, Encoding.GetEncoding("GB2312"));
                fileRead = streamReader.ReadToEnd();
                richTextBoxSend.Text = fileRead;
                streamReader.Close();
                MessageBox.Show("打开成功");
            }
        }

        private void buttonSendFile_Click(object sender, EventArgs e)
        {
            if (fileRead == null)
            {
                MessageBox.Show("请先打开文件");
                return;
            }

            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("请先打开串口");
                return;
            }

            try
            {
                byte[] data = Encoding.GetEncoding("GB2312").GetBytes(fileRead);
                sendCount += data.Length;
                toolStripStatusLabelSendCount.Text = sendCount.ToString();
                int pageNumbers = data.Length / 4096;
                int lastPage = data.Length % 4096;
                
                for (int i = 0; i < pageNumbers; i++)
                {
                    serialPort1.Write(data, (i * 4096), 4096);
                    Thread.Sleep(10);
                }
                if (lastPage != 0)
                {
                    serialPort1.Write(data, (pageNumbers * 4096), lastPage);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("发送数据失败" + ex.Message.ToString(), "错误");
            }
        }
    }
}
