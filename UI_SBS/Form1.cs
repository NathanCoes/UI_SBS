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

        public SBS()
        {
            InitializeComponent();
            ftp_user_input.PasswordChar = '•';
            service_password_input.PasswordChar = '•';
            MenuHomeOption.BackColor= System.Drawing.SystemColors.ControlLight;
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
    }
}
