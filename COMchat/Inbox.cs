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
namespace COMPorts
{
    public partial class Inbox : Form
    {
        public WorkingUnit com1 { get; set; }
        public WorkingUnit com2 { get; set; }
        public Inbox(Login login, string name, string port1, string speed1, string bytes1, string parity1, string stop1, string port2, string speed2, string bytes2, string parity2, string stop2)
        {
            com1 = new WorkingUnit(name, port1, speed1, bytes1, parity1, stop1);
            com2 = new WorkingUnit(name, port2, speed2, bytes2, parity2, stop2);
            InitializeComponent();
            com1.ReceivedMessageEvent += ReceivedMessageEventHandler1;
            com2.ReceivedMessageEvent += ReceivedMessageEventHandler2;
        }

        private void ReceivedMessageEventHandler(object sender, ReceivedMessageEventArgs text)
        {
            incoming.Invoke(new EventHandler(delegate
            {
                incoming.AppendText(text._text);
               incoming.ScrollToCaret();
            }));

        }
    }

}
