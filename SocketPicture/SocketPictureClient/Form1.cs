using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SocketPictureClient
{
    public partial class ClientForm : Form
    {
        // TCP 클라이언트 및 네트워크 스트림
        private TcpClient? tcpClient;
        private NetworkStream? networkStream;

        public ClientForm()
        {
            InitializeComponent();
            ConnectToServer();
        }

        // 서버 연결 메서드
        private void ConnectToServer()
        {
            try
            {
                // 로컬호스트 5000번 포트에 연결
                tcpClient = new TcpClient();
                tcpClient.Connect("127.0.0.1", 5000);
                networkStream = tcpClient.GetStream();
                lblStatus.Text = "서버 연결 완료!";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "연결 실패: " + ex.Message;
            }
        }

        // 색상 데이터를 서버로 전송하는 전송 메서드
        //private void SendColor(string colorName)
        //{
        //    if (networkStream == null) return;
        //    try
        //    {
        //        // 문자열을 바이트 배열로 변환 후 전송
        //        byte[] data = Encoding.UTF8.GetBytes(colorName);
        //        networkStream.Write(data, 0, data.Length);
        //        lblStatus.Text = $"{colorName} 전송 완료";
        //    }
        //    catch (Exception ex)
        //    {
        //        lblStatus.Text = "전송 실패: " + ex.Message;
        //    }
        //}
        private void SendColor(string colorName)
        {
            if (networkStream == null) return;
            try
            {
                // 색상 이름으로 비트맵 생성
                Color color = colorName switch
                {
                    "RED" => Color.Red,
                    "BLUE" => Color.Blue,
                    "GREEN" => Color.Green,
                    _ => Color.White
                };

                // 100x100 단색 이미지 생성
                using Bitmap bmp = new Bitmap(100, 100);
                using (Graphics g = Graphics.FromImage(bmp))
                    g.Clear(color);

                // 이미지를 바이트 배열로 변환
                using MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageData = ms.ToArray();

                // 서버 프로토콜: [4바이트 크기][이미지 데이터]
                byte[] sizeBytes = BitConverter.GetBytes(imageData.Length);
                networkStream.Write(sizeBytes, 0, 4);
                networkStream.Write(imageData, 0, imageData.Length);

                lblStatus.Text = $"{colorName} 전송 완료";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "전송 실패: " + ex.Message;
            }
        }

        // 빨강 색 전송 버튼
        private void btnRed_Click(object sender, EventArgs e)
        {
            SendColor("RED");
        }

        // 파랑 색 전송 버튼
        private void btnBlue_Click(object sender, EventArgs e)
        {
            SendColor("BLUE");
        }

        // 초록 색 전송 버튼
        private void btnGreen_Click(object sender, EventArgs e)
        {
            SendColor("GREEN");
        }

        // 폼 닫힐 때 리소스 해제
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            networkStream?.Close();
            tcpClient?.Close();
        }
    }
}