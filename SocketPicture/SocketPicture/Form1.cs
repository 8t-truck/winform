using System.Net;
using System.Net.Sockets;

namespace SocketPicture
{
    public partial class ServerForm : Form
    {
        private TcpListener? _listener;
        private CancellationTokenSource? _cts;
        private bool _isRunning = false;

        public ServerForm()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
        }

        private async void BtnStart_Click(object? sender, EventArgs e)
        {
            if (!_isRunning)
                await StartServerAsync();
            else
                StopServer();
        }

        private async Task StartServerAsync()
        {
            try
            {
                _cts = new CancellationTokenSource();
                _listener = new TcpListener(IPAddress.Any, 5000);
                _listener.Start();
                _isRunning = true;
                btnStart.Text = "서버 중지";
                lblStatus.Text = "연결 대기 중... (포트 5000)";

                await AcceptClientsAsync(_cts.Token);
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"포트 바인딩 실패: {ex.Message}", "서버 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopServer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"서버 시작 오류: {ex.Message}", "서버 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopServer();
            }
        }

        private void StopServer()
        {
            _cts?.Cancel();
            _cts?.Dispose();
            _cts = null;
            try { _listener?.Stop(); } catch { }
            _listener = null;
            _isRunning = false;

            if (InvokeRequired)
                Invoke(() => { btnStart.Text = "서버 시작"; lblStatus.Text = "대기 중..."; });
            else
            {
                btnStart.Text = "서버 시작";
                lblStatus.Text = "대기 중...";
            }
        }

        private async Task AcceptClientsAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    TcpClient client = await _listener!.AcceptTcpClientAsync(token);
                    _ = HandleClientAsync(client, token);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (SocketException ex) when (!token.IsCancellationRequested)
                {
                    UpdateStatus($"수락 오류: {ex.Message}");
                }
            }
        }

        private async Task HandleClientAsync(TcpClient client, CancellationToken token)
        {
            string clientInfo = client.Client.RemoteEndPoint?.ToString() ?? "알 수 없음";
            UpdateStatus($"연결됨: {clientInfo}");

            try
            {
                using (client)
                using (NetworkStream stream = client.GetStream())
                {
                    while (!token.IsCancellationRequested && client.Connected)
                    {
                        byte[] sizeBuffer = new byte[4];
                        int read = await ReadExactAsync(stream, sizeBuffer, 4, token);
                        if (read == 0) break;

                        int imageSize = BitConverter.ToInt32(sizeBuffer, 0);
                        if (imageSize <= 0 || imageSize > 50_000_000)
                        {
                            UpdateStatus($"잘못된 데이터 크기: {imageSize} bytes");
                            break;
                        }

                        byte[] imageData = new byte[imageSize];
                        read = await ReadExactAsync(stream, imageData, imageSize, token);
                        if (read == 0) break;

                        DisplayImage(imageData);
                        UpdateStatus($"이미지 수신: {imageSize:N0} bytes ({clientInfo})");
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // 서버 중지로 인한 정상 종료
            }
            catch (IOException ex)
            {
                if (!token.IsCancellationRequested)
                    UpdateStatus($"통신 끊김: {ex.Message}");
            }
            catch (Exception ex)
            {
                UpdateStatus($"클라이언트 오류: {ex.Message}");
            }
            finally
            {
                UpdateStatus($"연결 해제: {clientInfo}");
            }
        }

        private static async Task<int> ReadExactAsync(NetworkStream stream, byte[] buffer, int count, CancellationToken token)
        {
            int totalRead = 0;
            while (totalRead < count)
            {
                int read = await stream.ReadAsync(buffer.AsMemory(totalRead, count - totalRead), token);
                if (read == 0) return 0;
                totalRead += read;
            }
            return totalRead;
        }

        private void DisplayImage(byte[] imageData)
        {
            try
            {
                using MemoryStream ms = new MemoryStream(imageData);
                Image image = Image.FromStream(ms);

                Invoke(() =>
                {
                    Image? old = pictureBox1.Image;
                    pictureBox1.Image = image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    old?.Dispose();
                });
            }
            catch (ArgumentException)
            {
                UpdateStatus("수신된 데이터가 유효한 이미지가 아닙니다.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"이미지 표시 오류: {ex.Message}");
            }
        }

        private void UpdateStatus(string message)
        {
            if (InvokeRequired)
                Invoke(() => lblStatus.Text = message);
            else
                lblStatus.Text = message;
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer();
        }
    }
}
