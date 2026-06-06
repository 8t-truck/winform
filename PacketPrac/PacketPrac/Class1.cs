using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PacketPrac
{
    public enum PacketType
    {
        초기화 = 0,
        로그인,
        메시지  // 문자열 메시지 패킷 추가
    }

    public enum PacketSendERROR
    {
        정상 = 0,
        에러
    }

    [Serializable]
    public class Packet
    {
        public int Length;
        public int Type;

        public Packet()
        {
            this.Length = 0;
            this.Type = 0;
        }

        // 객체 → byte[] 직렬화
#pragma warning disable SYSLIB0011
        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }

        // byte[] → 객체 역직렬화
        public static Object Desserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(bt);
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
#pragma warning restore SYSLIB0011
    }

    [Serializable]
    public class Initialize : Packet
    {
        public int Data = 0;
    }

    [Serializable]
    public class Login : Packet
    {
        public string? m_strID;

        public Login()
        {
            this.m_strID = null;
        }
    }

    [Serializable]
    public class Message : Packet
    {
        public string? m_strMessage;  // 전송할 문자열 내용

        public Message()
        {
            this.m_strMessage = null;
        }
    }

    public class Class1
    {
    }
}
