using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pong
{
    public partial class serverPingPong : Form
    {
        public serverPingPong()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        string _currentData = "";
        public const int _buffer = 1024;
        private Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private List<Socket> _clients = new List<Socket>();
       
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 8080);
            server.Bind(iPEndPoint);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        _clients.Add(client);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
            listen.IsBackground = true;
            listen.Start();
            button1.Enabled = false;
            listView1.Items.Add("Server is running...");
        }
        
        public void Receive(object obj)
        {
            try
            {
                Socket client = obj as Socket;
                _currentData = "";

                while (true)
                {
                    byte[] buffer = new byte[_buffer * 5];
                    client.Receive(buffer);
                    _currentData = (string)Deserialize(buffer);
                    string data = _currentData as string;
                    char[] b = { '|' };
                    Int32 count = 2;
                    String[] strList = data.Split(b, count, StringSplitOptions.RemoveEmptyEntries);
                    listView1.Items.Add(strList[0] + "-" + strList[1]);
                    Send(strList[1]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        private void Send(string data_need_to_send)
        {
            try
            {
                foreach (Socket client in _clients)
                {
                    client.Send(Serialize(data_need_to_send));
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        byte[] Serialize(object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(ms);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PongForm f = new PongForm("user1");
            f.Show();
            PongForm h = new PongForm("user2");
            h.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
