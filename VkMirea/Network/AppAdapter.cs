using System;
using System.Net.Sockets;

namespace VkMirea.Network
{
    public class AppAdapter
    {
        private TcpClient Client { get; }
        public AppAdapter(string adress, int port)
        {
            Client = new TcpClient(adress, port);
        }

        private bool SendMessage(string message)
        {
            try
            {
                // Создаём TcpClient.
                // Для созданного в предыдущем проекте TcpListener 
                // Настраиваем его на IP нашего сервера и тот же порт.

                // Переводим наше сообщение в ASCII, а затем в массив Byte.
                var data = System.Text.Encoding.ASCII.GetBytes(message);

                // Получаем поток для чтения и записи данных.
                var stream = Client.GetStream();

                // Отправляем сообщение нашему серверу. 
                stream.Write(data, 0, data.Length);

                // Получаем ответ от сервера.

                // Буфер для хранения принятого массива bytes.
                data = new Byte[256];

                // Строка для хранения полученных ASCII данных.
                string responseData = String.Empty;

                // Читаем первый пакет ответа сервера. 
                // Можно читать всё сообщение.
                // Для этого надо организовать чтение в цикле как на сервере.
                var bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                // Закрываем поток.
                stream.Close();

                return responseData.Length != 0; //TODO: Поменять на нормальную проверку
            }
            catch (ArgumentNullException e)
            { //TODO: Обработать
            }
            catch (SocketException e)
            { //TODO: Обработать
            }


        }

        public bool CloseConnection()
        {
            Client.Close();
            return !Client.Connected;
        }
    }
}