namespace Serial_port_assistant
{
    partial class FormSerialPortTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDTR = new System.Windows.Forms.CheckBox();
            this.checkBoxRTS = new System.Windows.Forms.CheckBox();
            this.buttonOpenSerialPort = new System.Windows.Forms.Button();
            this.labelStopBit = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelParityBit = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelPortNumber = new System.Windows.Forms.Label();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParityBit = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxPortNumber = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSaveData = new System.Windows.Forms.TextBox();
            this.checkBoxHexReceive = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoClear = new System.Windows.Forms.CheckBox();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonManualClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxAutoSendInterval = new System.Windows.Forms.TextBox();
            this.labelCycle = new System.Windows.Forms.Label();
            this.textBoxOpenFile = new System.Windows.Forms.TextBox();
            this.checkBoxHexSend = new System.Windows.Forms.CheckBox();
            this.buttonManualSend = new System.Windows.Forms.Button();
            this.checkBoxAutoSend = new System.Windows.Forms.CheckBox();
            this.buttonClearSend = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonSendFile = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBoxReceive = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBoxSend = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSendCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelReceiveCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelClearCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDataFrameReception = new System.Windows.Forms.CheckBox();
            this.richTextBoxDataFrame = new System.Windows.Forms.RichTextBox();
            this.labelDataFrame = new System.Windows.Forms.Label();
            this.labelData4 = new System.Windows.Forms.Label();
            this.labelData2 = new System.Windows.Forms.Label();
            this.labelData3 = new System.Windows.Forms.Label();
            this.labelData1 = new System.Windows.Forms.Label();
            this.textBoxData4 = new System.Windows.Forms.TextBox();
            this.textBoxData3 = new System.Windows.Forms.TextBox();
            this.textBoxData2 = new System.Windows.Forms.TextBox();
            this.textBoxData1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDTR);
            this.groupBox1.Controls.Add(this.checkBoxRTS);
            this.groupBox1.Controls.Add(this.buttonOpenSerialPort);
            this.groupBox1.Controls.Add(this.labelStopBit);
            this.groupBox1.Controls.Add(this.labelDataBits);
            this.groupBox1.Controls.Add(this.labelParityBit);
            this.groupBox1.Controls.Add(this.labelBaudRate);
            this.groupBox1.Controls.Add(this.labelPortNumber);
            this.groupBox1.Controls.Add(this.comboBoxStopBit);
            this.groupBox1.Controls.Add(this.comboBoxDataBits);
            this.groupBox1.Controls.Add(this.comboBoxParityBit);
            this.groupBox1.Controls.Add(this.comboBoxBaudRate);
            this.groupBox1.Controls.Add(this.comboBoxPortNumber);
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // checkBoxDTR
            // 
            this.checkBoxDTR.AutoSize = true;
            this.checkBoxDTR.Location = new System.Drawing.Point(9, 209);
            this.checkBoxDTR.Name = "checkBoxDTR";
            this.checkBoxDTR.Size = new System.Drawing.Size(53, 19);
            this.checkBoxDTR.TabIndex = 3;
            this.checkBoxDTR.Text = "DTR";
            this.checkBoxDTR.UseVisualStyleBackColor = true;
            this.checkBoxDTR.CheckedChanged += new System.EventHandler(this.checkBoxDTR_CheckedChanged);
            // 
            // checkBoxRTS
            // 
            this.checkBoxRTS.AutoSize = true;
            this.checkBoxRTS.Location = new System.Drawing.Point(9, 184);
            this.checkBoxRTS.Name = "checkBoxRTS";
            this.checkBoxRTS.Size = new System.Drawing.Size(53, 19);
            this.checkBoxRTS.TabIndex = 3;
            this.checkBoxRTS.Text = "RTS";
            this.checkBoxRTS.UseVisualStyleBackColor = true;
            this.checkBoxRTS.CheckedChanged += new System.EventHandler(this.checkBoxRTS_CheckedChanged);
            // 
            // buttonOpenSerialPort
            // 
            this.buttonOpenSerialPort.Location = new System.Drawing.Point(97, 184);
            this.buttonOpenSerialPort.Name = "buttonOpenSerialPort";
            this.buttonOpenSerialPort.Size = new System.Drawing.Size(121, 44);
            this.buttonOpenSerialPort.TabIndex = 2;
            this.buttonOpenSerialPort.Text = "打开串口";
            this.buttonOpenSerialPort.UseVisualStyleBackColor = true;
            this.buttonOpenSerialPort.Click += new System.EventHandler(this.buttonOpenSerialPort_Click);
            // 
            // labelStopBit
            // 
            this.labelStopBit.AutoSize = true;
            this.labelStopBit.Location = new System.Drawing.Point(6, 143);
            this.labelStopBit.Name = "labelStopBit";
            this.labelStopBit.Size = new System.Drawing.Size(52, 15);
            this.labelStopBit.TabIndex = 1;
            this.labelStopBit.Text = "停止位";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(6, 114);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(52, 15);
            this.labelDataBits.TabIndex = 1;
            this.labelDataBits.Text = "数据位";
            // 
            // labelParityBit
            // 
            this.labelParityBit.AutoSize = true;
            this.labelParityBit.Location = new System.Drawing.Point(6, 85);
            this.labelParityBit.Name = "labelParityBit";
            this.labelParityBit.Size = new System.Drawing.Size(52, 15);
            this.labelParityBit.TabIndex = 1;
            this.labelParityBit.Text = "校验位";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(6, 56);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(52, 15);
            this.labelBaudRate.TabIndex = 1;
            this.labelBaudRate.Text = "波特率";
            // 
            // labelPortNumber
            // 
            this.labelPortNumber.AutoSize = true;
            this.labelPortNumber.Location = new System.Drawing.Point(6, 27);
            this.labelPortNumber.Name = "labelPortNumber";
            this.labelPortNumber.Size = new System.Drawing.Size(52, 15);
            this.labelPortNumber.TabIndex = 1;
            this.labelPortNumber.Text = "端口号";
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBoxStopBit.Location = new System.Drawing.Point(97, 140);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStopBit.TabIndex = 0;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(97, 111);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDataBits.TabIndex = 0;
            // 
            // comboBoxParityBit
            // 
            this.comboBoxParityBit.FormattingEnabled = true;
            this.comboBoxParityBit.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.comboBoxParityBit.Location = new System.Drawing.Point(97, 82);
            this.comboBoxParityBit.Name = "comboBoxParityBit";
            this.comboBoxParityBit.Size = new System.Drawing.Size(121, 23);
            this.comboBoxParityBit.TabIndex = 0;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(97, 53);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBaudRate.TabIndex = 0;
            // 
            // comboBoxPortNumber
            // 
            this.comboBoxPortNumber.FormattingEnabled = true;
            this.comboBoxPortNumber.Location = new System.Drawing.Point(97, 24);
            this.comboBoxPortNumber.Name = "comboBoxPortNumber";
            this.comboBoxPortNumber.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPortNumber.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSaveData);
            this.groupBox2.Controls.Add(this.checkBoxHexReceive);
            this.groupBox2.Controls.Add(this.checkBoxAutoClear);
            this.groupBox2.Controls.Add(this.buttonSelectPath);
            this.groupBox2.Controls.Add(this.buttonSaveData);
            this.groupBox2.Controls.Add(this.buttonPause);
            this.groupBox2.Controls.Add(this.buttonManualClear);
            this.groupBox2.Location = new System.Drawing.Point(26, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // textBoxSaveData
            // 
            this.textBoxSaveData.Location = new System.Drawing.Point(10, 124);
            this.textBoxSaveData.Name = "textBoxSaveData";
            this.textBoxSaveData.Size = new System.Drawing.Size(204, 25);
            this.textBoxSaveData.TabIndex = 3;
            // 
            // checkBoxHexReceive
            // 
            this.checkBoxHexReceive.AutoSize = true;
            this.checkBoxHexReceive.Location = new System.Drawing.Point(9, 59);
            this.checkBoxHexReceive.Name = "checkBoxHexReceive";
            this.checkBoxHexReceive.Size = new System.Drawing.Size(89, 19);
            this.checkBoxHexReceive.TabIndex = 2;
            this.checkBoxHexReceive.Text = "十六进制";
            this.checkBoxHexReceive.UseVisualStyleBackColor = true;
            this.checkBoxHexReceive.CheckedChanged += new System.EventHandler(this.checkBoxHexReceive_CheckedChanged);
            // 
            // checkBoxAutoClear
            // 
            this.checkBoxAutoClear.AutoSize = true;
            this.checkBoxAutoClear.Location = new System.Drawing.Point(9, 23);
            this.checkBoxAutoClear.Name = "checkBoxAutoClear";
            this.checkBoxAutoClear.Size = new System.Drawing.Size(89, 19);
            this.checkBoxAutoClear.TabIndex = 2;
            this.checkBoxAutoClear.Text = "自动清空";
            this.checkBoxAutoClear.UseVisualStyleBackColor = true;
            this.checkBoxAutoClear.CheckedChanged += new System.EventHandler(this.checkBoxAutoClear_CheckedChanged);
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(9, 88);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(89, 30);
            this.buttonSelectPath.TabIndex = 1;
            this.buttonSelectPath.Text = "选择路径";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(124, 88);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(89, 30);
            this.buttonSaveData.TabIndex = 0;
            this.buttonSaveData.Text = "保存数据";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(124, 52);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(89, 30);
            this.buttonPause.TabIndex = 0;
            this.buttonPause.Text = "暂停";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonManualClear
            // 
            this.buttonManualClear.Location = new System.Drawing.Point(124, 16);
            this.buttonManualClear.Name = "buttonManualClear";
            this.buttonManualClear.Size = new System.Drawing.Size(89, 30);
            this.buttonManualClear.TabIndex = 0;
            this.buttonManualClear.Text = "手动清空";
            this.buttonManualClear.UseVisualStyleBackColor = true;
            this.buttonManualClear.Click += new System.EventHandler(this.buttonManualClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxAutoSendInterval);
            this.groupBox3.Controls.Add(this.labelCycle);
            this.groupBox3.Controls.Add(this.textBoxOpenFile);
            this.groupBox3.Controls.Add(this.checkBoxHexSend);
            this.groupBox3.Controls.Add(this.buttonManualSend);
            this.groupBox3.Controls.Add(this.checkBoxAutoSend);
            this.groupBox3.Controls.Add(this.buttonClearSend);
            this.groupBox3.Controls.Add(this.buttonOpenFile);
            this.groupBox3.Controls.Add(this.buttonSendFile);
            this.groupBox3.Location = new System.Drawing.Point(26, 441);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 201);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // textBoxAutoSendInterval
            // 
            this.textBoxAutoSendInterval.Location = new System.Drawing.Point(150, 165);
            this.textBoxAutoSendInterval.Name = "textBoxAutoSendInterval";
            this.textBoxAutoSendInterval.Size = new System.Drawing.Size(63, 25);
            this.textBoxAutoSendInterval.TabIndex = 5;
            this.textBoxAutoSendInterval.Text = "1000";
            // 
            // labelCycle
            // 
            this.labelCycle.AutoSize = true;
            this.labelCycle.Location = new System.Drawing.Point(7, 172);
            this.labelCycle.Name = "labelCycle";
            this.labelCycle.Size = new System.Drawing.Size(137, 15);
            this.labelCycle.TabIndex = 4;
            this.labelCycle.Text = "自动发送周期(ms):";
            // 
            // textBoxOpenFile
            // 
            this.textBoxOpenFile.Location = new System.Drawing.Point(9, 130);
            this.textBoxOpenFile.Name = "textBoxOpenFile";
            this.textBoxOpenFile.Size = new System.Drawing.Size(204, 25);
            this.textBoxOpenFile.TabIndex = 3;
            // 
            // checkBoxHexSend
            // 
            this.checkBoxHexSend.AutoSize = true;
            this.checkBoxHexSend.Location = new System.Drawing.Point(10, 60);
            this.checkBoxHexSend.Name = "checkBoxHexSend";
            this.checkBoxHexSend.Size = new System.Drawing.Size(89, 19);
            this.checkBoxHexSend.TabIndex = 2;
            this.checkBoxHexSend.Text = "十六进制";
            this.checkBoxHexSend.UseVisualStyleBackColor = true;
            this.checkBoxHexSend.CheckedChanged += new System.EventHandler(this.checkBoxHexSend_CheckedChanged);
            // 
            // buttonManualSend
            // 
            this.buttonManualSend.Location = new System.Drawing.Point(124, 17);
            this.buttonManualSend.Name = "buttonManualSend";
            this.buttonManualSend.Size = new System.Drawing.Size(89, 30);
            this.buttonManualSend.TabIndex = 0;
            this.buttonManualSend.Text = "手动发送";
            this.buttonManualSend.UseVisualStyleBackColor = true;
            this.buttonManualSend.Click += new System.EventHandler(this.buttonManualSend_Click);
            // 
            // checkBoxAutoSend
            // 
            this.checkBoxAutoSend.AutoSize = true;
            this.checkBoxAutoSend.Location = new System.Drawing.Point(10, 24);
            this.checkBoxAutoSend.Name = "checkBoxAutoSend";
            this.checkBoxAutoSend.Size = new System.Drawing.Size(89, 19);
            this.checkBoxAutoSend.TabIndex = 2;
            this.checkBoxAutoSend.Text = "自动发送";
            this.checkBoxAutoSend.UseVisualStyleBackColor = true;
            this.checkBoxAutoSend.CheckedChanged += new System.EventHandler(this.checkBoxAutoSend_CheckedChanged);
            // 
            // buttonClearSend
            // 
            this.buttonClearSend.Location = new System.Drawing.Point(124, 53);
            this.buttonClearSend.Name = "buttonClearSend";
            this.buttonClearSend.Size = new System.Drawing.Size(89, 30);
            this.buttonClearSend.TabIndex = 0;
            this.buttonClearSend.Text = "清空发送";
            this.buttonClearSend.UseVisualStyleBackColor = true;
            this.buttonClearSend.Click += new System.EventHandler(this.buttonClearSend_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(10, 89);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(89, 30);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "打开文件";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonSendFile
            // 
            this.buttonSendFile.Location = new System.Drawing.Point(124, 89);
            this.buttonSendFile.Name = "buttonSendFile";
            this.buttonSendFile.Size = new System.Drawing.Size(89, 30);
            this.buttonSendFile.TabIndex = 0;
            this.buttonSendFile.Text = "发送文件";
            this.buttonSendFile.UseVisualStyleBackColor = true;
            this.buttonSendFile.Click += new System.EventHandler(this.buttonSendFile_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBoxReceive);
            this.groupBox4.Location = new System.Drawing.Point(256, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 413);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // richTextBoxReceive
            // 
            this.richTextBoxReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxReceive.Location = new System.Drawing.Point(3, 21);
            this.richTextBoxReceive.Name = "richTextBoxReceive";
            this.richTextBoxReceive.Size = new System.Drawing.Size(419, 389);
            this.richTextBoxReceive.TabIndex = 0;
            this.richTextBoxReceive.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBoxSend);
            this.groupBox5.Location = new System.Drawing.Point(256, 441);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(425, 201);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // richTextBoxSend
            // 
            this.richTextBoxSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSend.Location = new System.Drawing.Point(3, 21);
            this.richTextBoxSend.Name = "richTextBoxSend";
            this.richTextBoxSend.Size = new System.Drawing.Size(419, 177);
            this.richTextBoxSend.TabIndex = 0;
            this.richTextBoxSend.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelSendCount,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabelReceiveCount,
            this.toolStripStatusLabelClearCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 645);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "状态：";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.AutoSize = false;
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(200, 20);
            this.toolStripStatusLabelStatus.Text = "初始化正常！";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel3.Text = "发送计数：";
            // 
            // toolStripStatusLabelSendCount
            // 
            this.toolStripStatusLabelSendCount.AutoSize = false;
            this.toolStripStatusLabelSendCount.Name = "toolStripStatusLabelSendCount";
            this.toolStripStatusLabelSendCount.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabelSendCount.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel5.Text = "接收计数：";
            // 
            // toolStripStatusLabelReceiveCount
            // 
            this.toolStripStatusLabelReceiveCount.AutoSize = false;
            this.toolStripStatusLabelReceiveCount.Name = "toolStripStatusLabelReceiveCount";
            this.toolStripStatusLabelReceiveCount.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabelReceiveCount.Text = "0";
            // 
            // toolStripStatusLabelClearCount
            // 
            this.toolStripStatusLabelClearCount.Name = "toolStripStatusLabelClearCount";
            this.toolStripStatusLabelClearCount.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabelClearCount.Text = "清空计数";
            this.toolStripStatusLabelClearCount.Click += new System.EventHandler(this.toolStripStatusLabelClearCount_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.checkBoxDataFrameReception);
            this.groupBox6.Controls.Add(this.richTextBoxDataFrame);
            this.groupBox6.Controls.Add(this.labelDataFrame);
            this.groupBox6.Controls.Add(this.labelData4);
            this.groupBox6.Controls.Add(this.labelData2);
            this.groupBox6.Controls.Add(this.labelData3);
            this.groupBox6.Controls.Add(this.labelData1);
            this.groupBox6.Controls.Add(this.textBoxData4);
            this.groupBox6.Controls.Add(this.textBoxData3);
            this.groupBox6.Controls.Add(this.textBoxData2);
            this.groupBox6.Controls.Add(this.textBoxData1);
            this.groupBox6.Location = new System.Drawing.Point(687, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(220, 413);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "指令解析";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "例：7F0431323334DE10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "7F+长度+数据+CRC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "格式：";
            // 
            // checkBoxDataFrameReception
            // 
            this.checkBoxDataFrameReception.AutoSize = true;
            this.checkBoxDataFrameReception.Location = new System.Drawing.Point(25, 287);
            this.checkBoxDataFrameReception.Name = "checkBoxDataFrameReception";
            this.checkBoxDataFrameReception.Size = new System.Drawing.Size(134, 19);
            this.checkBoxDataFrameReception.TabIndex = 4;
            this.checkBoxDataFrameReception.Text = "启动数据帧接收";
            this.checkBoxDataFrameReception.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDataFrame
            // 
            this.richTextBoxDataFrame.Location = new System.Drawing.Point(25, 184);
            this.richTextBoxDataFrame.Name = "richTextBoxDataFrame";
            this.richTextBoxDataFrame.Size = new System.Drawing.Size(176, 96);
            this.richTextBoxDataFrame.TabIndex = 3;
            this.richTextBoxDataFrame.Text = "";
            // 
            // labelDataFrame
            // 
            this.labelDataFrame.AutoSize = true;
            this.labelDataFrame.Location = new System.Drawing.Point(22, 160);
            this.labelDataFrame.Name = "labelDataFrame";
            this.labelDataFrame.Size = new System.Drawing.Size(52, 15);
            this.labelDataFrame.TabIndex = 2;
            this.labelDataFrame.Text = "数据帧";
            // 
            // labelData4
            // 
            this.labelData4.AutoSize = true;
            this.labelData4.Location = new System.Drawing.Point(22, 122);
            this.labelData4.Name = "labelData4";
            this.labelData4.Size = new System.Drawing.Size(45, 15);
            this.labelData4.TabIndex = 1;
            this.labelData4.Text = "数据4";
            // 
            // labelData2
            // 
            this.labelData2.AutoSize = true;
            this.labelData2.Location = new System.Drawing.Point(22, 60);
            this.labelData2.Name = "labelData2";
            this.labelData2.Size = new System.Drawing.Size(45, 15);
            this.labelData2.TabIndex = 1;
            this.labelData2.Text = "数据2";
            // 
            // labelData3
            // 
            this.labelData3.AutoSize = true;
            this.labelData3.Location = new System.Drawing.Point(22, 91);
            this.labelData3.Name = "labelData3";
            this.labelData3.Size = new System.Drawing.Size(45, 15);
            this.labelData3.TabIndex = 1;
            this.labelData3.Text = "数据3";
            // 
            // labelData1
            // 
            this.labelData1.AutoSize = true;
            this.labelData1.Location = new System.Drawing.Point(22, 29);
            this.labelData1.Name = "labelData1";
            this.labelData1.Size = new System.Drawing.Size(45, 15);
            this.labelData1.TabIndex = 1;
            this.labelData1.Text = "数据1";
            // 
            // textBoxData4
            // 
            this.textBoxData4.Location = new System.Drawing.Point(101, 119);
            this.textBoxData4.Name = "textBoxData4";
            this.textBoxData4.Size = new System.Drawing.Size(100, 25);
            this.textBoxData4.TabIndex = 0;
            // 
            // textBoxData3
            // 
            this.textBoxData3.Location = new System.Drawing.Point(101, 88);
            this.textBoxData3.Name = "textBoxData3";
            this.textBoxData3.Size = new System.Drawing.Size(100, 25);
            this.textBoxData3.TabIndex = 0;
            // 
            // textBoxData2
            // 
            this.textBoxData2.Location = new System.Drawing.Point(101, 57);
            this.textBoxData2.Name = "textBoxData2";
            this.textBoxData2.Size = new System.Drawing.Size(100, 25);
            this.textBoxData2.TabIndex = 0;
            // 
            // textBoxData1
            // 
            this.textBoxData1.Location = new System.Drawing.Point(101, 26);
            this.textBoxData1.Name = "textBoxData1";
            this.textBoxData1.Size = new System.Drawing.Size(100, 25);
            this.textBoxData1.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormSerialPortTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 671);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSerialPortTool";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.FormSerialPortTool_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxParityBit;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxPortNumber;
        private System.Windows.Forms.RichTextBox richTextBoxReceive;
        private System.Windows.Forms.RichTextBox richTextBoxSend;
        private System.Windows.Forms.Label labelStopBit;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelParityBit;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelPortNumber;
        private System.Windows.Forms.CheckBox checkBoxDTR;
        private System.Windows.Forms.CheckBox checkBoxRTS;
        private System.Windows.Forms.Button buttonOpenSerialPort;
        private System.Windows.Forms.CheckBox checkBoxHexReceive;
        private System.Windows.Forms.CheckBox checkBoxAutoClear;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonManualClear;
        private System.Windows.Forms.TextBox textBoxSaveData;
        private System.Windows.Forms.TextBox textBoxOpenFile;
        private System.Windows.Forms.CheckBox checkBoxHexSend;
        private System.Windows.Forms.Button buttonManualSend;
        private System.Windows.Forms.CheckBox checkBoxAutoSend;
        private System.Windows.Forms.Button buttonClearSend;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonSendFile;
        private System.Windows.Forms.TextBox textBoxAutoSendInterval;
        private System.Windows.Forms.Label labelCycle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSendCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelReceiveCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClearCount;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelData4;
        private System.Windows.Forms.Label labelData2;
        private System.Windows.Forms.Label labelData3;
        private System.Windows.Forms.Label labelData1;
        private System.Windows.Forms.TextBox textBoxData4;
        private System.Windows.Forms.TextBox textBoxData3;
        private System.Windows.Forms.TextBox textBoxData2;
        private System.Windows.Forms.TextBox textBoxData1;
        private System.Windows.Forms.CheckBox checkBoxDataFrameReception;
        private System.Windows.Forms.RichTextBox richTextBoxDataFrame;
        private System.Windows.Forms.Label labelDataFrame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
    }
}

