using PacketPrac;
using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PacketClient
{
    public partial class PacketClient : Form
    {
        private NetworkStream? m_networkstream;
        private TcpClient? m_client;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bConnect = false;

        public Initialize? m_initializeClass;
        public Login? m_loginClass;

        public void Send()
        {
            this.m_networkstream!.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkstream.Flush();

            // 버퍼 초기화
            Array.Clear(this.sendBuffer, 0, this.sendBuffer.Length);
        }

        public PacketClient()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            this.m_client = new TcpClient();
            try
            {
                this.m_client.Connect(this.txt_ip.Text, 7777);
            }
            catch
            {
                MessageBox.Show("연결 실패");
                return;
            }
            this.m_bConnect = true;
            this.m_networkstream = this.m_client.GetStream();
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (!this.m_bConnect) return;

            Initialize Init = new Initialize();
            Init.Type = (int)PacketType.초기화;
            Init.Data = Int32.Parse(this.txt_init.Text);

            Packet.Serialize(Init).CopyTo(this.sendBuffer, 0);
            this.Send();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!this.m_bConnect) return;

            Login login = new Login();
            login.Type = (int)PacketType.로그인;
            login.m_strID = this.txt_login.Text;

            Packet.Serialize(login).CopyTo(this.sendBuffer, 0);
            this.Send();
        }

        private void btn_message_Click(object sender, EventArgs e)
        {
            if (!this.m_bConnect) return;

            // Message 패킷 생성 후 문자열 내용 세팅 (PacketPrac.Message로 명시 - WinForms의 Message와 충돌 방지)
            PacketPrac.Message msg = new PacketPrac.Message();
            msg.Type = (int)PacketType.메시지;
            msg.m_strMessage = this.txt_message.Text;

            Packet.Serialize(msg).CopyTo(this.sendBuffer, 0);
            this.Send();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_client?.Close();
            this.m_networkstream?.Close();
        }
    }
}
