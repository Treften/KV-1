using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Net;
using NLog;
namespace Client
{
    class Client
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static UdpClient udp;
        static void Main(string[] args)
        {
            bool run = true;

            udp = new UdpClient(8002);
            logger.Debug("Server is up");
            Console.WriteLine("Клиент работает");
            Console.WriteLine("\n1 -- Вывести все записи\n2 -- Вывести по индексу\n3 -- Добавить запись\n4 -- Удалить запись\n5 -- Сохранить данные");
            Console.Write("Введите сообщение: ");
            while (run) 
            { 
            try
            {
                    
                    SendMessage();
                RecieveMessage();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        }
        private static void SendMessage()
        {
            try
            {
               
                string message = Console.ReadLine();
                byte[] data = Encoding.Unicode.GetBytes(message);
                udp.Send(data, data.Length, "127.0.0.1", 8001);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        private static void RecieveMessage()
        {
            IPEndPoint remoteIp = (IPEndPoint)udp.Client.LocalEndPoint;
            try
            {
                byte[] data = udp.Receive(ref remoteIp);
                string message = Encoding.Unicode.GetString(data);
                Console.WriteLine("{0}", message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
