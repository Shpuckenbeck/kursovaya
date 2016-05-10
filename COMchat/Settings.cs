using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace COMchat
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            #region ControlsValueSet
            tb_Name.Text = CommManager.UserName;

            cb_PortName1.Items.AddRange(SerialPort.GetPortNames());
            cb_PortName2.Items.AddRange(SerialPort.GetPortNames());
            //Запонение списков автоматически!
            check_PortEnabled1.Checked=Form1.Com1.IsEnabled;
            cb_PortName1.SelectedItem = Form1.Com1.Port.PortName.ToString();
            cb_Parity1.SelectedItem = Form1.Com1.Port.Parity.ToString();
            cb_ByteSize1.SelectedItem = Form1.Com1.Port.DataBits.ToString();
            cb_BaudRate1.SelectedItem = Form1.Com1.Port.BaudRate.ToString();
            cb_StopBits1.SelectedItem = Form1.Com1.Port.StopBits.ToString();

            if (Form1.Com2.Port.IsOpen)
            {
                cb_PortName2.SelectedItem = Form1.Com2.Port.PortName.ToString();
            }
            else
            {
                cb_PortName2.SelectedItem = "COM2";
            }
            check_PortEnabled2.Checked = Form1.Com2.IsEnabled;
            cb_Parity2.SelectedItem = Form1.Com2.Port.Parity.ToString();
            cb_ByteSize2.SelectedItem = Form1.Com2.Port.DataBits.ToString();
            cb_BaudRate2.SelectedItem = Form1.Com2.Port.BaudRate.ToString();
            cb_StopBits2.SelectedItem = Form1.Com2.Port.StopBits.ToString();
            #endregion
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            string msg = String.Empty; //Сообщение для вывода в конце
            #region WritingPortSettings
            if (Form1.Com1.Port.IsOpen) { Form1.Com1.Port.Close(); msg += "Порт №1 закрыт, параметры перезаписаны!\n"; }
            if (Form1.Com1.IsEnabled)
            {
                Form1.Com1.Port.PortName = cb_PortName1.Text;
                Form1.Com1.Port.BaudRate = int.Parse(cb_BaudRate1.Text);
                Form1.Com1.Port.Parity = ( Parity )Enum.Parse(typeof(Parity), cb_Parity1.Text);
                Form1.Com1.Port.StopBits = ( StopBits )Enum.Parse(typeof(StopBits), cb_StopBits1.Text);
                Form1.Com1.Port.DataBits = int.Parse(cb_ByteSize1.Text);
                Form1.Com1.Port.WriteBufferSize = 100000000;
                Form1.Com1.Port.ReadBufferSize = 100000000;
            }

            if (Form1.Com2.Port.IsOpen) { Form1.Com2.Port.Close(); msg += "Порт №2 закрыт, параметры перезаписаны!\n"; }
            if (Form1.Com2.IsEnabled)
            {
                Form1.Com2.Port.PortName = cb_PortName2.Text;
                Form1.Com2.Port.BaudRate = int.Parse(cb_BaudRate2.Text);
                Form1.Com2.Port.Parity = ( Parity )Enum.Parse(typeof(Parity), cb_Parity2.Text);
                Form1.Com2.Port.StopBits = ( StopBits )Enum.Parse(typeof(StopBits), cb_StopBits2.Text);
                Form1.Com2.Port.DataBits = int.Parse(cb_ByteSize2.Text);
                Form1.Com2.Port.WriteBufferSize = 100000000;
                Form1.Com2.Port.ReadBufferSize = 100000000;
            }

            CommManager.UserName = tb_Name.Text;
            #endregion

            if (cb_PortName1.Text == cb_PortName2.Text) //Нельзя открыть два порта с одним именем
            {
                MessageBox.Show("Имена портов должны быть разными.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tb_Name.Text == String.Empty) //Нельзя оставлять имя пустым
            {
                MessageBox.Show("Вы не ввели имя.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (msg == String.Empty) msg = "Параметры записаны!";
            MessageBox.Show(msg, "Завершено");
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_PortEnabled1.Checked)
            {
                Form1.Com1.IsEnabled = true;
                cb_PortName1.Enabled = true;
                cb_Parity1.Enabled = true;
                cb_ByteSize1.Enabled = true;
                cb_BaudRate1.Enabled = true;
                cb_StopBits1.Enabled = true;
            }
            else
            {
                Form1.Com1.IsEnabled = false;
                cb_PortName1.Enabled = false;
                cb_Parity1.Enabled = false;
                cb_ByteSize1.Enabled = false;
                cb_BaudRate1.Enabled = false;
                cb_StopBits1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_PortEnabled2.Checked)
            {
                Form1.Com2.IsEnabled = true;
                cb_PortName2.Enabled = true;
                cb_Parity2.Enabled = true;
                cb_ByteSize2.Enabled = true;
                cb_BaudRate2.Enabled = true;
                cb_StopBits2.Enabled = true;
            }
            else
            {
                Form1.Com2.IsEnabled = false;
                cb_PortName2.Enabled = false;
                cb_Parity2.Enabled = false;
                cb_ByteSize2.Enabled = false;
                cb_BaudRate2.Enabled = false;
                cb_StopBits2.Enabled = false;
            }
        }

        private void b_fastSetup1_Click(object sender, EventArgs e)
        {
            check_PortEnabled1.Checked=true;
            check_PortEnabled2.Checked=true;
            cb_PortName1.SelectedItem="COM2";
            cb_PortName2.SelectedItem = "COM5";
            tb_Name.Text="WS1";
        }

        private void b_fastSetup2_Click(object sender, EventArgs e)
        {
            check_PortEnabled1.Checked = true;
            check_PortEnabled2.Checked = true;
            cb_PortName1.SelectedItem = "COM6";
            cb_PortName2.SelectedItem = "COM4";
            tb_Name.Text = "WS2";
        }

        private void b_fastSetup3_Click(object sender, EventArgs e)
        {
            check_PortEnabled1.Checked = true;
            check_PortEnabled2.Checked = true;
            cb_PortName1.SelectedItem = "COM1";
            cb_PortName2.SelectedItem = "COM3";
            tb_Name.Text = "WS3";
        }
    }
}
