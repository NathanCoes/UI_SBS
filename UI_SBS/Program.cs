using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //security.Encrypt();
            Application.Run(new SBS());
            
        }
    }

    public class SBS_program
    {
        public static DateTime dateTime = DateTime.UtcNow.Date;
        public static void validateDocs()
        {
            string[] folders = new string[]
            {
                @" C:\Users\Sistemas\AppData\Roaming\SBS",
                @" C:\Users\Sistemas\AppData\Roaming\SBS\logs",
                @" C:\Users\Sistemas\AppData\Roaming\SBS\config",
                @" C:\Users\Sistemas\AppData\Roaming\SBS\config\server",
                @" C:\Users\Sistemas\AppData\Roaming\SBS\config\ftp_server"
            };
            string[] files = new string[]
            {
                @" C:\Users\Sistemas\AppData\Roaming\SBS\config\server\settings.sbs",
                @" C:\Users\Sistemas\AppData\Roaming\SBS\config\ftp_server\settings.sbs"
            };

            try
            {
                string log_file = @" C:\Users\Sistemas\AppData\Roaming\SBS\logs\log_" + dateTime.ToString("ddMMyyyy") + ".txt";
                if (!File.Exists(log_file))
                {
                    using (StreamWriter file = File.AppendText(log_file))
                    {
                        file.WriteLine("[" + DateTime.Now + "] >> File created");
                    }
                }

                foreach (string folder in folders)
                {
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                        SBS_program.log("Carpeta creada >> " + folder);
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
                            SBS_program.log("Carpeta creada >> " + file);
                        }
                    }
                }
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
            string log_file = @" C:\Users\Sistemas\AppData\Roaming\SBS\logs\log_" + dateTime.ToString("ddMMyyyy") + ".txt";
            using (StreamWriter file = File.AppendText(log_file))
            {
                file.WriteLine("[" + DateTime.Now + $"] >> {msg}");
            }
        }
    }
}
