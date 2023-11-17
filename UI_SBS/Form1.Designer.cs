namespace UI_SBS
{
    partial class SBS_form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SBS_form));
            this.ServerStatus = new System.Windows.Forms.Label();
            this.FTPStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHomeOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFTPOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuServerOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDetailsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerStatusIndicator = new System.Windows.Forms.Label();
            this.FTPStatusIndicator = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_admin = new System.Windows.Forms.Label();
            this.fileSettingsGroup = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.images_check = new System.Windows.Forms.CheckBox();
            this.downloads_check = new System.Windows.Forms.CheckBox();
            this.documents_check = new System.Windows.Forms.CheckBox();
            this.desktop_check = new System.Windows.Forms.CheckBox();
            this.saveFileSettings = new System.Windows.Forms.Button();
            this.unlock_btn = new System.Windows.Forms.Button();
            this.ftp_server_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ftp_port_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ftp_user_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ftp_password_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ftp_test = new System.Windows.Forms.Button();
            this.FTPSettingsGroup = new System.Windows.Forms.GroupBox();
            this.ServerSettingsGroup = new System.Windows.Forms.GroupBox();
            this.server_test = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.service_password_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.service_user_input = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.service_port_input = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.service_server_input = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.device_name = new System.Windows.Forms.Label();
            this.device_ip = new System.Windows.Forms.Label();
            this.session_id = new System.Windows.Forms.Label();
            this.HomeDetailsGroup = new System.Windows.Forms.GroupBox();
            this.disk_space = new System.Windows.Forms.Label();
            this.disk_capacity = new System.Windows.Forms.ProgressBar();
            this.disk_letter = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DetailsSettingsGroup = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.unlock_panel = new System.Windows.Forms.Panel();
            this.unlock_password = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.unlock_user = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.fileSettingsGroup.SuspendLayout();
            this.FTPSettingsGroup.SuspendLayout();
            this.ServerSettingsGroup.SuspendLayout();
            this.HomeDetailsGroup.SuspendLayout();
            this.DetailsSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.unlock_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerStatus
            // 
            resources.ApplyResources(this.ServerStatus, "ServerStatus");
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // FTPStatus
            // 
            resources.ApplyResources(this.FTPStatus, "FTPStatus");
            this.FTPStatus.Name = "FTPStatus";
            this.FTPStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHomeOption,
            this.MenuFileOption,
            this.MenuFTPOption,
            this.MenuServerOption,
            this.MenuDetailsOption});
            this.Menu.Name = "Menu";
            resources.ApplyResources(this.Menu, "Menu");
            // 
            // MenuHomeOption
            // 
            this.MenuHomeOption.BackColor = System.Drawing.SystemColors.Control;
            this.MenuHomeOption.Name = "MenuHomeOption";
            resources.ApplyResources(this.MenuHomeOption, "MenuHomeOption");
            this.MenuHomeOption.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // MenuFileOption
            // 
            this.MenuFileOption.Name = "MenuFileOption";
            resources.ApplyResources(this.MenuFileOption, "MenuFileOption");
            this.MenuFileOption.Click += new System.EventHandler(this.fileSettingsToolStripMenuItem_Click);
            // 
            // MenuFTPOption
            // 
            this.MenuFTPOption.Name = "MenuFTPOption";
            resources.ApplyResources(this.MenuFTPOption, "MenuFTPOption");
            this.MenuFTPOption.Click += new System.EventHandler(this.MenuFTPOption_Click);
            // 
            // MenuServerOption
            // 
            this.MenuServerOption.Name = "MenuServerOption";
            resources.ApplyResources(this.MenuServerOption, "MenuServerOption");
            this.MenuServerOption.Click += new System.EventHandler(this.fTPSettingsToolStripMenuItem_Click);
            // 
            // MenuDetailsOption
            // 
            this.MenuDetailsOption.Name = "MenuDetailsOption";
            resources.ApplyResources(this.MenuDetailsOption, "MenuDetailsOption");
            this.MenuDetailsOption.Click += new System.EventHandler(this.unlockToolStripMenuItem_Click);
            // 
            // ServerStatusIndicator
            // 
            resources.ApplyResources(this.ServerStatusIndicator, "ServerStatusIndicator");
            this.ServerStatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ServerStatusIndicator.ForeColor = System.Drawing.Color.Red;
            this.ServerStatusIndicator.Name = "ServerStatusIndicator";
            this.ServerStatusIndicator.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FTPStatusIndicator
            // 
            resources.ApplyResources(this.FTPStatusIndicator, "FTPStatusIndicator");
            this.FTPStatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FTPStatusIndicator.ForeColor = System.Drawing.Color.Red;
            this.FTPStatusIndicator.Name = "FTPStatusIndicator";
            this.FTPStatusIndicator.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_admin);
            this.panel1.Controls.Add(this.FTPStatusIndicator);
            this.panel1.Controls.Add(this.ServerStatus);
            this.panel1.Controls.Add(this.FTPStatus);
            this.panel1.Controls.Add(this.ServerStatusIndicator);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // text_admin
            // 
            resources.ApplyResources(this.text_admin, "text_admin");
            this.text_admin.BackColor = System.Drawing.Color.Transparent;
            this.text_admin.Name = "text_admin";
            this.text_admin.Click += new System.EventHandler(this.label20_Click);
            // 
            // fileSettingsGroup
            // 
            this.fileSettingsGroup.Controls.Add(this.textBox1);
            this.fileSettingsGroup.Controls.Add(this.images_check);
            this.fileSettingsGroup.Controls.Add(this.downloads_check);
            this.fileSettingsGroup.Controls.Add(this.documents_check);
            this.fileSettingsGroup.Controls.Add(this.desktop_check);
            resources.ApplyResources(this.fileSettingsGroup, "fileSettingsGroup");
            this.fileSettingsGroup.Name = "fileSettingsGroup";
            this.fileSettingsGroup.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // images_check
            // 
            resources.ApplyResources(this.images_check, "images_check");
            this.images_check.Checked = true;
            this.images_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.images_check.Name = "images_check";
            this.images_check.UseVisualStyleBackColor = true;
            // 
            // downloads_check
            // 
            resources.ApplyResources(this.downloads_check, "downloads_check");
            this.downloads_check.Checked = true;
            this.downloads_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.downloads_check.Name = "downloads_check";
            this.downloads_check.UseVisualStyleBackColor = true;
            // 
            // documents_check
            // 
            resources.ApplyResources(this.documents_check, "documents_check");
            this.documents_check.Checked = true;
            this.documents_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.documents_check.Name = "documents_check";
            this.documents_check.UseVisualStyleBackColor = true;
            this.documents_check.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // desktop_check
            // 
            resources.ApplyResources(this.desktop_check, "desktop_check");
            this.desktop_check.Checked = true;
            this.desktop_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.desktop_check.Name = "desktop_check";
            this.desktop_check.UseVisualStyleBackColor = true;
            // 
            // saveFileSettings
            // 
            this.saveFileSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.saveFileSettings, "saveFileSettings");
            this.saveFileSettings.Name = "saveFileSettings";
            this.saveFileSettings.UseVisualStyleBackColor = false;
            this.saveFileSettings.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // unlock_btn
            // 
            resources.ApplyResources(this.unlock_btn, "unlock_btn");
            this.unlock_btn.Name = "unlock_btn";
            this.unlock_btn.UseVisualStyleBackColor = true;
            this.unlock_btn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ftp_server_input
            // 
            resources.ApplyResources(this.ftp_server_input, "ftp_server_input");
            this.ftp_server_input.Name = "ftp_server_input";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // ftp_port_input
            // 
            resources.ApplyResources(this.ftp_port_input, "ftp_port_input");
            this.ftp_port_input.Name = "ftp_port_input";
            this.ftp_port_input.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // ftp_user_input
            // 
            resources.ApplyResources(this.ftp_user_input, "ftp_user_input");
            this.ftp_user_input.Name = "ftp_user_input";
            this.ftp_user_input.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ftp_password_input
            // 
            resources.ApplyResources(this.ftp_password_input, "ftp_password_input");
            this.ftp_password_input.Name = "ftp_password_input";
            this.ftp_password_input.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // ftp_test
            // 
            resources.ApplyResources(this.ftp_test, "ftp_test");
            this.ftp_test.Name = "ftp_test";
            this.ftp_test.UseVisualStyleBackColor = true;
            this.ftp_test.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FTPSettingsGroup
            // 
            this.FTPSettingsGroup.Controls.Add(this.ftp_test);
            this.FTPSettingsGroup.Controls.Add(this.textBox6);
            this.FTPSettingsGroup.Controls.Add(this.label4);
            this.FTPSettingsGroup.Controls.Add(this.ftp_password_input);
            this.FTPSettingsGroup.Controls.Add(this.label3);
            this.FTPSettingsGroup.Controls.Add(this.ftp_user_input);
            this.FTPSettingsGroup.Controls.Add(this.label2);
            this.FTPSettingsGroup.Controls.Add(this.ftp_port_input);
            this.FTPSettingsGroup.Controls.Add(this.label1);
            this.FTPSettingsGroup.Controls.Add(this.ftp_server_input);
            resources.ApplyResources(this.FTPSettingsGroup, "FTPSettingsGroup");
            this.FTPSettingsGroup.Name = "FTPSettingsGroup";
            this.FTPSettingsGroup.TabStop = false;
            // 
            // ServerSettingsGroup
            // 
            this.ServerSettingsGroup.Controls.Add(this.server_test);
            this.ServerSettingsGroup.Controls.Add(this.textBox2);
            this.ServerSettingsGroup.Controls.Add(this.label5);
            this.ServerSettingsGroup.Controls.Add(this.service_password_input);
            this.ServerSettingsGroup.Controls.Add(this.label6);
            this.ServerSettingsGroup.Controls.Add(this.service_user_input);
            this.ServerSettingsGroup.Controls.Add(this.label7);
            this.ServerSettingsGroup.Controls.Add(this.service_port_input);
            this.ServerSettingsGroup.Controls.Add(this.label8);
            this.ServerSettingsGroup.Controls.Add(this.service_server_input);
            resources.ApplyResources(this.ServerSettingsGroup, "ServerSettingsGroup");
            this.ServerSettingsGroup.Name = "ServerSettingsGroup";
            this.ServerSettingsGroup.TabStop = false;
            // 
            // server_test
            // 
            resources.ApplyResources(this.server_test, "server_test");
            this.server_test.Name = "server_test";
            this.server_test.UseVisualStyleBackColor = true;
            this.server_test.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // service_password_input
            // 
            resources.ApplyResources(this.service_password_input, "service_password_input");
            this.service_password_input.Name = "service_password_input";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // service_user_input
            // 
            resources.ApplyResources(this.service_user_input, "service_user_input");
            this.service_user_input.Name = "service_user_input";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // service_port_input
            // 
            resources.ApplyResources(this.service_port_input, "service_port_input");
            this.service_port_input.Name = "service_port_input";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // service_server_input
            // 
            resources.ApplyResources(this.service_server_input, "service_server_input");
            this.service_server_input.Name = "service_server_input";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // device_name
            // 
            resources.ApplyResources(this.device_name, "device_name");
            this.device_name.Name = "device_name";
            this.device_name.Click += new System.EventHandler(this.device_name_Click);
            // 
            // device_ip
            // 
            resources.ApplyResources(this.device_ip, "device_ip");
            this.device_ip.Name = "device_ip";
            this.device_ip.Click += new System.EventHandler(this.label12_Click);
            // 
            // session_id
            // 
            resources.ApplyResources(this.session_id, "session_id");
            this.session_id.Name = "session_id";
            // 
            // HomeDetailsGroup
            // 
            this.HomeDetailsGroup.Controls.Add(this.disk_space);
            this.HomeDetailsGroup.Controls.Add(this.disk_capacity);
            this.HomeDetailsGroup.Controls.Add(this.disk_letter);
            this.HomeDetailsGroup.Controls.Add(this.label12);
            this.HomeDetailsGroup.Controls.Add(this.session_id);
            this.HomeDetailsGroup.Controls.Add(this.device_ip);
            this.HomeDetailsGroup.Controls.Add(this.device_name);
            this.HomeDetailsGroup.Controls.Add(this.label11);
            this.HomeDetailsGroup.Controls.Add(this.label10);
            this.HomeDetailsGroup.Controls.Add(this.label9);
            resources.ApplyResources(this.HomeDetailsGroup, "HomeDetailsGroup");
            this.HomeDetailsGroup.Name = "HomeDetailsGroup";
            this.HomeDetailsGroup.TabStop = false;
            this.HomeDetailsGroup.Enter += new System.EventHandler(this.HomeDetailsGroup_Enter);
            // 
            // disk_space
            // 
            resources.ApplyResources(this.disk_space, "disk_space");
            this.disk_space.Name = "disk_space";
            this.disk_space.Click += new System.EventHandler(this.label14_Click);
            // 
            // disk_capacity
            // 
            resources.ApplyResources(this.disk_capacity, "disk_capacity");
            this.disk_capacity.Maximum = 750;
            this.disk_capacity.Name = "disk_capacity";
            this.disk_capacity.Value = 300;
            // 
            // disk_letter
            // 
            resources.ApplyResources(this.disk_letter, "disk_letter");
            this.disk_letter.Name = "disk_letter";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // DetailsSettingsGroup
            // 
            this.DetailsSettingsGroup.Controls.Add(this.label19);
            this.DetailsSettingsGroup.Controls.Add(this.label18);
            this.DetailsSettingsGroup.Controls.Add(this.label15);
            this.DetailsSettingsGroup.Controls.Add(this.pictureBox1);
            this.DetailsSettingsGroup.Controls.Add(this.unlock_panel);
            this.DetailsSettingsGroup.Controls.Add(this.unlock_btn);
            resources.ApplyResources(this.DetailsSettingsGroup, "DetailsSettingsGroup");
            this.DetailsSettingsGroup.Name = "DetailsSettingsGroup";
            this.DetailsSettingsGroup.TabStop = false;
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // unlock_panel
            // 
            this.unlock_panel.Controls.Add(this.unlock_password);
            this.unlock_panel.Controls.Add(this.label16);
            this.unlock_panel.Controls.Add(this.unlock_user);
            this.unlock_panel.Controls.Add(this.label17);
            resources.ApplyResources(this.unlock_panel, "unlock_panel");
            this.unlock_panel.Name = "unlock_panel";
            // 
            // unlock_password
            // 
            resources.ApplyResources(this.unlock_password, "unlock_password");
            this.unlock_password.Name = "unlock_password";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // unlock_user
            // 
            resources.ApplyResources(this.unlock_user, "unlock_user");
            this.unlock_user.Name = "unlock_user";
            this.unlock_user.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // SBS_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.DetailsSettingsGroup);
            this.Controls.Add(this.HomeDetailsGroup);
            this.Controls.Add(this.ServerSettingsGroup);
            this.Controls.Add(this.fileSettingsGroup);
            this.Controls.Add(this.FTPSettingsGroup);
            this.Controls.Add(this.saveFileSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SBS_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.fileSettingsGroup.ResumeLayout(false);
            this.fileSettingsGroup.PerformLayout();
            this.FTPSettingsGroup.ResumeLayout(false);
            this.FTPSettingsGroup.PerformLayout();
            this.ServerSettingsGroup.ResumeLayout(false);
            this.ServerSettingsGroup.PerformLayout();
            this.HomeDetailsGroup.ResumeLayout(false);
            this.HomeDetailsGroup.PerformLayout();
            this.DetailsSettingsGroup.ResumeLayout(false);
            this.DetailsSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.unlock_panel.ResumeLayout(false);
            this.unlock_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ServerStatus;
        private System.Windows.Forms.Label FTPStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOption;
        private System.Windows.Forms.ToolStripMenuItem MenuFTPOption;
        private System.Windows.Forms.ToolStripMenuItem MenuServerOption;
        private System.Windows.Forms.Label ServerStatusIndicator;
        private System.Windows.Forms.Label FTPStatusIndicator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox fileSettingsGroup;
        private System.Windows.Forms.Button saveFileSettings;
        private System.Windows.Forms.CheckBox images_check;
        private System.Windows.Forms.CheckBox downloads_check;
        private System.Windows.Forms.CheckBox documents_check;
        private System.Windows.Forms.CheckBox desktop_check;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button unlock_btn;
        private System.Windows.Forms.ToolStripMenuItem MenuHomeOption;
        private System.Windows.Forms.TextBox ftp_server_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ftp_port_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ftp_user_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ftp_password_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button ftp_test;
        private System.Windows.Forms.GroupBox FTPSettingsGroup;
        private System.Windows.Forms.GroupBox ServerSettingsGroup;
        private System.Windows.Forms.Button server_test;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox service_password_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox service_user_input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox service_port_input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox service_server_input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label device_name;
        private System.Windows.Forms.Label device_ip;
        private System.Windows.Forms.Label session_id;
        private System.Windows.Forms.GroupBox HomeDetailsGroup;
        private System.Windows.Forms.ProgressBar disk_capacity;
        private System.Windows.Forms.Label disk_letter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label disk_space;
        private System.Windows.Forms.ToolStripMenuItem MenuDetailsOption;
        private System.Windows.Forms.GroupBox DetailsSettingsGroup;
        private System.Windows.Forms.TextBox unlock_password;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox unlock_user;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label text_admin;
        private System.Windows.Forms.Panel unlock_panel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

