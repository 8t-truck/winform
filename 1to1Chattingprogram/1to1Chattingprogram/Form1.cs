using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace _1to1Chattingprogram
{
    public partial class Form1 : Form
    {
        // ─── 서버/클라이언트 공통 ───
        public NetworkStream m_Stream;      // 네트워크 스트림
        public StreamReader m_Read;         // 읽기
        public StreamWriter m_Write;        // 쓰기
        const int PORT = 2002;              // 포트번호
        private Thread m_ThReader;          // 읽기 스레드

        // ─── 서버 전용 ───
        public bool m_bStop = false;        // 서버 시작&중단 플래그
        private TcpListener m_listener;     // 서버 리스너
        private Thread m_thServer;          // 서버 스레드

        // ─── 클라이언트 전용 ───
        public bool m_bConnect = false;     // 서버 접속 플래그
        TcpClient m_Client;

        // ─── CancellationToken ───
        private CancellationTokenSource cancellationTokenSource1;
        private CancellationToken cancellationtoken1;
        private CancellationTokenSource cancellationTokenSource2;
        private CancellationToken cancellationtoken2;

        public Form1()
        {
            InitializeComponent();
        }

        // ============================
        //         UI 관련
        // ============================

        // 채팅창에 메시지 추가 (UI 스레드 안전)
        public void Message(string msg)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                txt_all.AppendText(msg + "\n");
                txt_all.Focus();
                txt_all.ScrollToCaret();
                txt_send.Focus();
            }));
        }

        // ============================
        //         서버 관련
        // ============================

        // 서버 시작
        public void ServerStart(CancellationToken token)
        {
            try
            {
                if (!token.IsCancellationRequested)
                {
                    m_listener = new TcpListener(PORT);
                    m_listener.Start();

                    m_bStop = true;
                    Message("클라이언트 접속 대기중");

                    while (m_bStop)
                    {
                        TcpClient hClient = m_listener.AcceptTcpClient();

                        if (hClient.Connected)
                        {
                            m_bConnect = true;
                            Message("클라이언트 접속");

                            m_Stream = hClient.GetStream();
                            m_Read = new StreamReader(m_Stream);
                            m_Write = new StreamWriter(m_Stream);

                            cancellationTokenSource1 = new CancellationTokenSource();
                            cancellationtoken1 = cancellationTokenSource1.Token;
                            m_ThReader = new Thread(() => Receive(cancellationtoken1));
                            m_ThReader.Start();
                        }
                    }
                }
            }
            catch
            {
                Message("시작 도중에 오류 발생");
                return;
            }
        }

        // 서버 중단
        public void ServerStop()
        {
            if (!m_bStop)
                return;

            m_listener.Stop();
            m_Read.Close();
            m_Write.Close();
            m_Stream.Close();

            cancellationTokenSource1.Cancel();  // Receive token cancel
            cancellationTokenSource2.Cancel();  // ServerStart token cancel

            Message("서비스 종료");
        }

        // ============================
        //       클라이언트 관련
        // ============================

        // 서버 연결
        public void Connect()
        {
            m_Client = new TcpClient();
            try
            {
                m_Client.Connect(txt_ServerIp.Text, PORT);
            }
            catch
            {
                m_bConnect = false;
                return;
            }

            m_bConnect = true;
            Message("서버에 연결");

            m_Stream = m_Client.GetStream();
            m_Read = new StreamReader(m_Stream);
            m_Write = new StreamWriter(m_Stream);

            cancellationTokenSource1 = new CancellationTokenSource();
            cancellationtoken1 = cancellationTokenSource1.Token;
            m_ThReader = new Thread(() => Receive(cancellationtoken1));
            m_ThReader.Start();
        }

        // 연결 해제
        public void Disconnect()
        {
            if (!m_bConnect)
                return;

            m_bConnect = false;
            m_Read.Close();
            m_Write.Close();
            m_Stream.Close();
            cancellationTokenSource1.Cancel();

            Message("상대방과 연결 중단");
        }

        // ============================
        //         통신 관련
        // ============================

        // 메시지 수신 (스레드에서 실행)
        public void Receive(CancellationToken token)
        {
            try
            {
                while (m_bConnect && !token.IsCancellationRequested)
                {
                    string szMessage = m_Read.ReadLine();
                    if (szMessage != null)
                        Message("상대방 >>> : " + szMessage + "\n");
                }
                return;
            }
            catch
            {
                if (!token.IsCancellationRequested)
                    Message("데이터를 읽는 과정에서 오류가 발생");
            }
            Disconnect();
        }

        // 메시지 송신
        public void Send()
        {
            try
            {
                m_Write.WriteLine(txt_send.Text);
                m_Write.Flush();
                Message(">>> : " + txt_send.Text+"\n");
                txt_send.Text = "";
            }
            catch
            {
                Message("데이터 전송 실패");
            }
        }

        // ============================
        //       이벤트 핸들러
        // ============================

        // 폼 닫기
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerStop();
            Disconnect();
        }

        // 서버 켜기/끄기 버튼
        private void btn_Server_Click(object sender, EventArgs e)
        {
            if (btn_Server.Text == "서버 켜기")
            {
                cancellationTokenSource2 = new CancellationTokenSource();
                cancellationtoken2 = cancellationTokenSource2.Token;
                m_thServer = new Thread(() => ServerStart(cancellationtoken2));
                m_thServer.Start();
                btn_Server.Text = "서버 멈춤";
                btn_Server.ForeColor = Color.Red;
            }
            else
            {
                ServerStop();
                btn_Server.Text = "서버 켜기";
                btn_Server.ForeColor = Color.Black;
            }
        }

        // 서버 연결/끊기 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            if (btn_Connect.Text == "서버 연결")
            {
                Connect();
                if (m_bConnect)
                {
                    btn_Connect.Text = "연결 끊기";
                    btn_Connect.ForeColor = Color.Red;
                }
            }
            else
            {
                Disconnect();
                btn_Connect.Text = "서버 연결";
                btn_Connect.ForeColor = Color.Black;
            }
        }

        // 보내기 버튼
        private void btn_send_Click(object sender, EventArgs e)
        {
            Send();
        }

        // Enter키 전송
        private void btn_send_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Send();
        }

        // 프로그램 종료 버튼
        private void btn_exit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
/*
멤버 변수
    ↓
UI 관련     : Message()
    ↓
서버 관련   : ServerStart() → ServerStop()
    ↓
클라이언트  : Connect() → Disconnect()
    ↓
통신 관련   : Receive() → Send()
    ↓
이벤트 핸들러 : FormClosing → btn_Server → btn_Connect → btn_Send → btn_exit
*/