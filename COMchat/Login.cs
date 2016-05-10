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
    public partial class Login : Form
    {

        public Messaging Messaging { get; set; }
        public Inbox Inbox { get; set; }

        public Login()
        {
            InitializeComponent();
            port1.DataSource = SerialPort.GetPortNames();
            port2.DataSource = SerialPort.GetPortNames();
            port1.SelectedIndex = 0;
            speed1.SelectedIndex = 0;
            byte1.SelectedIndex = 0;
            parity1.SelectedIndex = 0;
            stop1.SelectedIndex = 0;
            port2.SelectedIndex = 0;
            speed2.SelectedIndex = 0;
            byte2.SelectedIndex = 0;
            parity2.SelectedIndex = 0;
            stop2.SelectedIndex = 0;
        }

       

        private void logbut_Click(object sender, EventArgs e)
        {
            if (namebox.Text.TrimEnd(' ', '\t').Length == 0)
                MessageBox.Show("Необходимо ввести имя!");
            else if (port1.SelectedItem.ToString() == port2.SelectedItem.ToString())
                MessageBox.Show("Нужны разные порты!");
            else Messaging = new Messaging(this, namebox.Text, port1.SelectedItem.ToString(), speed1.SelectedItem.ToString(), byte1.SelectedItem.ToString(), parity1.SelectedItem.ToString(), stop1.SelectedItem.ToString(),
                port2.SelectedItem.ToString(), speed2.SelectedItem.ToString(), byte2.SelectedItem.ToString(), parity2.SelectedItem.ToString(), stop2.SelectedItem.ToString());
            Messaging.Show();
            Inbox = new Inbox();
            Inbox.Show();
           
        }
    }
}
