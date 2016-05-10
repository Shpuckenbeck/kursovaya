namespace COMPorts
{
    partial class Login
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
            this.port2 = new System.Windows.Forms.ListBox();
            this.port1 = new System.Windows.Forms.ListBox();
            this.logbut = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.stop2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.speed2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.byte2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.parity2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stop1 = new System.Windows.Forms.ComboBox();
            this.speed1 = new System.Windows.Forms.ComboBox();
            this.byte1 = new System.Windows.Forms.ComboBox();
            this.parity1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // port2
            // 
            this.port2.FormattingEnabled = true;
            this.port2.Location = new System.Drawing.Point(132, 161);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(66, 95);
            this.port2.TabIndex = 88;
            // 
            // port1
            // 
            this.port1.FormattingEnabled = true;
            this.port1.Location = new System.Drawing.Point(132, 51);
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(66, 95);
            this.port1.TabIndex = 87;
            // 
            // logbut
            // 
            this.logbut.Location = new System.Drawing.Point(697, 257);
            this.logbut.Name = "logbut";
            this.logbut.Size = new System.Drawing.Size(75, 23);
            this.logbut.TabIndex = 86;
            this.logbut.Text = "Вход";
            this.logbut.UseVisualStyleBackColor = true;
            this.logbut.Click += new System.EventHandler(this.logbut_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 85;
            this.label13.Text = "Порт2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "Четность";
            // 
            // stop2
            // 
            this.stop2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stop2.FormattingEnabled = true;
            this.stop2.Items.AddRange(new object[] {
            "One",
            "OnePointFive",
            "Two"});
            this.stop2.Location = new System.Drawing.Point(730, 158);
            this.stop2.Name = "stop2";
            this.stop2.Size = new System.Drawing.Size(56, 21);
            this.stop2.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 81;
            this.label9.Text = "Имя порта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Скорость";
            // 
            // speed2
            // 
            this.speed2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speed2.FormattingEnabled = true;
            this.speed2.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.speed2.Location = new System.Drawing.Point(281, 158);
            this.speed2.Name = "speed2";
            this.speed2.Size = new System.Drawing.Size(56, 21);
            this.speed2.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Биты данных";
            // 
            // byte2
            // 
            this.byte2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byte2.FormattingEnabled = true;
            this.byte2.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.byte2.Location = new System.Drawing.Point(437, 158);
            this.byte2.Name = "byte2";
            this.byte2.Size = new System.Drawing.Size(56, 21);
            this.byte2.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Стоп-байт";
            // 
            // parity2
            // 
            this.parity2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parity2.FormattingEnabled = true;
            this.parity2.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.parity2.Location = new System.Drawing.Point(582, 158);
            this.parity2.Name = "parity2";
            this.parity2.Size = new System.Drawing.Size(56, 21);
            this.parity2.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Порт1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Четность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Имя порта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Скорость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Биты данных";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Стоп-байт";
            // 
            // stop1
            // 
            this.stop1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stop1.FormattingEnabled = true;
            this.stop1.Items.AddRange(new object[] {
            "One",
            "OnePointFive",
            "Two"});
            this.stop1.Location = new System.Drawing.Point(729, 51);
            this.stop1.Name = "stop1";
            this.stop1.Size = new System.Drawing.Size(57, 21);
            this.stop1.TabIndex = 66;
            // 
            // speed1
            // 
            this.speed1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speed1.FormattingEnabled = true;
            this.speed1.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.speed1.Location = new System.Drawing.Point(281, 51);
            this.speed1.Name = "speed1";
            this.speed1.Size = new System.Drawing.Size(57, 21);
            this.speed1.TabIndex = 67;
            // 
            // byte1
            // 
            this.byte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byte1.FormattingEnabled = true;
            this.byte1.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.byte1.Location = new System.Drawing.Point(434, 51);
            this.byte1.Name = "byte1";
            this.byte1.Size = new System.Drawing.Size(57, 21);
            this.byte1.TabIndex = 68;
            // 
            // parity1
            // 
            this.parity1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parity1.FormattingEnabled = true;
            this.parity1.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.parity1.Location = new System.Drawing.Point(582, 51);
            this.parity1.Name = "parity1";
            this.parity1.Size = new System.Drawing.Size(57, 21);
            this.parity1.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Логин";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(138, 13);
            this.namebox.MaxLength = 16;
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(135, 20);
            this.namebox.TabIndex = 64;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 284);
            this.Controls.Add(this.port2);
            this.Controls.Add(this.port1);
            this.Controls.Add(this.logbut);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stop2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.speed2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.byte2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.parity2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stop1);
            this.Controls.Add(this.speed1);
            this.Controls.Add(this.byte1);
            this.Controls.Add(this.parity1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.namebox);
            this.Name = "Login";
            this.Text = "Начало";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox port2;
        private System.Windows.Forms.ListBox port1;
        private System.Windows.Forms.Button logbut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox stop2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox speed2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox byte2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox parity2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox stop1;
        private System.Windows.Forms.ComboBox speed1;
        private System.Windows.Forms.ComboBox byte1;
        private System.Windows.Forms.ComboBox parity1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox namebox;

    }
}