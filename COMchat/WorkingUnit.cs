using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace COMPorts
{

    public class ReceivedMessageEventArgs : EventArgs
    {
        public string _text { get; set; }
        public ReceivedMessageEventArgs(string text)
        {
            _text = text;
        }
    }

    public class WorkingUnit
    {
        public EventHandler ReceivedMessageEvent;
        public WorkingUnit()
        { }

        public WorkingUnit(string name, string port, string speed, string bytes, string parity, string stop)
        {
            UserName = name;
            Port.PortName = port;
            Port.BaudRate = int.Parse(speed);
            Port.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
            Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stop);
            Port.DataBits = int.Parse(bytes);
            Port.WriteBufferSize = 100000000;
            Port.ReadBufferSize = 100000000;
            IsEnabled = true;
        }
        /// <summary>
        /// Объявление Таймеров и счетчиков попыток
        /// </summary>
        System.Windows.Forms.Timer t_UpLink = new System.Windows.Forms.Timer();

        public System.Windows.Forms.Timer T_UpLink
        {
            get { return t_UpLink; }
            set { t_UpLink = value; }
        }
        System.Windows.Forms.Timer t_ActiveLink = new System.Windows.Forms.Timer();

        public System.Windows.Forms.Timer T_ActiveLink
        {
            get { return t_ActiveLink; }
            set { t_ActiveLink = value; }
        }
        System.Windows.Forms.Timer t_DownLink = new System.Windows.Forms.Timer();
        private int c_upLinkTry = 3;
        private int c_linkActiveTry = 3;
        private int c_linkDownTry = 3;


        private Form _mainForm;
        public Form MainForm
        {
            get
            {
                return _mainForm;
            }
            set
            {
                _mainForm = value;
            }
        }
        /// <summary>
        /// Окно вывода логов
        /// </summary>
        private RichTextBox _Log;
        /// <summary>
        /// Окно вывода логов
        /// </summary>
        public RichTextBox Log
        {
            get
            {
                return _Log;
            }
            set
            {
                _Log = value;
            }
        }
        /// <summary>
        /// Окно вывода сообщений
        /// </summary>
        private RichTextBox _Display;
        /// <summary>
        /// Окно вывода сообщений
        /// </summary>
        public RichTextBox Display
        {
            get
            {
                return _Display;
            }
            set
            {
                _Display = value;
            }
        }

        /// <summary>
        /// Кнопки выбора получателей
        /// </summary>
        private RadioButton _RadioButton1;
        /// <summary>
        /// Кнопки выбора получателей
        /// </summary>
        public RadioButton RadioButton1
        {
            get
            {
                return _RadioButton1;
            }
            set
            {
                _RadioButton1 = value;
            }
        }


        /// <summary>
        /// Кнопки выбора получателей
        /// </summary>
        private RadioButton _RadioButton2;
        /// <summary>
        /// Кнопки выбора получателей
        /// </summary>
        public RadioButton RadioButton2
        {
            get
            {
                return _RadioButton2;
            }
            set
            {
                _RadioButton2 = value;
            }
        }
        /// <summary>
        /// Стартовый байт
        /// </summary>
        public const byte STARTBYTE = 0xFF;
        /// <summary>
        /// Информация о соединении
        /// </summary>
        public class LinkInfo
        {
            public string Name;
            public byte ID;
            public bool IsActive;
        }
        public bool IsEnabled;
        public LinkInfo Link = new LinkInfo();
        /// <summary>
        /// COM порт
        /// </summary>
        SerialPort m_Port = new SerialPort();
        /// <summary><value>
        /// COM порт
        /// </value></summary>
        public SerialPort Port
        {
            get
            {
                return m_Port;
            }
            set
            {
                m_Port = value;
            }
        }
        /// <summary>
        /// Имя текущего пользователя
        /// </summary>
        static string m_UserName = "Your name";
        private static byte[] m_ByteUserName;
        /// <summary><value>
        /// Имя текущего пользователя
        /// </value></summary>
        public static string UserName
        {
            get
            {
                return m_UserName;
            }
            set
            {
                m_UserName = value;
                m_ByteUserName = Encoding.Unicode.GetBytes(value);
            }
        }
        /// <summary>
        /// Идентификатор текущего пользователя
        /// </summary>
        static byte m_UserID = (byte)new Random().Next(1, 250);
        private bool Err;



        /// <summary>
        /// Идентификатор текущего пользователя
        /// </summary>
        public static byte UserID
        {
            get
            {
                return m_UserID;
            }
        }
        /// <summary>
        /// Перечислитель для типов кадров
        /// </summary>
        public enum FrameType : byte
        {
            UPLINK,
            ACK_UPLINK,
            RET_UPLINK,
            LINKACTIVE,
            ACK_LINKACTIVE,
            RET_LINKACTIVE,
            DOWNLINK,
            ACK_DOWNLINK,
            RET_DOWNLINK,
            MSG,
            RET_MSG,
            ACK
        }
        public enum DirectionType : byte
        {
            INCOMING,
            OUTGOING
        };
        /// <summary>
        /// Инициализатор обработчика приема данных через COM порт и обработичков таймеров
        /// </summary>
        public void InitializeHandlers()
        {

            Port.PinChanged += new SerialPinChangedEventHandler(SerialPinChangeExeption);
            Port.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
            t_UpLink.Tick += new EventHandler(t_UpLinkTick);
            t_ActiveLink.Tick += new EventHandler(t_ActiveLinkTick);
            t_DownLink.Tick += new EventHandler(t_DownLinkLinkTick);
        }

        private void SerialPinChangeExeption(object sender, SerialPinChangedEventArgs e)
        {
            if (!Port.DsrHolding && !Port.CtsHolding && !Err && Link.IsActive)
            {
                Err = true;
                Link.IsActive = false;
                t_ActiveLink.Stop();
                t_DownLink.Stop();
                t_UpLink.Stop();
                if (RadioButton2.Visible ^ RadioButton1.Visible)
                {
                    b_UpLink.Enabled = true;
                    b_DownLink.Enabled = false;
                    b_SendMessage.Enabled = false;
                    tb_CurrentMsg.Enabled = false;
                }
                if (RadioButton1.Text == Link.Name)
                {
                    RadioButton1.Invoke(new EventHandler(delegate
                    {
                        RadioButton1.Visible = false;
                    }));
                }
                if (RadioButton2.Text == Link.Name)
                {
                    RadioButton1.Invoke(new EventHandler(delegate
                    {
                        RadioButton2.Visible = false;
                    }));
                }
                MessageBox.Show("Соединение по " + Port.PortName + " разорвано");
            }
        }


        /// <summary>
        /// Тики таймеров
        /// </summary>
        private void t_DownLinkLinkTick(object sender, EventArgs e)
        {
            t_DownLink.Interval = 5000;
            if (c_linkDownTry > 0)
            {
                if (Link.IsActive == false)
                {
                    // Log.AppendText("Соединение по " + Port.PortName + " успешно разорвано \n");
                    // Log.ScrollToCaret();
                    c_linkDownTry = 3;
                    t_DownLink.Stop();
                    t_ActiveLink.Stop();
                }
                else
                {
                    c_linkDownTry--;
                    WriteData(null, 0, FrameType.DOWNLINK, UserID);
                }
            }
            else
            {
                //Log.AppendText("Соединение по " + Port.PortName + " не удалось разорвать \n");
                // Log.ScrollToCaret();
                c_linkDownTry = 3;
                t_DownLink.Stop();
            }
        }
        private void t_ActiveLinkTick(object sender, EventArgs e)
        {
            t_ActiveLink.Interval = 5000;
            if (c_linkActiveTry > 0)
            {
                if (Link.IsActive == true)
                {
                    WriteData(null, Link.ID, WorkingUnit.FrameType.LINKACTIVE, WorkingUnit.UserID);
                    c_linkActiveTry = 3;
                }

                if (Link.IsActive == false)
                {
                    c_linkActiveTry--;//не соединились, есть еще попытки
                    WriteData(null, Link.ID, WorkingUnit.FrameType.LINKACTIVE, WorkingUnit.UserID);
                }
            }
            else
            {
                //Log.AppendText("Соединение по " + Port.PortName + " потеряно \n");
                // Log.ScrollToCaret();
                Link.IsActive = false;
                c_linkActiveTry = 3;
                t_ActiveLink.Stop();
            }
        }
        private void t_UpLinkTick(object sender, EventArgs e)
        {
            t_UpLink.Interval = 3000;
            if (c_upLinkTry > 0)
            {

                if (Link.IsActive == false)
                {
                    c_upLinkTry--;//не соединились, есть еще попытки
                    WriteData(null, 0, WorkingUnit.FrameType.UPLINK, WorkingUnit.UserID);
                }
            }
            else
            {
                //Log.AppendText("Соединение по " + Port.PortName + " не установлено \n");
                //Log.ScrollToCaret();
                Link.IsActive = false;
                c_upLinkTry = 3;
                t_UpLink.Stop();
            }
        }
        public Button b_UpLink { get; set; }
        public Button b_DownLink { get; set; }
        public Button b_SendMessage { get; set; }
        public TextBox tb_CurrentMsg { get; set; }


        
        /// <summary>
        /// Метод отправки данных
        /// </summary>
        /// <param name="input">Передаваемая строка</param>
        /// <param name="receiver">Идентификатор получателя</param>
        /// <param name="type">Тип кадра</param>
        /// <param name="sender">Идентификатор отправителя</param>
        public void WriteData(string input, byte receiver, FrameType type, byte sender)
        {
            byte[] Header = { STARTBYTE, receiver, (byte)type, sender };
            byte[] BufferToSend;
            byte[] ByteToEncode;
            byte[] ByteEncoded;
            byte[] fileId = { 0 };
            int i;

            switch (type)
            {
                case FrameType.MSG:
                    #region MSG
                    if (Port.IsOpen && Link.IsActive == true)
                    {
                        ByteToEncode = Encoding.Unicode.GetBytes(input);
                        ByteEncoded = new byte[ByteToEncode.Length * 2];
                        i = 0;
                        foreach (byte item in ByteToEncode)
                        {
                            Hamming.HammingEncode74(ByteToEncode[i]).CopyTo(ByteEncoded, i * 2);
                            i++;
                        }
                        BufferToSend = new byte[Header.Length + ByteEncoded.Length];
                        Header.CopyTo(BufferToSend, 0);
                        ByteEncoded.CopyTo(BufferToSend, Header.Length);
                        Port.Write(BufferToSend, 0, BufferToSend.Length);
                    }
                    break;
                    #endregion
                case FrameType.UPLINK:
                    #region UPLINK

                    Header[1] = 0;
                    if (Port.IsOpen)
                    {
                        BufferToSend = new byte[Header.Length + m_ByteUserName.Length];
                        Header.CopyTo(BufferToSend, 0);
                        m_ByteUserName.CopyTo(BufferToSend, Header.Length);
                        Port.Write(BufferToSend, 0, BufferToSend.Length);
                    }
                    t_UpLink.Start();
                    t_ActiveLink.Start();
                    break;
                    #endregion
                case FrameType.ACK_UPLINK:
                    #region ACK_UPLINK
                    if (Port.IsOpen)
                    {
                        BufferToSend = new byte[Header.Length + m_ByteUserName.Length];
                        Header.CopyTo(BufferToSend, 0);
                        m_ByteUserName.CopyTo(BufferToSend, Header.Length);
                        Port.Write(BufferToSend, 0, BufferToSend.Length);
                    }
                    break;
                    #endregion
                case FrameType.DOWNLINK:
                    #region DOWNLINK

                    Header[1] = 0;
                    if (Port.IsOpen)
                    {
                        t_DownLink.Start();
                        t_ActiveLink.Stop();
                        t_UpLink.Stop();
                        Port.Write(Header, 0, Header.Length);
                    }
                    break;
                    #endregion
                default:
                    if (Port.IsOpen)
                        Port.Write(Header, 0, Header.Length);

                    break;
            }
            //WriteLog(DirectionType.OUTGOING, type);
        }
        /// <summary>
        /// Обработчик приема данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Err = false;
            if (Port.ReadByte() == STARTBYTE)
            {
                byte read = (byte)Port.ReadByte();
                if (read == m_UserID || read == 0)
                {
                    FrameAnalysis((byte)Port.ReadByte(), read);
                }
                //Port.DiscardInBuffer();
            }

        }
        /// <summary>
        /// Метод обработки кадра
        /// </summary>
        /// <param name="frametype">Тип обрабатываемого кадра</param>
        private void FrameAnalysis(byte frametypeid, byte to)
        {
            FrameType frametype = (FrameType)Enum.ToObject(typeof(FrameType), frametypeid);
            int bytesToRead;
            byte[] byteBuffer;
            int i;
            byte[] ToDecode;
            byte[] Decoded;
            switch (frametype)
            {

                case FrameType.UPLINK:
                    #region UPLINK
                    Link.IsActive = true;
                    if (RadioButton2.Visible && RadioButton1.Visible) b_UpLink.Enabled = false; ;
                    Link.ID = (byte)Port.ReadByte();
                    bytesToRead = Port.BytesToRead;
                    byteBuffer = new byte[bytesToRead];
                    Port.Read(byteBuffer, 0, bytesToRead);
                    Link.Name = Encoding.Unicode.GetString(byteBuffer);
                    if (!RadioButton1.Visible)
                    {
                        RadioButton1.Invoke(new EventHandler(delegate
                        {
                            RadioButton1.Text = Link.Name;
                            Messaging.User1ID = Link.ID;
                            RadioButton1.Visible = true;
                        }));
                    }
                    else if (Messaging.User1ID != Link.ID)
                    {
                        RadioButton2.Invoke(new EventHandler(delegate
                        {
                            RadioButton2.Text = Link.Name + (Link.Name == RadioButton1.Text ? "(2)" : "");
                            Messaging.User2ID = Link.ID;
                            RadioButton2.Visible = true;
                        }));
                    }
                    tb_CurrentMsg.Enabled = true;
                    b_SendMessage.Enabled = true;
                    b_DownLink.Enabled = true;
                    if (RadioButton1.Visible && RadioButton2.Visible) b_UpLink.Enabled = false;
                    WriteData(m_UserName, Link.ID, FrameType.ACK_UPLINK, m_UserID);
                    break;
                    #endregion
                case FrameType.ACK_UPLINK:
                    #region ACK_UPLINK
                    Link.IsActive = true;
                    Link.ID = (byte)Port.ReadByte();
                    bytesToRead = Port.BytesToRead;
                    byteBuffer = new byte[bytesToRead];
                    Port.Read(byteBuffer, 0, bytesToRead);
                    Link.Name = Encoding.Unicode.GetString(byteBuffer);
                    if (!RadioButton1.Visible)
                    {
                        RadioButton1.Invoke(new EventHandler(delegate
                        {
                            RadioButton1.Text = Link.Name;
                            Messaging.User1ID = Link.ID;
                            RadioButton1.Visible = true;
                        }));
                    }
                    else if (Messaging.User1ID != Link.ID)
                    {
                        RadioButton2.Invoke(new EventHandler(delegate
                        {
                            RadioButton2.Text = Link.Name + (Link.Name == RadioButton1.Text ? "(2)" : "");
                            Messaging.User2ID = Link.ID;
                            RadioButton2.Visible = true;
                        }));
                    }
                    c_upLinkTry = 3;//восстановили число попыток
                    t_UpLink.Stop();//успешно соединились

                    WriteData(null, Link.ID, FrameType.LINKACTIVE, UserID);
                    // Log.AppendText("Соединение по " + Port.PortName + " установлено \n");
                    //Log.ScrollToCaret();

                    break;
                    #endregion
                case FrameType.RET_UPLINK:
                    #region RET_UPLINK
                    Link.IsActive = false;
                    WriteData(null, Link.ID, FrameType.UPLINK, m_UserID);
                    break;
                    #endregion
                case FrameType.DOWNLINK:
                    #region DOWNLINK
                    Link.IsActive = false;
                    t_ActiveLink.Stop();
                    WriteData(null, Link.ID, FrameType.ACK_DOWNLINK, m_UserID);
                    if (RadioButton2.Visible ^ RadioButton1.Visible)
                    {
                        b_UpLink.Enabled = true;
                        b_DownLink.Enabled = false;
                        b_SendMessage.Enabled = false;
                        tb_CurrentMsg.Enabled = false;
                    }
                    if (RadioButton1.Text == Link.Name)
                    {
                        RadioButton1.Invoke(new EventHandler(delegate
                        {
                            RadioButton1.Visible = false;
                        }));
                    }
                    if (RadioButton2.Text == Link.Name)
                    {
                        RadioButton1.Invoke(new EventHandler(delegate
                        {
                            RadioButton2.Visible = false;
                        }));
                    }
                    /*
                    tb_CurrentMsg.Enabled = false;
                    b_SendMessage.Enabled = false;
                    b_SendFile.Enabled = false;
                    b_DownLink.Enabled = false;
                    b_UpLink.Enabled = false;
                    */
                    break;
                    #endregion
                case FrameType.ACK_DOWNLINK:
                    #region ACK_DOWNLINK
                    Link.IsActive = false;

                    t_ActiveLink.Stop();

                    if (RadioButton1.Text == Link.Name)
                    {
                        RadioButton1.Invoke(new EventHandler(delegate
                        {
                            RadioButton1.Visible = false;
                        }));
                    }
                    if (RadioButton2.Text == Link.Name)
                    {
                        RadioButton1.Invoke(new EventHandler(delegate
                        {
                            RadioButton2.Visible = false;
                        }));
                    }

                    break;
                    #endregion
                case FrameType.RET_DOWNLINK:
                    #region RET_DOWNLINK
                    Link.IsActive = false;
                    WriteData(null, Link.ID, FrameType.DOWNLINK, m_UserID);
                    break;
                    #endregion
                case FrameType.LINKACTIVE:
                    #region LINKACTIVE
                    Link.IsActive = true;
                    WriteData(null, Link.ID, FrameType.ACK_LINKACTIVE, UserID);
                    break;
                    #endregion
                case FrameType.ACK_LINKACTIVE:
                    #region ACK_LINKACTIVE
                    Link.IsActive = true;
                    break;
                    #endregion
                case FrameType.RET_LINKACTIVE:
                    #region RET_LINKACTIVE
                    Link.IsActive = false;
                    WriteData(null, Link.ID, FrameType.LINKACTIVE, m_UserID);
                    break;
                    #endregion
                case FrameType.MSG:
                    #region MSG
                    if (Link.IsActive)
                    {
                        Port.ReadByte();
                        bytesToRead = Port.BytesToRead;
                        byte[] msgByteBuffer = new byte[bytesToRead];
                        Port.Read(msgByteBuffer, 0, bytesToRead);
                        ToDecode = new byte[2];
                        Decoded = new byte[bytesToRead / 2];
                        for (i = 0; i < bytesToRead / 2; i++)
                        {
                            ToDecode[0] = msgByteBuffer[i * 2];
                            ToDecode[1] = msgByteBuffer[(i * 2) + 1];
                            Decoded[i] = Hamming.Decode(ToDecode);
                        }
                        string ToDisplay = Encoding.Unicode.GetString(Decoded);
                        Display.Invoke(new EventHandler(delegate
                        {
                            Display.AppendText(
                            "[" + DateTime.Now + "] "
                            + Link.Name
                            + (to == WorkingUnit.UserID ? " [личное]" : "") + ": "
                            + ToDisplay
                            + "\r\n");
                            Display.ScrollToCaret();
                        }));
                        string message = "[" + DateTime.Now + "] "
                            + Link.Name
                            + ": "
                            + ToDisplay
                            + "\r\n";
                       // if (ReceivedMessageEvent == null)
                        ReceivedMessageEvent(this, new ReceivedMessageEventArgs(message));
                        WriteData(null, Link.ID, FrameType.ACK, UserID);
                    }
                    break;
                    #endregion
                case FrameType.RET_MSG:
                    #region RET_MSG
                    WriteData("Сообщение"/*_currentMsg*/, Link.ID, FrameType.MSG, m_UserID);
                    break;
                    #endregion
                case FrameType.ACK:
                    #region ACK
                    break;
                    #endregion
                default:
                    break;
            }

            //WriteLog(DirectionType.INCOMING, frametype);
        }
    }
}