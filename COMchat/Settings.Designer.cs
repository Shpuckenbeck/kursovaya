namespace COMchat
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_PortName1 = new System.Windows.Forms.ComboBox();
            this.cb_BaudRate1 = new System.Windows.Forms.ComboBox();
            this.cb_ByteSize1 = new System.Windows.Forms.ComboBox();
            this.cb_Parity1 = new System.Windows.Forms.ComboBox();
            this.cb_StopBits1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.group_Port1 = new System.Windows.Forms.GroupBox();
            this.check_PortEnabled1 = new System.Windows.Forms.CheckBox();
            this.group_Settings = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.group_Port2 = new System.Windows.Forms.GroupBox();
            this.check_PortEnabled2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_StopBits2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_PortName2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_BaudRate2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_ByteSize2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Parity2 = new System.Windows.Forms.ComboBox();
            this.b_OK = new System.Windows.Forms.Button();
            this.b_fastSetup1 = new System.Windows.Forms.Button();
            this.b_fastSetup2 = new System.Windows.Forms.Button();
            this.b_fastSetup3 = new System.Windows.Forms.Button();
            this.group_fastSettings = new System.Windows.Forms.GroupBox();
            this.group_Port1.SuspendLayout();
            this.group_Settings.SuspendLayout();
            this.group_Port2.SuspendLayout();
            this.group_fastSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_PortName1
            // 
            this.cb_PortName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PortName1.FormattingEnabled = true;
            this.cb_PortName1.Location = new System.Drawing.Point(87, 45);
            this.cb_PortName1.Name = "cb_PortName1";
            this.cb_PortName1.Size = new System.Drawing.Size(121, 21);
            this.cb_PortName1.TabIndex = 0;
            // 
            // cb_BaudRate1
            // 
            this.cb_BaudRate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BaudRate1.FormattingEnabled = true;
            this.cb_BaudRate1.Items.AddRange(new object[] {
            "50",
            "75",
            "110",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2000",
            "2400",
            "3600",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cb_BaudRate1.Location = new System.Drawing.Point(87, 72);
            this.cb_BaudRate1.Name = "cb_BaudRate1";
            this.cb_BaudRate1.Size = new System.Drawing.Size(121, 21);
            this.cb_BaudRate1.TabIndex = 0;
            // 
            // cb_ByteSize1
            // 
            this.cb_ByteSize1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ByteSize1.FormattingEnabled = true;
            this.cb_ByteSize1.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cb_ByteSize1.Location = new System.Drawing.Point(87, 99);
            this.cb_ByteSize1.Name = "cb_ByteSize1";
            this.cb_ByteSize1.Size = new System.Drawing.Size(121, 21);
            this.cb_ByteSize1.TabIndex = 0;
            // 
            // cb_Parity1
            // 
            this.cb_Parity1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Parity1.FormattingEnabled = true;
            this.cb_Parity1.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cb_Parity1.Location = new System.Drawing.Point(87, 126);
            this.cb_Parity1.Name = "cb_Parity1";
            this.cb_Parity1.Size = new System.Drawing.Size(121, 21);
            this.cb_Parity1.TabIndex = 0;
            // 
            // cb_StopBits1
            // 
            this.cb_StopBits1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_StopBits1.FormattingEnabled = true;
            this.cb_StopBits1.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.cb_StopBits1.Location = new System.Drawing.Point(87, 153);
            this.cb_StopBits1.Name = "cb_StopBits1";
            this.cb_StopBits1.Size = new System.Drawing.Size(121, 21);
            this.cb_StopBits1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя порта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Четность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Byte Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Стоп Биты";
            // 
            // group_Port1
            // 
            this.group_Port1.Controls.Add(this.check_PortEnabled1);
            this.group_Port1.Controls.Add(this.label3);
            this.group_Port1.Controls.Add(this.label1);
            this.group_Port1.Controls.Add(this.label2);
            this.group_Port1.Controls.Add(this.label4);
            this.group_Port1.Controls.Add(this.label5);
            this.group_Port1.Controls.Add(this.cb_StopBits1);
            this.group_Port1.Controls.Add(this.cb_PortName1);
            this.group_Port1.Controls.Add(this.cb_BaudRate1);
            this.group_Port1.Controls.Add(this.cb_ByteSize1);
            this.group_Port1.Controls.Add(this.cb_Parity1);
            this.group_Port1.Location = new System.Drawing.Point(12, 67);
            this.group_Port1.Name = "group_Port1";
            this.group_Port1.Size = new System.Drawing.Size(223, 195);
            this.group_Port1.TabIndex = 4;
            this.group_Port1.TabStop = false;
            this.group_Port1.Text = "Настойки порта №1";
            // 
            // check_PortEnabled1
            // 
            this.check_PortEnabled1.AutoSize = true;
            this.check_PortEnabled1.Checked = true;
            this.check_PortEnabled1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_PortEnabled1.Location = new System.Drawing.Point(15, 19);
            this.check_PortEnabled1.Name = "check_PortEnabled1";
            this.check_PortEnabled1.Size = new System.Drawing.Size(70, 17);
            this.check_PortEnabled1.TabIndex = 2;
            this.check_PortEnabled1.Text = "Включен";
            this.check_PortEnabled1.UseVisualStyleBackColor = true;
            this.check_PortEnabled1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // group_Settings
            // 
            this.group_Settings.Controls.Add(this.label11);
            this.group_Settings.Controls.Add(this.tb_Name);
            this.group_Settings.Location = new System.Drawing.Point(12, 13);
            this.group_Settings.Name = "group_Settings";
            this.group_Settings.Size = new System.Drawing.Size(223, 48);
            this.group_Settings.TabIndex = 6;
            this.group_Settings.TabStop = false;
            this.group_Settings.Text = "Настройки программы";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ваше имя:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(73, 17);
            this.tb_Name.MaxLength = 16;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(135, 20);
            this.tb_Name.TabIndex = 0;
            // 
            // group_Port2
            // 
            this.group_Port2.Controls.Add(this.check_PortEnabled2);
            this.group_Port2.Controls.Add(this.label10);
            this.group_Port2.Controls.Add(this.cb_StopBits2);
            this.group_Port2.Controls.Add(this.label9);
            this.group_Port2.Controls.Add(this.cb_PortName2);
            this.group_Port2.Controls.Add(this.label8);
            this.group_Port2.Controls.Add(this.cb_BaudRate2);
            this.group_Port2.Controls.Add(this.label7);
            this.group_Port2.Controls.Add(this.cb_ByteSize2);
            this.group_Port2.Controls.Add(this.label6);
            this.group_Port2.Controls.Add(this.cb_Parity2);
            this.group_Port2.Location = new System.Drawing.Point(241, 67);
            this.group_Port2.Name = "group_Port2";
            this.group_Port2.Size = new System.Drawing.Size(223, 193);
            this.group_Port2.TabIndex = 4;
            this.group_Port2.TabStop = false;
            this.group_Port2.Text = "Настойки порта №1";
            // 
            // check_PortEnabled2
            // 
            this.check_PortEnabled2.AutoSize = true;
            this.check_PortEnabled2.Checked = true;
            this.check_PortEnabled2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_PortEnabled2.Location = new System.Drawing.Point(9, 19);
            this.check_PortEnabled2.Name = "check_PortEnabled2";
            this.check_PortEnabled2.Size = new System.Drawing.Size(70, 17);
            this.check_PortEnabled2.TabIndex = 3;
            this.check_PortEnabled2.Text = "Включен";
            this.check_PortEnabled2.UseVisualStyleBackColor = true;
            this.check_PortEnabled2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Четность";
            // 
            // cb_StopBits2
            // 
            this.cb_StopBits2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_StopBits2.FormattingEnabled = true;
            this.cb_StopBits2.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.cb_StopBits2.Location = new System.Drawing.Point(88, 153);
            this.cb_StopBits2.Name = "cb_StopBits2";
            this.cb_StopBits2.Size = new System.Drawing.Size(121, 21);
            this.cb_StopBits2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Имя порта";
            // 
            // cb_PortName2
            // 
            this.cb_PortName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PortName2.FormattingEnabled = true;
            this.cb_PortName2.Location = new System.Drawing.Point(88, 45);
            this.cb_PortName2.Name = "cb_PortName2";
            this.cb_PortName2.Size = new System.Drawing.Size(121, 21);
            this.cb_PortName2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Скорость";
            // 
            // cb_BaudRate2
            // 
            this.cb_BaudRate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BaudRate2.FormattingEnabled = true;
            this.cb_BaudRate2.Items.AddRange(new object[] {
            "50",
            "75",
            "110",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2000",
            "2400",
            "3600",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cb_BaudRate2.Location = new System.Drawing.Point(88, 72);
            this.cb_BaudRate2.Name = "cb_BaudRate2";
            this.cb_BaudRate2.Size = new System.Drawing.Size(121, 21);
            this.cb_BaudRate2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Byte Size";
            // 
            // cb_ByteSize2
            // 
            this.cb_ByteSize2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ByteSize2.FormattingEnabled = true;
            this.cb_ByteSize2.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cb_ByteSize2.Location = new System.Drawing.Point(88, 99);
            this.cb_ByteSize2.Name = "cb_ByteSize2";
            this.cb_ByteSize2.Size = new System.Drawing.Size(121, 21);
            this.cb_ByteSize2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Стоп Биты";
            // 
            // cb_Parity2
            // 
            this.cb_Parity2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Parity2.FormattingEnabled = true;
            this.cb_Parity2.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cb_Parity2.Location = new System.Drawing.Point(88, 126);
            this.cb_Parity2.Name = "cb_Parity2";
            this.cb_Parity2.Size = new System.Drawing.Size(121, 21);
            this.cb_Parity2.TabIndex = 0;
            // 
            // b_OK
            // 
            this.b_OK.Location = new System.Drawing.Point(375, 266);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 23);
            this.b_OK.TabIndex = 7;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // b_fastSetup1
            // 
            this.b_fastSetup1.Location = new System.Drawing.Point(24, 15);
            this.b_fastSetup1.Name = "b_fastSetup1";
            this.b_fastSetup1.Size = new System.Drawing.Size(57, 23);
            this.b_fastSetup1.TabIndex = 2;
            this.b_fastSetup1.Text = "WS1";
            this.b_fastSetup1.UseVisualStyleBackColor = true;
            this.b_fastSetup1.Click += new System.EventHandler(this.b_fastSetup1_Click);
            // 
            // b_fastSetup2
            // 
            this.b_fastSetup2.Location = new System.Drawing.Point(87, 15);
            this.b_fastSetup2.Name = "b_fastSetup2";
            this.b_fastSetup2.Size = new System.Drawing.Size(57, 23);
            this.b_fastSetup2.TabIndex = 3;
            this.b_fastSetup2.Text = "WS2";
            this.b_fastSetup2.UseVisualStyleBackColor = true;
            this.b_fastSetup2.Click += new System.EventHandler(this.b_fastSetup2_Click);
            // 
            // b_fastSetup3
            // 
            this.b_fastSetup3.Location = new System.Drawing.Point(150, 15);
            this.b_fastSetup3.Name = "b_fastSetup3";
            this.b_fastSetup3.Size = new System.Drawing.Size(57, 23);
            this.b_fastSetup3.TabIndex = 4;
            this.b_fastSetup3.Text = "WS3";
            this.b_fastSetup3.UseVisualStyleBackColor = true;
            this.b_fastSetup3.Click += new System.EventHandler(this.b_fastSetup3_Click);
            // 
            // group_fastSettings
            // 
            this.group_fastSettings.Controls.Add(this.b_fastSetup3);
            this.group_fastSettings.Controls.Add(this.b_fastSetup2);
            this.group_fastSettings.Controls.Add(this.b_fastSetup1);
            this.group_fastSettings.Location = new System.Drawing.Point(242, 13);
            this.group_fastSettings.Name = "group_fastSettings";
            this.group_fastSettings.Size = new System.Drawing.Size(222, 48);
            this.group_fastSettings.TabIndex = 8;
            this.group_fastSettings.TabStop = false;
            this.group_fastSettings.Text = "Предустановки";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 301);
            this.Controls.Add(this.group_fastSettings);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.group_Settings);
            this.Controls.Add(this.group_Port2);
            this.Controls.Add(this.group_Port1);
            this.Name = "Settings";
            this.Text = "Настройка параметров порта";
            this.group_Port1.ResumeLayout(false);
            this.group_Port1.PerformLayout();
            this.group_Settings.ResumeLayout(false);
            this.group_Settings.PerformLayout();
            this.group_Port2.ResumeLayout(false);
            this.group_Port2.PerformLayout();
            this.group_fastSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_PortName1;
        private System.Windows.Forms.ComboBox cb_BaudRate1;
        private System.Windows.Forms.ComboBox cb_ByteSize1;
        private System.Windows.Forms.ComboBox cb_Parity1;
        private System.Windows.Forms.ComboBox cb_StopBits1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox group_Port1;
        private System.Windows.Forms.GroupBox group_Settings;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.GroupBox group_Port2;
        private System.Windows.Forms.ComboBox cb_StopBits2;
        private System.Windows.Forms.ComboBox cb_PortName2;
        private System.Windows.Forms.ComboBox cb_BaudRate2;
        private System.Windows.Forms.ComboBox cb_ByteSize2;
        private System.Windows.Forms.ComboBox cb_Parity2;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox check_PortEnabled1;
        private System.Windows.Forms.CheckBox check_PortEnabled2;
        private System.Windows.Forms.Button b_fastSetup3;
        private System.Windows.Forms.Button b_fastSetup2;
        private System.Windows.Forms.Button b_fastSetup1;
        private System.Windows.Forms.GroupBox group_fastSettings;
    }
}