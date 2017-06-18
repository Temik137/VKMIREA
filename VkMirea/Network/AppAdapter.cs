using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace VkMirea.Network
{
    public class AppAdapter
    {
        private readonly TcpClient client = new TcpClient();

        public Task Connect(string adress, int port)
        {
            return client.ConnectAsync(adress, port);
        }

        public async Task<bool> SendMessageAsync(string message)
        {
            return await Task.Run(() => SendMessage(message));
        }

        public bool SendMessage(string message)
        {
            try
            {
                var data = System.Text.Encoding.ASCII.GetBytes(message);

                var stream = client.GetStream();

                stream.Write(data, 0, data.Length);

                // Получаем ответ от сервера.

                data = new Byte[256];

                string responseData = String.Empty;

                //TODO: Принять ответ от сервера
                // Читаем первый пакет ответа сервера. 
                // Можно читать всё сообщение.
                // Для этого надо организовать чтение в цикле как на сервере.
                var bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                stream.Close();

                return responseData.Length != 0; //TODO: Поменять на нормальную проверку
            }
            catch (ArgumentNullException e)
            { //TODO: Обработать
                return false;
            }
            catch (SocketException e)
            { //TODO: Обработать
                return false;
            }
        }

        public bool CloseConnection()
        {
            client.Close();
            return !client.Connected;
        }
    }
}