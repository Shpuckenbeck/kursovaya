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
using System.IO;

namespace COMPorts
{
    public partial class Messaging : Form
    {
        static private WorkingUnit _com1 = new WorkingUnit();
        /// <summary>
        /// Управление первым портом
        /// </summary>
        static public WorkingUnit Com1
        {
            get
            {
                return _com1;
            }
            set
            {
                _com1 = value;
            }
        }
        static private WorkingUnit _com2 = new WorkingUnit();
        /// <summary>
        /// Управление вторым портом
        /// </summary>
        static public WorkingUnit Com2
        {
            get
            {
                return _com2;
            }
            set
            {
                _com2 = value;
            }
        }

        Timer _linkActiveTimer = new Timer();
        /// <summary>
        /// Идентификатор получателя
        /// </summary>
        private static byte _reciever = 0;
        private static byte _user1ID = 255;
        public static byte User1ID
        {
            get
            {
                return _user1ID;
            }
            set
            {
                _user1ID = value;
            }
        }
        private static byte _user2ID = 255;
        public static byte User2ID
        {
            get
            {
                return _user2ID;
            }
            set
            {
                _user2ID = value;
            }
        }
        /// <summary>
        /// Конструктор формы
        /// </summary>
        Timer t_upLinkIsTrue = new Timer();
        Timer t_DownLinkIsTrue = new Timer();

        Timer t_upLinkFromCommManager_port1 = new Timer();///
        Timer t_upLinkFromCommManager_port2 = new Timer();///
        Timer t_ActiveLinkFromCommManager_port1 = new Timer();///
        Timer t_ActiveLinkFromCommManager_port2 = new Timer();///
        int c_upLinkIsTrueTry = 20;
        int c_DownLinkIsTrueTry = 20;
        public Messaging(Login login, string name, string port1, string speed1, string bytes1, string parity1, string stop1, string port2, string speed2, string bytes2, string parity2, string stop2)
        {
            _com1 = new WorkingUnit(name, port1, speed1, bytes1, parity1, stop1);
            _com2 = new WorkingUnit(name, port2, speed2, bytes2, parity2, stop2);


            InitializeComponent();
            t_upLinkIsTrue.Tick += new EventHandler(upLinkIsTrueTick);
            t_DownLinkIsTrue.Tick += new EventHandler(DownLinkIsTrueTick);
            
            
            _com1.InitializeHandlers();
            _com2.InitializeHandlers();
            _linkActiveTimer.Tick += new EventHandler(LinkActiveTimerTick);
            _com1.MainForm = this;
            _com2.MainForm = this;
            _com1.Display = richTextBox1;
            _com2.Display = richTextBox1;
            _com1.RadioButton1 = rb_User1;
            _com1.RadioButton2 = rb_User2;
            _com2.RadioButton1 = rb_User1;
            _com2.RadioButton2 = rb_User2;

            t_upLinkFromCommManager_port1 = _com1.T_UpLink;
            t_upLinkFromCommManager_port2 = _com2.T_UpLink;
            t_ActiveLinkFromCommManager_port1 = _com1.T_ActiveLink;
            t_ActiveLinkFromCommManager_port2 = _com2.T_ActiveLink;

            _com1.b_UpLink = b_Uplink;
            _com2.b_UpLink = b_Uplink;
            _com1.b_DownLink = b_Downlink;
            _com2.b_DownLink = b_Downlink;
            _com1.b_SendMessage = b_SendMsg;
            _com2.b_SendMessage = b_SendMsg;
            _com1.tb_CurrentMsg = tb_CurrentMessage;
            _com2.tb_CurrentMsg = tb_CurrentMessage;


            //_com1.Log = richTextBox2;
           // _com2.Log = richTextBox2;

            t_upLinkIsTrue.Interval = 500;
            t_DownLinkIsTrue.Interval = 500;
        }

        private void DownLinkIsTrueTick(object sender, EventArgs e)
        {
            if (c_DownLinkIsTrueTry > 0)
            {
                if (!_com1.Link.IsActive && !_com2.Link.IsActive)
                {
                    b_SendMsg.Enabled = false;
                    tb_CurrentMessage.Enabled = false;
                    b_Uplink.Enabled = true;
                    b_Downlink.Enabled = false;

                    c_DownLinkIsTrueTry = 20;

                    t_upLinkFromCommManager_port1.Stop();
                    t_upLinkFromCommManager_port2.Stop();
                    t_ActiveLinkFromCommManager_port1.Stop();
                    t_ActiveLinkFromCommManager_port2.Stop();
                    t_DownLinkIsTrue.Stop();
                }
                else c_DownLinkIsTrueTry--;
            }
            else
            {
                b_Uplink.Enabled = false;
                b_Downlink.Enabled = true;
                c_DownLinkIsTrueTry = 20;
                t_DownLinkIsTrue.Stop();
            }
        }

        private void upLinkIsTrueTick(object sender, EventArgs e)
        {
            if (c_upLinkIsTrueTry > 0)
            {

                if (_com1.Link.IsActive || _com2.Link.IsActive)
                {
                    b_SendMsg.Enabled = true;
                    tb_CurrentMessage.Enabled = true;
                    b_Uplink.Enabled = true;
                    c_upLinkIsTrueTry = 20;
                    t_upLinkIsTrue.Stop();
                }
                if (_com1.Link.IsActive && _com2.Link.IsActive) b_Uplink.Enabled = false;
                else c_upLinkIsTrueTry--;
            }
            else
            {
                b_Uplink.Enabled = false;
                b_Downlink.Enabled = false;
                c_upLinkIsTrueTry = 20;
                t_upLinkIsTrue.Stop();
            }
        }


        private void LinkActiveTimerTick(object sender, EventArgs e)
        {
            if (_com1.Port.IsOpen)
            {
                _com1.WriteData(null, _com1.Link.ID, WorkingUnit.FrameType.LINKACTIVE, WorkingUnit.UserID);
            }
            if (_com2.Port.IsOpen)
            {
                _com2.WriteData(null, _com2.Link.ID, WorkingUnit.FrameType.LINKACTIVE, WorkingUnit.UserID);
            }
        }
        
        private void b_OpenPorts_Click(object sender, EventArgs e)
        {
            
            if (_com1.IsEnabled)
            {
                if (!_com1.Port.IsOpen && _com1.IsEnabled)
                    try
                    {
                        _com1.Port.Open();
                        _com1.Port.DtrEnable = true;
                        _com1.Port.RtsEnable = true;
                        _com1.Display.AppendText(_com1.Port.PortName + " успешно открыт \n");
                        _com1.Display.ScrollToCaret();
                        b_OpenPorts.Enabled = false;
                        b_ClosePorts.Enabled = true;
                        b_Uplink.Enabled = true;
                    }
                    catch (UnauthorizedAccessException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                else
                    MessageBox.Show("Порт 1 уже открыт");
            }
            if (_com2.IsEnabled)
            {
                if (!_com2.Port.IsOpen)
                {
                    if (_com1.Port.PortName == _com2.Port.PortName)
                    {
                        _com2.Port.PortName = "COM2";
                    }
                    try
                    {
                        _com2.Port.Open();
                        _com2.Port.DtrEnable = true;
                        _com2.Port.RtsEnable = true;
                        _com2.Display.AppendText(_com2.Port.PortName + "успешно открыт \n");
                        _com2.Display.ScrollToCaret();
                        b_OpenPorts.Enabled = false;
                        b_ClosePorts.Enabled = true;
                        b_Uplink.Enabled = true;
                    }
                    catch (UnauthorizedAccessException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                    MessageBox.Show("Порт 2 уже открыт");
            }
        }
        private void b_SendMsg_Click(object sender, EventArgs e)
        {
            if (tb_CurrentMessage.Text != "")
            {
                richTextBox1.AppendText("[" + DateTime.Now + "] Вы: " + tb_CurrentMessage.Text + "\n");
                richTextBox1.ScrollToCaret();
                if (_reciever != 0)
                {
                    if (_com1.Link.ID == _reciever)
                        _com1.WriteData(tb_CurrentMessage.Text, _reciever, WorkingUnit.FrameType.MSG, WorkingUnit.UserID);
                    if (_com2.Link.ID == _reciever)
                        _com2.WriteData(tb_CurrentMessage.Text, _reciever, WorkingUnit.FrameType.MSG, WorkingUnit.UserID);
                }
                else
                {
                    _com1.WriteData(tb_CurrentMessage.Text, _reciever, WorkingUnit.FrameType.MSG, WorkingUnit.UserID);
                    _com2.WriteData(tb_CurrentMessage.Text, _reciever, WorkingUnit.FrameType.MSG, WorkingUnit.UserID);
                }
                tb_CurrentMessage.ResetText();
            }
        }
        private void b_Uplink_Click(object sender, EventArgs e)
        {
            b_Uplink.Enabled = false;
            b_Downlink.Enabled = true;
            t_upLinkIsTrue.Start();
            this.Text = "Чат: " + WorkingUnit.UserName;
            _com1.WriteData(null, 0, WorkingUnit.FrameType.UPLINK, WorkingUnit.UserID);
            _com2.WriteData(null, 0, WorkingUnit.FrameType.UPLINK, WorkingUnit.UserID);
            t_upLinkIsTrue.Start();
            //_linkActiveTimer.Start();
        }

       

        private void rb_User1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_User1.Checked)
            {
                b_SendMsg.Text = "Отправить\n" + rb_User1.Text;
                //if (_com1.Link.ID == _user1ID)
                //{
                //    _reciever = _com1.Link.ID;
                //}
                //if (_com2.Link.ID == _user2ID)
                //{
                //    _reciever = _com2.Link.ID;
                //}
                _reciever = _user1ID;
            }
        }

        private void rb_User2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_User2.Checked)
            {
                b_SendMsg.Text = "Отправить " + rb_User2.Text;
                //if (_com1.Link.Name == rb_User2.Text)
                //{
                //    _reciever = _com1.Link.ID;
                //}
                //if (_com2.Link.Name == rb_User2.Text)
                //{
                //    _reciever = _com2.Link.ID;
                //}
                _reciever = _user2ID;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //richTextBox2.ResetText();
        }

        

        private void b_Downlink_Click(object sender, EventArgs e)
        {
            if (t_upLinkFromCommManager_port1.Enabled && t_upLinkFromCommManager_port2.Enabled)
            {
                t_upLinkIsTrue.Stop();
                t_upLinkFromCommManager_port1.Stop();
                t_upLinkFromCommManager_port2.Stop();
                t_ActiveLinkFromCommManager_port1.Stop();
                t_ActiveLinkFromCommManager_port2.Stop();

                c_upLinkIsTrueTry = 20;
                b_Downlink.Enabled = false;
                b_Uplink.Enabled = true;
            }
            else
            {
                t_DownLinkIsTrue.Start();
                this.Text = "Чат: " + WorkingUnit.UserName;
                _com1.WriteData(null, 0, WorkingUnit.FrameType.DOWNLINK, WorkingUnit.UserID);
                _com2.WriteData(null, 0, WorkingUnit.FrameType.DOWNLINK, WorkingUnit.UserID);
            }
            /*b_SendMsg.Enabled = false;
              tb_CurrentMessage.Enabled = false;
              b_Downlink.Enabled = false;
              b_Uplink.Enabled = true;
              button2.Enabled = false;*/
        }

        private void b_ClosePorts_Click(object sender, EventArgs e)
        {
            if (_com1.Port.IsOpen && _com1.IsEnabled)
            {
                _com1.Port.Close();
            }
            if (_com2.Port.IsOpen && _com2.IsEnabled)
            {
                _com2.Port.Close();
            }
            /* b_Settings.Enabled = true;
             b_OpenPorts.Enabled = true;
             b_Uplink.Enabled = false;*/
        }

        private void b_fastSetup1_Click(object sender, EventArgs e)
        {
            Com1.IsEnabled = true;
            Com2.IsEnabled = true;
            string msg = String.Empty; //Сообщение для вывода в конце
            #region WritingPortSettings
            if (Com1.Port.IsOpen) 
            { 
                Com1.Port.Close(); 
                msg += "Порт №1 закрыт, параметры перезаписаны!\n"; 
            }
            if (Messaging.Com1.IsEnabled)
            {
                Messaging.Com1.Port.PortName = "COM8";
                Messaging.Com1.Port.BaudRate = 9600;
                Messaging.Com1.Port.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                Messaging.Com1.Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                Messaging.Com1.Port.DataBits = 8;
                Messaging.Com1.Port.WriteBufferSize = 100000000;
                Messaging.Com1.Port.ReadBufferSize = 100000000;
            }

            if (Messaging.Com2.Port.IsOpen) { Messaging.Com2.Port.Close(); msg += "Порт №2 закрыт, параметры перезаписаны!\n"; }
            if (Messaging.Com2.IsEnabled)
            {
                Messaging.Com2.Port.PortName = "COM2";
                Messaging.Com2.Port.BaudRate = 9600;
                Messaging.Com2.Port.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                Messaging.Com2.Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                Messaging.Com2.Port.DataBits = 8;
                Messaging.Com2.Port.WriteBufferSize = 100000000;
                Messaging.Com2.Port.ReadBufferSize = 100000000;
            }

            WorkingUnit.UserName = "WS1";
            #endregion
            if (msg == String.Empty) msg = "Параметры записаны!";
            MessageBox.Show(msg, "Завершено");
            
        }

        private void b_fastSetup2_Click(object sender, EventArgs e)
        {
            Com1.IsEnabled = true;
            Com2.IsEnabled = true;
            
            string msg = String.Empty; //Сообщение для вывода в конце
            #region WritingPortSettings
            if (Messaging.Com1.Port.IsOpen) { Messaging.Com1.Port.Close(); msg += "Порт №1 закрыт, параметры перезаписаны!\n"; }
            if (Messaging.Com1.IsEnabled)
            {
                Messaging.Com1.Port.PortName = "COM4";
                Messaging.Com1.Port.BaudRate = 9600;
                Messaging.Com1.Port.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                Messaging.Com1.Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                Messaging.Com1.Port.DataBits = 8;
                Messaging.Com1.Port.WriteBufferSize = 100000000;
                Messaging.Com1.Port.ReadBufferSize = 100000000;
            }

            if (Messaging.Com2.Port.IsOpen) { Messaging.Com2.Port.Close(); msg += "Порт №2 закрыт, параметры перезаписаны!\n"; }
            if (Messaging.Com2.IsEnabled)
            {
                Messaging.Com2.Port.PortName = "COM5";
                Messaging.Com2.Port.BaudRate = 9600;
                Messaging.Com2.Port.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                Messaging.Com2.Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                Messaging.Com2.Port.DataBits = 8;
                Messaging.Com2.Port.WriteBufferSize = 100000000;
                Messaging.Com2.Port.ReadBufferSize = 100000000;
            }

            WorkingUnit.UserName = "WS2";
            #endregion
            if (msg == String.Empty) msg = "Параметры записаны!";
            MessageBox.Show(msg, "Завершено");
            
        }

        private void b_fastSetup3_Click(object sender, EventArgs e)
        {
            Com1.IsEnabled = true;
            Com2.IsEnabled = true;
            
            string msg = String.Empty; //Сообщение для вывода в конце
            #region WritingPortSettings
            if (Messaging.Com1.Port.IsOpen) { Messaging.Com1.Port.Close(); msg += "Порт №1 закрыт, параметры перезаписаны!\n"; }
            if (Messaging.Com1.IsEnabled)
            {
                Messaging.Com1.Port.PortName = "COM6";
                Messaging.Com1.Port.BaudRate = 9600;
                Messaging.Com1.Port.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                Messaging.Com1.Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                Messaging.Com1.Port.DataBits = 8;
                Messaging.Com1.Port.WriteBufferSize = 100000000;
                Messaging.Com1.Port.ReadBufferSize = 100000000;
            }

            if (Messaging.Com2.Port.IsOpen) { Messaging.Com2.Port.Close(); msg += "Порт №2 закрыт, параметры перезаписаны!\n"; }
            if (Messaging.Com2.IsEnabled)
            {
                Messaging.Com2.Port.PortName = "COM7";
                Messaging.Com2.Port.BaudRate = 9600;
                Messaging.Com2.Port.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                Messaging.Com2.Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                Messaging.Com2.Port.DataBits = 8;
                Messaging.Com2.Port.WriteBufferSize = 100000000;
                Messaging.Com2.Port.ReadBufferSize = 100000000;
            }

            WorkingUnit.UserName = "WS3";
            #endregion
            if (msg == String.Empty) msg = "Параметры записаны!";
            MessageBox.Show(msg, "Завершено");

        }

        private void l_UserID_Click(object sender, EventArgs e)
        {

        }


    }
}

