using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Threading.Tasks;
using static UI_SBS.socket;
using System.Windows.Forms;

namespace UI_SBS
{
    public class socket
    {

        private static TcpListener server;
        private static Thread thread;

        public class serv
        {
            static async Task Main()
            {
                // Crea un TcpListener que escuche en todas las interfaces de red en el puerto 12345
                TcpListener servidor = new TcpListener(IPAddress.Any, 12345);

                // Inicia el hilo para manejar la escucha del socket
                Task hiloEscucha = EscucharClientesAsync(servidor);

                Console.WriteLine("Servidor TCP escuchando en todas las interfaces de red en el puerto 12345.");
                Console.WriteLine("Presiona Enter para salir.");
                Console.ReadLine();

                // Detiene el TcpListener al salir del programa
                servidor.Stop();

                // Espera a que el hilo de escucha termine antes de salir
                await hiloEscucha;
            }

            static async Task EscucharClientesAsync(TcpListener servidor)
            {
                try
                {
                    // Comienza a escuchar conexiones entrantes
                    servidor.Start();

                    while (true)
                    {
                        // Acepta la conexión del cliente de forma asincrónica
                        TcpClient cliente = await servidor.AcceptTcpClientAsync();

                        // En este punto, puedes manejar la lógica de comunicación con el cliente
                        // (por ejemplo, asignar un ID y enviar mensajes).
                        Console.WriteLine("Cliente conectado desde: " + ((IPEndPoint)cliente.Client.RemoteEndPoint).Address);

                        // Puedes realizar más acciones con el cliente aquí según tus necesidades.

                        // Cierra la conexión con el cliente de forma asincrónica
                        cliente.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public class client
        {

            private TcpClient cliente;
            private void mai()
            {
                // Inicializa el cliente
                cliente = new TcpClient();

                // Conéctate al servidor en la dirección IP y el puerto correspondientes
                ConectarAlServidor("127.0.0.1", 12345);

                // Llama a un método asincrónico para recibir mensajes
                RecibirMensajesAsync(); 
            }

            private void ConectarAlServidor(string ip, int puerto)
            {
                try
                {
                    // Conéctate al servidor
                    cliente.Connect(ip, puerto);
                }
                catch (Exception ex)
                {
                    // Manejar excepciones
                    MessageBox.Show("Error al conectar al servidor: " + ex.Message);
                }
            }

            private async void RecibirMensajesAsync()
            {
                try
                {
                    // Utiliza un bucle asincrónico para recibir mensajes continuamente
                    while (true)
                    {
                        // Recibe el mensaje del servidor de forma asincrónica
                        string mensaje = await RecibirMensajeAsync();

                        // Puedes procesar el mensaje recibido aquí
                        MessageBox.Show("Mensaje recibido: " + mensaje);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones
                    MessageBox.Show("Error al recibir mensajes: " + ex.Message);
                }
            }

            private async Task<string> RecibirMensajeAsync()
            {
                try
                {
                    // Lee datos del servidor de forma asincrónica
                    NetworkStream stream = cliente.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string mensaje = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // Puedes procesar el mensaje recibido aquí

                    return mensaje;
                }
                catch (Exception ex)
                {
                    // Manejar excepciones
                    MessageBox.Show("Error al recibir mensaje: " + ex.Message);
                    return string.Empty;
                }
            }

            private void TuOtraFuncion()
            {
                // Implementa otras funciones aquí
                MessageBox.Show("Otra función ejecutándose en el lado del cliente.");
            }

            private void TuFormulario_FormClosing(object sender, FormClosingEventArgs e)
            {
                // Cierra la conexión al servidor al cerrar el formulario
                cliente?.Close();
            }
        }
    }
}
