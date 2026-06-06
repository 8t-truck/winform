using PacketPrac;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace PacketServer
{
    public partial class PacketServer : Form
    {
        private NetworkStream? m_networkstream;
        private TcpListener? m_listener;
        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];
        private bool m_bClientOn = false;
        private Thread? m_thread;

        public Initialize? m_initializeClass;
        public Login? m_loginClass;

        public PacketServer()
        {
            InitializeComponent();
        }

        public void RUN()
        {
            this.m_listener = new TcpListener(IPAddress.Any, 7777);
            this.m_listener.Start();

            this.Invoke(new MethodInvoker(delegate ()
            {
                this.txt_server_state.AppendText("클라이언트 대기 중\n");
            }));

            TcpClient client = this.m_listener.AcceptTcpClient();

            if (client.Connected)
            {
                this.m_bClientOn = true;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.txt_server_state.AppendText("클라이언트 연결\n");
                }));
                m_networkstream = client.GetStream();
            }

            while (this.m_bClientOn)
            {
                try
                {
                    this.m_networkstream!.Read(readBuffer, 0, 1024 * 4);
                }
                catch
                {
                    this.m_bClientOn = false;
                    this.m_networkstream = null;
                    break;
                }

                Packet packet = (Packet)Packet.Desserialize(this.readBuffer);

                switch ((int)packet.Type)
                {
                    case (int)PacketType.초기화:
                        this.m_initializeClass = (Initialize)Packet.Desserialize(this.readBuffer);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            this.txt_server_state.AppendText(
                                "패킷 수신 성공. Initialize Data: " + this.m_initializeClass.Data + "\n");
                        }));
                        break;

                    case (int)PacketType.로그인:
                        this.m_loginClass = (Login)Packet.Desserialize(this.readBuffer);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            this.txt_server_state.AppendText(
                                "패킷 수신 성공. Login ID: " + this.m_loginClass.m_strID + "\n");
                        }));
                        break;

                    case (int)PacketType.메시지:
                        // 수신된 byte[]를 Message 객체로 역직렬화 (PacketPrac.Message로 명시 - WinForms의 Message와 충돌 방지)
                        PacketPrac.Message msgPacket = (PacketPrac.Message)Packet.Desserialize(this.readBuffer);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            this.txt_server_state.AppendText(
                                "메시지 수신: " + msgPacket.m_strMessage + "\n");
                        }));
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.m_thread = new Thread(new ThreadStart(RUN));
            this.m_thread.IsBackground = true;
            this.m_thread.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_bClientOn = false;
            this.m_listener?.Stop();
            this.m_networkstream?.Close();
        }
    }
}
