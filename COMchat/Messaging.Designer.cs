namespace COMPorts
{
    partial class Messaging
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_User1 = new System.Windows.Forms.RadioButton();
            this.rb_User2 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.b_OpenPorts = new System.Windows.Forms.Button();
            this.b_Uplink = new System.Windows.Forms.Button();
            this.tb_CurrentMessage = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.b_Downlink = new System.Windows.Forms.Button();
            this.b_ClosePorts = new System.Windows.Forms.Button();
            this.b_SendMsg = new System.Windows.Forms.Button();
            this.b_fastSetup1 = new System.Windows.Forms.Button();
            this.b_fastSetup2 = new System.Windows.Forms.Button();
            this.b_fastSetup3 = new System.Windows.Forms.Button();
            this.group_fastSettings = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group_fastSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_User1
            // 
            this.rb_User1.AutoSize = true;
            this.rb_User1.Location = new System.Drawing.Point(6, 19);
            this.rb_User1.Name = "rb_User1";
            this.rb_User1.Size = new System.Drawing.Size(53, 17);
            this.rb_User1.TabIndex = 1;
            this.rb_User1.Text = "User1";
            this.rb_User1.UseVisualStyleBackColor = true;
            this.rb_User1.Visible = false;
            this.rb_User1.CheckedChanged += new System.EventHandler(this.rb_User1_CheckedChanged);
            // 
            // rb_User2
            // 
            this.rb_User2.AutoSize = true;
            this.rb_User2.Location = new System.Drawing.Point(6, 42);
            this.rb_User2.Name = "rb_User2";
            this.rb_User2.Size = new System.Drawing.Size(53, 17);
            this.rb_User2.TabIndex = 1;
            this.rb_User2.TabStop = true;
            this.rb_User2.Text = "User2";
            this.rb_User2.UseVisualStyleBackColor = true;
            this.rb_User2.Visible = false;
            this.rb_User2.CheckedChanged += new System.EventHandler(this.rb_User2_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 209);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // b_OpenPorts
            // 
            this.b_OpenPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_OpenPorts.Location = new System.Drawing.Point(6, 271);
            this.b_OpenPorts.Name = "b_OpenPorts";
            this.b_OpenPorts.Size = new System.Drawing.Size(74, 22);
            this.b_OpenPorts.TabIndex = 5;
            this.b_OpenPorts.Text = "Открыть";
            this.b_OpenPorts.UseVisualStyleBackColor = true;
            this.b_OpenPorts.Click += new System.EventHandler(this.b_OpenPorts_Click);
            // 
            // b_Uplink
            // 
            this.b_Uplink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Uplink.Enabled = false;
            this.b_Uplink.Location = new System.Drawing.Point(98, 271);
            this.b_Uplink.Name = "b_Uplink";
            this.b_Uplink.Size = new System.Drawing.Size(92, 22);
            this.b_Uplink.TabIndex = 6;
            this.b_Uplink.Text = "Подключиться";
            this.b_Uplink.UseVisualStyleBackColor = true;
            this.b_Uplink.Click += new System.EventHandler(this.b_Uplink_Click);
            // 
            // tb_CurrentMessage
            // 
            this.tb_CurrentMessage.Enabled = false;
            this.tb_CurrentMessage.Location = new System.Drawing.Point(6, 230);
            this.tb_CurrentMessage.Name = "tb_CurrentMessage";
            this.tb_CurrentMessage.Size = new System.Drawing.Size(513, 20);
            this.tb_CurrentMessage.TabIndex = 7;
            // 
            // b_Downlink
            // 
            this.b_Downlink.Enabled = false;
            this.b_Downlink.Location = new System.Drawing.Point(296, 271);
            this.b_Downlink.Name = "b_Downlink";
            this.b_Downlink.Size = new System.Drawing.Size(84, 22);
            this.b_Downlink.TabIndex = 14;
            this.b_Downlink.Text = "Отключиться";
            this.b_Downlink.UseVisualStyleBackColor = true;
            this.b_Downlink.Click += new System.EventHandler(this.b_Downlink_Click);
            // 
            // b_ClosePorts
            // 
            this.b_ClosePorts.Enabled = false;
            this.b_ClosePorts.Location = new System.Drawing.Point(206, 271);
            this.b_ClosePorts.Name = "b_ClosePorts";
            this.b_ClosePorts.Size = new System.Drawing.Size(74, 22);
            this.b_ClosePorts.TabIndex = 15;
            this.b_ClosePorts.Text = "Закрыть ";
            this.b_ClosePorts.UseVisualStyleBackColor = true;
            this.b_ClosePorts.Click += new System.EventHandler(this.b_ClosePorts_Click);
            // 
            // b_SendMsg
            // 
            this.b_SendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_SendMsg.Enabled = false;
            this.b_SendMsg.Location = new System.Drawing.Point(397, 271);
            this.b_SendMsg.Name = "b_SendMsg";
            this.b_SendMsg.Size = new System.Drawing.Size(74, 22);
            this.b_SendMsg.TabIndex = 13;
            this.b_SendMsg.Text = "Отправить сообщение";
            this.b_SendMsg.UseVisualStyleBackColor = true;
            this.b_SendMsg.Click += new System.EventHandler(this.b_SendMsg_Click);
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
            this.b_fastSetup2.Location = new System.Drawing.Point(24, 44);
            this.b_fastSetup2.Name = "b_fastSetup2";
            this.b_fastSetup2.Size = new System.Drawing.Size(57, 23);
            this.b_fastSetup2.TabIndex = 3;
            this.b_fastSetup2.Text = "WS2";
            this.b_fastSetup2.UseVisualStyleBackColor = true;
            this.b_fastSetup2.Click += new System.EventHandler(this.b_fastSetup2_Click);
            // 
            // b_fastSetup3
            // 
            this.b_fastSetup3.Location = new System.Drawing.Point(24, 73);
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
            this.group_fastSettings.Location = new System.Drawing.Point(540, 179);
            this.group_fastSettings.Name = "group_fastSettings";
            this.group_fastSettings.Size = new System.Drawing.Size(111, 101);
            this.group_fastSettings.TabIndex = 17;
            this.group_fastSettings.TabStop = false;
            this.group_fastSettings.Text = "Предустановки";
            this.group_fastSettings.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb_User1);
            this.groupBox1.Controls.Add(this.rb_User2);
            this.groupBox1.Location = new System.Drawing.Point(525, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(81, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Получатель";
            // 
            // Messaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 303);
            this.Controls.Add(this.group_fastSettings);
            this.Controls.Add(this.b_ClosePorts);
            this.Controls.Add(this.b_Downlink);
            this.Controls.Add(this.tb_CurrentMessage);
            this.Controls.Add(this.b_SendMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_Uplink);
            this.Controls.Add(this.b_OpenPorts);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Messaging";
            this.Text = "Чат";
            this.group_fastSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_User1;
        private System.Windows.Forms.RadioButton rb_User2;
        private System.Windows.Forms.Button b_OpenPorts;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button b_Uplink;
        private System.Windows.Forms.TextBox tb_CurrentMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button b_Downlink;
        private System.Windows.Forms.Button b_ClosePorts;
        private System.Windows.Forms.Button b_SendMsg;
        private System.Windows.Forms.Button b_fastSetup1;
        private System.Windows.Forms.Button b_fastSetup2;
        private System.Windows.Forms.Button b_fastSetup3;
        private System.Windows.Forms.GroupBox group_fastSettings;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

