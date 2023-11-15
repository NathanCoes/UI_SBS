using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_SBS;

namespace UI_SBS
{
    public partial class SBS : Form
    {

        public ToolStripMenuItem last_option;
        public GroupBox lastSection;
        public bool admin = false;

        public SBS()
        {
            InitializeComponent();
            ftp_user_input.PasswordChar = '•';
            service_password_input.PasswordChar = '•';
            unlock_password.PasswordChar = '•';
            MenuHomeOption.BackColor= System.Drawing.SystemColors.ControlLight;
            device_name.Text = SBS_program.get_device_name();
            device_ip.Text = Convert.ToString(SBS_program.get_device_ip());
            disk_space.Text = $"{SBS_program.device_disk.get_device_disk_usedSpace()} GB / {SBS_program.device_disk.get_device_disk_totalSpace()} GB";
            disk_letter.Text = SBS_program.driveLetter+":";
            disk_capacity.Maximum = Convert.ToInt32(SBS_program.device_disk.get_device_disk_totalSpace());
            disk_capacity.Value = Convert.ToInt32(SBS_program.device_disk.get_device_disk_usedSpace());

            new ToastContentBuilder()
            .AddArgument("action", "viewConversation")
            .AddArgument("conversationId", 9813)
            .AddText("Andrew sent you a picture")
            .AddText("Check this out, The Enchantments in Washington!")
            .Show();
        }

        public void menuControl(ToolStripMenuItem menuOption, GroupBox sectionGroup)
        {
            if (last_option != null)
            {
                last_option.BackColor = System.Drawing.SystemColors.Control;
                lastSection.Visible = false;
            }
            else
            {
                MenuHomeOption.BackColor = System.Drawing.SystemColors.Control;
                HomeDetailsGroup.Visible = false;
            }

            menuOption.BackColor = System.Drawing.SystemColors.ControlLight;
            sectionGroup.Visible = true;
            last_option = menuOption;
            lastSection = sectionGroup;
        }

        public void unlock()
        {
            if (admin)
            {
                UI_SBS.SBS_program.alert("Log in", "Sessions", "OK", "Asterisk");
                UI_SBS.SBS_program.log($"Se ha iniciado sesión con la cuenta de administrador {UI_SBS.SBS_program.get_sbs_user()}");
                unlock_user.Text = "";
                unlock_password.Text = "";
                unlock_btn.Text = "Lock";
                text_admin.Visible = true;
                ServerSettingsGroup.Enabled = true;
                FTPSettingsGroup.Enabled = true;
                fileSettingsGroup.Enabled = true;
                unlock_panel.Enabled = false;
            }
            else
            {
                UI_SBS.SBS_program.alert("Log out", "Sessions", "OK", "Asterisk");
                UI_SBS.SBS_program.log($"Se ha cerrado sesión con la cuenta de administrador {UI_SBS.SBS_program.get_sbs_user()}");
                unlock_btn.Text = "Unlock";
                text_admin.Visible = false;
                ServerSettingsGroup.Enabled = false;
                FTPSettingsGroup.Enabled = false;
                fileSettingsGroup.Enabled = false;
                unlock_panel.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fileSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuControl(MenuFileOption, fileSettingsGroup);
        }

        private void fTPSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuControl(MenuServerOption, ServerSettingsGroup);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string user = unlock_user.Text;
            string password = UI_SBS.security.Encrypt(unlock_password.Text);
            string msg = "";


            if (user == UI_SBS.SBS_program.get_sbs_user() && password == UI_SBS.SBS_program.get_sbs_password() && admin == false)
            {
                admin = true;
            }
            else if (admin == true)
            {
                admin = false;
            }
            else
            {
                if (user == null)
                {
                    msg += "El campo de Usuario está vacío.\n";
                }
                if (password == null)
                {
                    msg += "El campo de Password está vacío.\n";
                }
                UI_SBS.SBS_program.alert(msg, "Sessions", "OK", "Asterisk");
            }

            if (msg == "")
            {
                unlock();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuControl(MenuHomeOption, HomeDetailsGroup);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void HomeDetailsGroup_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void unlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuControl(MenuDetailsOption, DetailsSettingsGroup);
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void MenuFTPOption_Click(object sender, EventArgs e)
        {
            menuControl(MenuFTPOption, FTPSettingsGroup);
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void device_name_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }
    }
}
