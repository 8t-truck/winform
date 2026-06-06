using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        TcpListener server = null;
        IPAddress localAddr = IPAddress.Parse("127.0.0.1");
        int port = 13000;

        try
        {
            server = new TcpListener(localAddr, port);
            server.Start();

            while (true)
            {
                Console.WriteLine("Waiting for a connection...");
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Connected!");

                NetworkStream stream = client.GetStream();

                // 입력받은 메시지 전송
                Console.Write("보낼 메시지 입력: ");
                string message = Console.ReadLine();

                byte[] writeBuffer = Encoding.UTF8.GetBytes(message);
                byte[] writeBufferSize = BitConverter.GetBytes(writeBuffer.Length);

                // 크기 먼저, 내용 후
                stream.Write(writeBufferSize, 0, writeBufferSize.Length);
                stream.Write(writeBuffer, 0, writeBuffer.Length);
                Console.WriteLine("Sent: {0}", message);

                stream.Close();
                client.Close();
                Console.WriteLine();
            }
        }
        catch (SocketException e)
        {
            Console.WriteLine("SocketException: {0}", e);
        }
        finally
        {
            server.Stop();
        }

        Console.WriteLine("\n서버가 종료됩니다.");
    }
}