using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.Toolkit.Uwp.Notifications;


namespace UI_SBS
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SBS_program.validateDocs();
            Application.Run(new SBS());
            
        }
    }

    public class SBS_program
    {
        public static string driveLetter = "C";
        public static string sbs_user = "SBS_Admin";
        public static string sbs_password = "bBiFDclTkxZZutWaDDkwfQ=="; // SBS2023!
        public static string base_folder = $@" {driveLetter}:\Users\{SBS_program.get_device_username()}\AppData\Roaming";

        public static DateTime dateTime = DateTime.UtcNow.Date;        
        public static DriveInfo driveInfo = new DriveInfo(driveLetter);

        public static void validateDocs()
        {
            string[] folders = new string[]
            {
                $@" {base_folder}\SBS",
                $@" {base_folder}\SBS\logs",
                $@" {base_folder}\SBS\config",
                $@" {base_folder}\SBS\config\server",
                $@" {base_folder}\SBS\config\ftp_server"
            };
            string[] files = new string[]
            {
                $@" {base_folder}\SBS\config\server\settings.sbs",
                $@" {base_folder}\SBS\config\ftp_server\settings.sbs"
            };

            string temp = "";

            try
            {
                foreach (string folder in folders)
                {
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                        temp += $"Carpeta creada >> {folder}\n";
                    }
                }

                foreach (string s_file in files)
                {
                    if (!File.Exists(s_file))
                    {
                        using (StreamWriter file = File.AppendText(s_file))
                        {
                            //file.WriteLine("Archivo creardo " + DateTime.Now);
                            file.WriteLine("Server:");
                            file.WriteLine("Port:");
                            file.WriteLine("User:");
                            file.WriteLine("Password:");
                            file.Close();
                            temp += $"Archivo creado >> {s_file}\n";
                        }
                    }
                }

                SBS_program.log(temp);
            }
            catch (Exception ex)
            {
                UI_SBS.SBS_program.alert(ex.Message, "[File System] Oops!", "OK", "Asterisk");
                SBS_program.log("Carpeta creada >> " + ex.Message);
            }
        }

        public static void alert(string msg, string caption, string button, string msgicon)
        {
            MessageBoxButtons btn;
            MessageBoxIcon icon;
            switch (button)
            {
                case "OK":
                    btn = MessageBoxButtons.OK;
                    break;
                case "OKCancel":
                    btn = MessageBoxButtons.OKCancel;
                    break;
                case "YesNo":
                    btn = MessageBoxButtons.YesNo;
                    break;
                default:
                    btn = MessageBoxButtons.OK;
                    break;
            }

            switch (msgicon)
            {
                case "Warning":
                    icon = MessageBoxIcon.Warning;
                    break;
                case "Error":
                    icon = MessageBoxIcon.Error;
                    break;
                case "Asterisk":
                    icon = MessageBoxIcon.Asterisk;
                    break;
                default:
                    icon = MessageBoxIcon.Exclamation;
                    break;
            }

            DialogResult result;
            result = MessageBox.Show(msg, caption, btn, icon);
            //if (result == DialogResult.Yes)
            //if (result == DialogResult.No)
            //if (result == DialogResult.Cancel)
            //if (result == System.Windows.Forms.DialogResult.OK)

        }

        public static void log(string msg)
        {
            string log_file = $@" {base_folder}\SBS\logs\log_" + dateTime.ToString("ddMMyyyy") + ".txt";
            using (StreamWriter file = File.AppendText(log_file))
            {
                file.WriteLine("[" + DateTime.Now + $"] >> {msg}");
            }
        }

        public static string get_sbs_user()
        {
            return sbs_user;
        }

        public static string get_sbs_password()
        {
            return sbs_password;
        }

        public static string get_device_name()
        {
            return Environment.MachineName;
        }

        public static string get_device_username()
        {
            return Environment.UserName;
        }

        public static IPAddress get_device_ip()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface interfaz in interfaces)
            {
                if (interfaz.OperationalStatus == OperationalStatus.Up && !interfaz.Description.ToLowerInvariant().Contains("loopback"))
                {
                    UnicastIPAddressInformationCollection direccionesIP = interfaz.GetIPProperties().UnicastAddresses;

                    foreach (UnicastIPAddressInformation direccion in direccionesIP)
                    {
                        // Filtrar las direcciones IPv4
                        if (direccion.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            return direccion.Address;
                        }
                    }

                    return null;
                }
            }

            return null;
        }

        public class device_disk
        {
            public static double get_device_disk_usedSpace()
            {
                if (driveInfo.IsReady)
                {
                    long usedSpaceInBytes = driveInfo.TotalSize - driveInfo.AvailableFreeSpace;
                    double usedSpaceInGB = ConvertBytesToGB(usedSpaceInBytes);
                    return usedSpaceInGB;
                }
                else
                {
                    UI_SBS.SBS_program.alert($"La unidad {driveLetter} no está disponible.", "[Disk Device] Problem with the disk!", "OK", "Asterisk");
                    return 0;
                }
            }

            public static double get_device_disk_totalSpace()
            {
                if (driveInfo.IsReady)
                {
                    long totalSpaceInBytes = driveInfo.TotalSize;

                    double totalSpaceInGB = ConvertBytesToGB(totalSpaceInBytes);

                    return totalSpaceInGB;
                }
                else
                {
                    return 0;
                }
            }
        }

        static double ConvertBytesToGB(long bytes)
        {
            return Math.Round(bytes / (1024.0 * 1024.0 * 1024.0), 2);
        }

        static void notification(string titulo, string contenido)
        {
            // Crear la notificación Toast
            ToastContentBuilder contentBuilder = new ToastContentBuilder()
                .AddText(titulo)
                .AddText(contenido);

            // Mostrar la notificación Toast
            ToastNotificationManagerCompat.CreateToastNotifier().Show(contentBuilder.GetToastContent());
        }
    }
}
