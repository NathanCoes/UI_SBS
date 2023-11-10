namespace UI_SBS
{
    partial class SBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SBS));
            this.ServerStatus = new System.Windows.Forms.Label();
            this.FTPStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFTPOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuServerOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerStatusIndicator = new System.Windows.Forms.Label();
            this.FTPStatusIndicator = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileSettingsGroup = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.images_check = new System.Windows.Forms.CheckBox();
            this.downloads_check = new System.Windows.Forms.CheckBox();
            this.documents_check = new System.Windows.Forms.CheckBox();
            this.desktop_check = new System.Windows.Forms.CheckBox();
            this.saveFileSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FTPSettingsGroup = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ftp_password_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ftp_user_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ftp_port_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ftp_server_input = new System.Windows.Forms.TextBox();
            this.ftp_test = new System.Windows.Forms.Button();
            this.ServerSettingsGroup = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.service_port_input = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.service_server_input = new System.Windows.Forms.TextBox();
            this.service_password_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.service_user_input = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.fileSettingsGroup.SuspendLayout();
            this.FTPSettingsGroup.SuspendLayout();
            this.ServerSettingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerStatus
            // 
            this.ServerStatus.AutoSize = true;
            this.ServerStatus.Location = new System.Drawing.Point(3, 11);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ServerStatus.Size = new System.Drawing.Size(72, 13);
            this.ServerStatus.TabIndex = 1;
            this.ServerStatus.Text = "Server status:";
            this.ServerStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // FTPStatus
            // 
            this.FTPStatus.AutoSize = true;
            this.FTPStatus.Location = new System.Drawing.Point(109, 11);
            this.FTPStatus.Name = "FTPStatus";
            this.FTPStatus.Size = new System.Drawing.Size(61, 13);
            this.FTPStatus.TabIndex = 4;
            this.FTPStatus.Text = "FTP status:";
            this.FTPStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileOption,
            this.MenuFTPOption,
            this.MenuServerOption});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(61, 20);
            this.Menu.Text = "Options";
            // 
            // MenuFileOption
            // 
            this.MenuFileOption.Name = "MenuFileOption";
            this.MenuFileOption.Size = new System.Drawing.Size(180, 22);
            this.MenuFileOption.Text = "File settings";
            this.MenuFileOption.Click += new System.EventHandler(this.fileSettingsToolStripMenuItem_Click);
            // 
            // MenuFTPOption
            // 
            this.MenuFTPOption.Name = "MenuFTPOption";
            this.MenuFTPOption.Size = new System.Drawing.Size(180, 22);
            this.MenuFTPOption.Text = "FTP settings";
            // 
            // MenuServerOption
            // 
            this.MenuServerOption.Name = "MenuServerOption";
            this.MenuServerOption.Size = new System.Drawing.Size(180, 22);
            this.MenuServerOption.Text = "Server settings";
            this.MenuServerOption.Click += new System.EventHandler(this.fTPSettingsToolStripMenuItem_Click);
            // 
            // ServerStatusIndicator
            // 
            this.ServerStatusIndicator.AutoSize = true;
            this.ServerStatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ServerStatusIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerStatusIndicator.ForeColor = System.Drawing.Color.Red;
            this.ServerStatusIndicator.Location = new System.Drawing.Point(75, 11);
            this.ServerStatusIndicator.Name = "ServerStatusIndicator";
            this.ServerStatusIndicator.Size = new System.Drawing.Size(26, 15);
            this.ServerStatusIndicator.TabIndex = 6;
            this.ServerStatusIndicator.Text = "Off";
            this.ServerStatusIndicator.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FTPStatusIndicator
            // 
            this.FTPStatusIndicator.AutoSize = true;
            this.FTPStatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FTPStatusIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTPStatusIndicator.ForeColor = System.Drawing.Color.Red;
            this.FTPStatusIndicator.Location = new System.Drawing.Point(169, 11);
            this.FTPStatusIndicator.Name = "FTPStatusIndicator";
            this.FTPStatusIndicator.Size = new System.Drawing.Size(26, 15);
            this.FTPStatusIndicator.TabIndex = 7;
            this.FTPStatusIndicator.Text = "Off";
            this.FTPStatusIndicator.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FTPStatusIndicator);
            this.panel1.Controls.Add(this.ServerStatus);
            this.panel1.Controls.Add(this.FTPStatus);
            this.panel1.Controls.Add(this.ServerStatusIndicator);
            this.panel1.Location = new System.Drawing.Point(12, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 34);
            this.panel1.TabIndex = 10;
            // 
            // fileSettingsGroup
            // 
            this.fileSettingsGroup.Controls.Add(this.textBox1);
            this.fileSettingsGroup.Controls.Add(this.images_check);
            this.fileSettingsGroup.Controls.Add(this.downloads_check);
            this.fileSettingsGroup.Controls.Add(this.documents_check);
            this.fileSettingsGroup.Controls.Add(this.desktop_check);
            this.fileSettingsGroup.Enabled = false;
            this.fileSettingsGroup.Location = new System.Drawing.Point(12, 27);
            this.fileSettingsGroup.Name = "fileSettingsGroup";
            this.fileSettingsGroup.Size = new System.Drawing.Size(361, 118);
            this.fileSettingsGroup.TabIndex = 11;
            this.fileSettingsGroup.TabStop = false;
            this.fileSettingsGroup.Text = "File Settings";
            this.fileSettingsGroup.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(222, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 56);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Select the folders you want to back up automatically.";
            // 
            // images_check
            // 
            this.images_check.AutoSize = true;
            this.images_check.Checked = true;
            this.images_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.images_check.Location = new System.Drawing.Point(6, 88);
            this.images_check.Name = "images_check";
            this.images_check.Size = new System.Drawing.Size(60, 17);
            this.images_check.TabIndex = 3;
            this.images_check.Text = "Images";
            this.images_check.UseVisualStyleBackColor = true;
            // 
            // downloads_check
            // 
            this.downloads_check.AutoSize = true;
            this.downloads_check.Checked = true;
            this.downloads_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.downloads_check.Location = new System.Drawing.Point(6, 65);
            this.downloads_check.Name = "downloads_check";
            this.downloads_check.Size = new System.Drawing.Size(79, 17);
            this.downloads_check.TabIndex = 2;
            this.downloads_check.Text = "Downloads";
            this.downloads_check.UseVisualStyleBackColor = true;
            // 
            // documents_check
            // 
            this.documents_check.AutoSize = true;
            this.documents_check.Checked = true;
            this.documents_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.documents_check.Location = new System.Drawing.Point(6, 42);
            this.documents_check.Name = "documents_check";
            this.documents_check.Size = new System.Drawing.Size(80, 17);
            this.documents_check.TabIndex = 1;
            this.documents_check.Text = "Documents";
            this.documents_check.UseVisualStyleBackColor = true;
            this.documents_check.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // desktop_check
            // 
            this.desktop_check.AutoSize = true;
            this.desktop_check.Checked = true;
            this.desktop_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.desktop_check.Location = new System.Drawing.Point(6, 19);
            this.desktop_check.Name = "desktop_check";
            this.desktop_check.Size = new System.Drawing.Size(66, 17);
            this.desktop_check.TabIndex = 0;
            this.desktop_check.Text = "Desktop";
            this.desktop_check.UseVisualStyleBackColor = true;
            // 
            // saveFileSettings
            // 
            this.saveFileSettings.Location = new System.Drawing.Point(298, 157);
            this.saveFileSettings.Name = "saveFileSettings";
            this.saveFileSettings.Size = new System.Drawing.Size(75, 23);
            this.saveFileSettings.TabIndex = 8;
            this.saveFileSettings.Text = "Save";
            this.saveFileSettings.UseVisualStyleBackColor = true;
            this.saveFileSettings.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Unlock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
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
            this.FTPSettingsGroup.Location = new System.Drawing.Point(12, 27);
            this.FTPSettingsGroup.Name = "FTPSettingsGroup";
            this.FTPSettingsGroup.Size = new System.Drawing.Size(361, 118);
            this.FTPSettingsGroup.TabIndex = 12;
            this.FTPSettingsGroup.TabStop = false;
            this.FTPSettingsGroup.Text = "FTP Settings";
            this.FTPSettingsGroup.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(222, 23);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(133, 56);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Set FTP configuration to transport the files.";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ftp_password_input
            // 
            this.ftp_password_input.Location = new System.Drawing.Point(62, 90);
            this.ftp_password_input.Name = "ftp_password_input";
            this.ftp_password_input.Size = new System.Drawing.Size(100, 20);
            this.ftp_password_input.TabIndex = 6;
            this.ftp_password_input.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ftp_user_input
            // 
            this.ftp_user_input.Location = new System.Drawing.Point(62, 68);
            this.ftp_user_input.Name = "ftp_user_input";
            this.ftp_user_input.Size = new System.Drawing.Size(100, 20);
            this.ftp_user_input.TabIndex = 4;
            this.ftp_user_input.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // ftp_port_input
            // 
            this.ftp_port_input.Location = new System.Drawing.Point(62, 46);
            this.ftp_port_input.Name = "ftp_port_input";
            this.ftp_port_input.Size = new System.Drawing.Size(100, 20);
            this.ftp_port_input.TabIndex = 2;
            this.ftp_port_input.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // ftp_server_input
            // 
            this.ftp_server_input.Location = new System.Drawing.Point(62, 23);
            this.ftp_server_input.Name = "ftp_server_input";
            this.ftp_server_input.Size = new System.Drawing.Size(100, 20);
            this.ftp_server_input.TabIndex = 0;
            // 
            // ftp_test
            // 
            this.ftp_test.Location = new System.Drawing.Point(222, 87);
            this.ftp_test.Name = "ftp_test";
            this.ftp_test.Size = new System.Drawing.Size(75, 23);
            this.ftp_test.TabIndex = 9;
            this.ftp_test.Text = "Test enlace";
            this.ftp_test.UseVisualStyleBackColor = true;
            this.ftp_test.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ServerSettingsGroup
            // 
            this.ServerSettingsGroup.Controls.Add(this.textBox2);
            this.ServerSettingsGroup.Controls.Add(this.label5);
            this.ServerSettingsGroup.Controls.Add(this.service_password_input);
            this.ServerSettingsGroup.Controls.Add(this.label6);
            this.ServerSettingsGroup.Controls.Add(this.service_user_input);
            this.ServerSettingsGroup.Controls.Add(this.label7);
            this.ServerSettingsGroup.Controls.Add(this.service_port_input);
            this.ServerSettingsGroup.Controls.Add(this.label8);
            this.ServerSettingsGroup.Controls.Add(this.service_server_input);
            this.ServerSettingsGroup.Enabled = false;
            this.ServerSettingsGroup.Location = new System.Drawing.Point(12, 27);
            this.ServerSettingsGroup.Name = "ServerSettingsGroup";
            this.ServerSettingsGroup.Size = new System.Drawing.Size(361, 118);
            this.ServerSettingsGroup.TabIndex = 13;
            this.ServerSettingsGroup.TabStop = false;
            this.ServerSettingsGroup.Text = "Server Settings";
            this.ServerSettingsGroup.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(222, 23);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 56);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Set server information to connect with service controller.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // service_port_input
            // 
            this.service_port_input.Location = new System.Drawing.Point(62, 46);
            this.service_port_input.Name = "service_port_input";
            this.service_port_input.Size = new System.Drawing.Size(100, 20);
            this.service_port_input.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Server";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // service_server_input
            // 
            this.service_server_input.Location = new System.Drawing.Point(62, 23);
            this.service_server_input.Name = "service_server_input";
            this.service_server_input.Size = new System.Drawing.Size(100, 20);
            this.service_server_input.TabIndex = 0;
            // 
            // service_password_input
            // 
            this.service_password_input.Location = new System.Drawing.Point(62, 90);
            this.service_password_input.Name = "service_password_input";
            this.service_password_input.Size = new System.Drawing.Size(100, 20);
            this.service_password_input.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // service_user_input
            // 
            this.service_user_input.Location = new System.Drawing.Point(62, 68);
            this.service_user_input.Name = "service_user_input";
            this.service_user_input.Size = new System.Drawing.Size(100, 20);
            this.service_user_input.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "User";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 187);
            this.Controls.Add(this.ServerSettingsGroup);
            this.Controls.Add(this.FTPSettingsGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveFileSettings);
            this.Controls.Add(this.fileSettingsGroup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SBS";
            this.Text = "System Backup Service";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox FTPSettingsGroup;
        private System.Windows.Forms.TextBox ftp_server_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ftp_user_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ftp_port_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ftp_password_input;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button ftp_test;
        private System.Windows.Forms.GroupBox ServerSettingsGroup;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox service_password_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox service_user_input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox service_port_input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox service_server_input;
    }
}

