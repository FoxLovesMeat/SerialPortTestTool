
namespace SerialPortTool
{
    partial class SerialPortTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialPortTool));
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.RichTextBox_RX = new System.Windows.Forms.RichTextBox();
            this.InfBox_RX_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InfBox_RX_Text全选 = new System.Windows.Forms.ToolStripMenuItem();
            this.InfBox_RX_Text清除 = new System.Windows.Forms.ToolStripMenuItem();
            this.Img_SW = new System.Windows.Forms.ImageList(this.components);
            this.SerialPortToolMenu = new System.Windows.Forms.MenuStrip();
            this.文件 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.工具 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_TXD = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_SysConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于 = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_SW = new System.Windows.Forms.Button();
            this.Img_Round = new System.Windows.Forms.ImageList(this.components);
            this.LED = new System.Windows.Forms.Button();
            this.Timer_TXMsg = new System.Windows.Forms.Timer(this.components);
            this.RichTextBox_TX = new System.Windows.Forms.RichTextBox();
            this.InfBox_TX_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InfBox_TX_Text全选 = new System.Windows.Forms.ToolStripMenuItem();
            this.InfBox_TX_Text清除 = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_TX = new System.Windows.Forms.Button();
            this.CheckBox_CycleTX = new System.Windows.Forms.CheckBox();
            this.TextBox_CycleTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Timer_SerialPortMsg = new System.Windows.Forms.Timer(this.components);
            this.InfBox_RX_Menu.SuspendLayout();
            this.SerialPortToolMenu.SuspendLayout();
            this.InfBox_TX_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(52, 39);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(84, 20);
            this.comboBox_portName.TabIndex = 1;
            this.comboBox_portName.DropDown += new System.EventHandler(this.comboBox_portName_DropDown);
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Location = new System.Drawing.Point(52, 70);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(84, 20);
            this.comboBox_baudRate.TabIndex = 1;
            this.comboBox_baudRate.DropDown += new System.EventHandler(this.comboBox_baudRate_DropDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // RichTextBox_RX
            // 
            this.RichTextBox_RX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox_RX.BackColor = System.Drawing.Color.White;
            this.RichTextBox_RX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBox_RX.ContextMenuStrip = this.InfBox_RX_Menu;
            this.RichTextBox_RX.Location = new System.Drawing.Point(153, 28);
            this.RichTextBox_RX.Name = "RichTextBox_RX";
            this.RichTextBox_RX.ReadOnly = true;
            this.RichTextBox_RX.Size = new System.Drawing.Size(500, 400);
            this.RichTextBox_RX.TabIndex = 3;
            this.RichTextBox_RX.Text = "";
            // 
            // InfBox_RX_Menu
            // 
            this.InfBox_RX_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfBox_RX_Text全选,
            this.InfBox_RX_Text清除});
            this.InfBox_RX_Menu.Name = "InfBox_RX_Menu";
            this.InfBox_RX_Menu.Size = new System.Drawing.Size(101, 48);
            // 
            // InfBox_RX_Text全选
            // 
            this.InfBox_RX_Text全选.Name = "InfBox_RX_Text全选";
            this.InfBox_RX_Text全选.Size = new System.Drawing.Size(100, 22);
            this.InfBox_RX_Text全选.Text = "全选";
            this.InfBox_RX_Text全选.Click += new System.EventHandler(this.InfBox_RX_Text全选_Click);
            // 
            // InfBox_RX_Text清除
            // 
            this.InfBox_RX_Text清除.Name = "InfBox_RX_Text清除";
            this.InfBox_RX_Text清除.Size = new System.Drawing.Size(100, 22);
            this.InfBox_RX_Text清除.Text = "清除";
            this.InfBox_RX_Text清除.Click += new System.EventHandler(this.InfBox_RX_Text清除_Click);
            // 
            // Img_SW
            // 
            this.Img_SW.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_SW.ImageStream")));
            this.Img_SW.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_SW.Images.SetKeyName(0, "switch_128px_1201385_easyicon.net.ico");
            this.Img_SW.Images.SetKeyName(1, "switch_128px_1201386_easyicon.net.ico");
            // 
            // SerialPortToolMenu
            // 
            this.SerialPortToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件,
            this.工具,
            this.帮助});
            this.SerialPortToolMenu.Location = new System.Drawing.Point(0, 0);
            this.SerialPortToolMenu.Name = "SerialPortToolMenu";
            this.SerialPortToolMenu.Size = new System.Drawing.Size(665, 25);
            this.SerialPortToolMenu.TabIndex = 6;
            this.SerialPortToolMenu.Text = "SerialPortToolMenu";
            // 
            // 文件
            // 
            this.文件.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存,
            this.退出});
            this.文件.Name = "文件";
            this.文件.Size = new System.Drawing.Size(44, 21);
            this.文件.Text = "文件";
            // 
            // 保存
            // 
            this.保存.Name = "保存";
            this.保存.Size = new System.Drawing.Size(100, 22);
            this.保存.Text = "保存";
            this.保存.Click += new System.EventHandler(this.保存_Click);
            // 
            // 退出
            // 
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(100, 22);
            this.退出.Text = "退出";
            // 
            // 工具
            // 
            this.工具.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_TXD,
            this.Tool_SysConvert});
            this.工具.Name = "工具";
            this.工具.Size = new System.Drawing.Size(44, 21);
            this.工具.Text = "工具";
            // 
            // Tool_TXD
            // 
            this.Tool_TXD.Name = "Tool_TXD";
            this.Tool_TXD.Size = new System.Drawing.Size(140, 22);
            this.Tool_TXD.Text = "TXD";
            this.Tool_TXD.Click += new System.EventHandler(this.Tool_TXD_Click);
            // 
            // Tool_SysConvert
            // 
            this.Tool_SysConvert.Name = "Tool_SysConvert";
            this.Tool_SysConvert.Size = new System.Drawing.Size(140, 22);
            this.Tool_SysConvert.Text = "SysConvert";
            // 
            // 帮助
            // 
            this.帮助.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于});
            this.帮助.Name = "帮助";
            this.帮助.Size = new System.Drawing.Size(44, 21);
            this.帮助.Text = "帮助";
            // 
            // 关于
            // 
            this.关于.Name = "关于";
            this.关于.Size = new System.Drawing.Size(100, 22);
            this.关于.Text = "关于";
            this.关于.Click += new System.EventHandler(this.关于_Click);
            // 
            // Button_SW
            // 
            this.Button_SW.AutoSize = true;
            this.Button_SW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_SW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SW.FlatAppearance.BorderSize = 0;
            this.Button_SW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_SW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_SW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SW.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_SW.ImageIndex = 0;
            this.Button_SW.ImageList = this.Img_SW;
            this.Button_SW.Location = new System.Drawing.Point(55, 96);
            this.Button_SW.Name = "Button_SW";
            this.Button_SW.Size = new System.Drawing.Size(71, 36);
            this.Button_SW.TabIndex = 4;
            this.Button_SW.UseVisualStyleBackColor = true;
            this.Button_SW.Click += new System.EventHandler(this.Button_SW_Click);
            // 
            // Img_Round
            // 
            this.Img_Round.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_Round.ImageStream")));
            this.Img_Round.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_Round.Images.SetKeyName(0, "Circle_Grey_128px_566285_easyicon.net.ico");
            this.Img_Round.Images.SetKeyName(1, "Circle_Orange_128px_566286_easyicon.net.ico");
            this.Img_Round.Images.SetKeyName(2, "Circle_Red_128px_566287_easyicon.net.ico");
            // 
            // LED
            // 
            this.LED.AutoSize = true;
            this.LED.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LED.FlatAppearance.BorderSize = 0;
            this.LED.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LED.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LED.ImageIndex = 0;
            this.LED.ImageList = this.Img_Round;
            this.LED.Location = new System.Drawing.Point(15, 99);
            this.LED.Name = "LED";
            this.LED.Size = new System.Drawing.Size(31, 31);
            this.LED.TabIndex = 7;
            this.LED.UseVisualStyleBackColor = true;
            // 
            // Timer_TXMsg
            // 
            this.Timer_TXMsg.Tick += new System.EventHandler(this.Timer_TX_Tick);
            // 
            // RichTextBox_TX
            // 
            this.RichTextBox_TX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox_TX.ContextMenuStrip = this.InfBox_TX_Menu;
            this.RichTextBox_TX.Location = new System.Drawing.Point(153, 438);
            this.RichTextBox_TX.Name = "RichTextBox_TX";
            this.RichTextBox_TX.Size = new System.Drawing.Size(440, 50);
            this.RichTextBox_TX.TabIndex = 8;
            this.RichTextBox_TX.Text = "";
            this.RichTextBox_TX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RichTextBox_TX_KeyUp);
            // 
            // InfBox_TX_Menu
            // 
            this.InfBox_TX_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfBox_TX_Text全选,
            this.InfBox_TX_Text清除});
            this.InfBox_TX_Menu.Name = "InfBox_RX_Menu";
            this.InfBox_TX_Menu.Size = new System.Drawing.Size(101, 48);
            // 
            // InfBox_TX_Text全选
            // 
            this.InfBox_TX_Text全选.Name = "InfBox_TX_Text全选";
            this.InfBox_TX_Text全选.Size = new System.Drawing.Size(100, 22);
            this.InfBox_TX_Text全选.Text = "全选";
            this.InfBox_TX_Text全选.Click += new System.EventHandler(this.InfBox_TX_Text全选_Click);
            // 
            // InfBox_TX_Text清除
            // 
            this.InfBox_TX_Text清除.Name = "InfBox_TX_Text清除";
            this.InfBox_TX_Text清除.Size = new System.Drawing.Size(100, 22);
            this.InfBox_TX_Text清除.Text = "清除";
            this.InfBox_TX_Text清除.Click += new System.EventHandler(this.InfBox_TX_Text清除_Click);
            // 
            // Button_TX
            // 
            this.Button_TX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_TX.Location = new System.Drawing.Point(603, 437);
            this.Button_TX.Name = "Button_TX";
            this.Button_TX.Size = new System.Drawing.Size(50, 50);
            this.Button_TX.TabIndex = 9;
            this.Button_TX.Text = "TX";
            this.Button_TX.UseVisualStyleBackColor = true;
            this.Button_TX.Click += new System.EventHandler(this.Button_TX_Click);
            // 
            // CheckBox_CycleTX
            // 
            this.CheckBox_CycleTX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckBox_CycleTX.AutoSize = true;
            this.CheckBox_CycleTX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CheckBox_CycleTX.Location = new System.Drawing.Point(8, 441);
            this.CheckBox_CycleTX.Name = "CheckBox_CycleTX";
            this.CheckBox_CycleTX.Size = new System.Drawing.Size(72, 16);
            this.CheckBox_CycleTX.TabIndex = 10;
            this.CheckBox_CycleTX.Text = "循环周期";
            this.CheckBox_CycleTX.UseVisualStyleBackColor = true;
            // 
            // TextBox_CycleTime
            // 
            this.TextBox_CycleTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBox_CycleTime.Location = new System.Drawing.Point(78, 438);
            this.TextBox_CycleTime.Name = "TextBox_CycleTime";
            this.TextBox_CycleTime.Size = new System.Drawing.Size(50, 21);
            this.TextBox_CycleTime.TabIndex = 11;
            this.TextBox_CycleTime.Text = "50";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "ms";
            // 
            // Timer_SerialPortMsg
            // 
            this.Timer_SerialPortMsg.Enabled = true;
            this.Timer_SerialPortMsg.Interval = 10;
            this.Timer_SerialPortMsg.Tick += new System.EventHandler(this.Timer_SerialPortMsg_Tick);
            // 
            // SerialPortTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_CycleTime);
            this.Controls.Add(this.CheckBox_CycleTX);
            this.Controls.Add(this.Button_TX);
            this.Controls.Add(this.RichTextBox_TX);
            this.Controls.Add(this.LED);
            this.Controls.Add(this.SerialPortToolMenu);
            this.Controls.Add(this.Button_SW);
            this.Controls.Add(this.RichTextBox_RX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_baudRate);
            this.Controls.Add(this.comboBox_portName);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.SerialPortToolMenu;
            this.Name = "SerialPortTool";
            this.Text = "Serial Port Tool";
            this.InfBox_RX_Menu.ResumeLayout(false);
            this.SerialPortToolMenu.ResumeLayout(false);
            this.SerialPortToolMenu.PerformLayout();
            this.InfBox_TX_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_portName;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.RichTextBox RichTextBox_RX;
        private System.Windows.Forms.ImageList Img_SW;
        private System.Windows.Forms.Button Button_SW;
        private System.Windows.Forms.MenuStrip SerialPortToolMenu;
        private System.Windows.Forms.ToolStripMenuItem 帮助;
        private System.Windows.Forms.ToolStripMenuItem 工具;
        private System.Windows.Forms.ToolStripMenuItem 关于;
        private System.Windows.Forms.ImageList Img_Round;
        private System.Windows.Forms.Button LED;
        private System.Windows.Forms.Timer Timer_TXMsg;
        private System.Windows.Forms.RichTextBox RichTextBox_TX;
        private System.Windows.Forms.Button Button_TX;
        private System.Windows.Forms.ContextMenuStrip InfBox_RX_Menu;
        private System.Windows.Forms.ToolStripMenuItem InfBox_RX_Text全选;
        private System.Windows.Forms.ToolStripMenuItem InfBox_RX_Text清除;
        private System.Windows.Forms.ContextMenuStrip InfBox_TX_Menu;
        private System.Windows.Forms.ToolStripMenuItem InfBox_TX_Text全选;
        private System.Windows.Forms.ToolStripMenuItem InfBox_TX_Text清除;
        private System.Windows.Forms.ToolStripMenuItem 文件;
        private System.Windows.Forms.ToolStripMenuItem 保存;
        private System.Windows.Forms.ToolStripMenuItem 退出;
        private System.Windows.Forms.ToolStripMenuItem Tool_SysConvert;
        private System.Windows.Forms.CheckBox CheckBox_CycleTX;
        private System.Windows.Forms.TextBox TextBox_CycleTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Timer_SerialPortMsg;
        private System.Windows.Forms.ToolStripMenuItem Tool_TXD;
    }
}

