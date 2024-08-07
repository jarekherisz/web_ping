namespace WebPing
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSMTPUser = new System.Windows.Forms.TextBox();
            this.labelSMTPUser = new System.Windows.Forms.Label();
            this.textBoxSMTPPass = new System.Windows.Forms.TextBox();
            this.labelSMTPPass = new System.Windows.Forms.Label();
            this.labelSMTPHost = new System.Windows.Forms.Label();
            this.textBoxSMTPHost = new System.Windows.Forms.TextBox();
            this.labelNotificationsEmail = new System.Windows.Forms.Label();
            this.textBoxNotificationsEmail = new System.Windows.Forms.TextBox();
            this.textBoxMonitoredPages = new System.Windows.Forms.TextBox();
            this.labelMonitoredPages = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSMTPFrom = new System.Windows.Forms.TextBox();
            this.labelSMTPFrom = new System.Windows.Forms.Label();
            this.labelSMTPPort = new System.Windows.Forms.Label();
            this.textBoxSMTPPort = new System.Windows.Forms.TextBox();
            this.checkBoxSMTPSSL = new System.Windows.Forms.CheckBox();
            this.labelSubjectEmail = new System.Windows.Forms.Label();
            this.textBoxSubjectEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSMTPUser
            // 
            this.textBoxSMTPUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSMTPUser.Location = new System.Drawing.Point(14, 27);
            this.textBoxSMTPUser.Name = "textBoxSMTPUser";
            this.textBoxSMTPUser.Size = new System.Drawing.Size(348, 23);
            this.textBoxSMTPUser.TabIndex = 5;
            // 
            // labelSMTPUser
            // 
            this.labelSMTPUser.AutoSize = true;
            this.labelSMTPUser.Location = new System.Drawing.Point(12, 9);
            this.labelSMTPUser.Name = "labelSMTPUser";
            this.labelSMTPUser.Size = new System.Drawing.Size(63, 15);
            this.labelSMTPUser.TabIndex = 4;
            this.labelSMTPUser.Text = "User SMTP";
            // 
            // textBoxSMTPPass
            // 
            this.textBoxSMTPPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSMTPPass.Location = new System.Drawing.Point(12, 71);
            this.textBoxSMTPPass.Name = "textBoxSMTPPass";
            this.textBoxSMTPPass.Size = new System.Drawing.Size(348, 23);
            this.textBoxSMTPPass.TabIndex = 6;
            // 
            // labelSMTPPass
            // 
            this.labelSMTPPass.AutoSize = true;
            this.labelSMTPPass.Location = new System.Drawing.Point(12, 53);
            this.labelSMTPPass.Name = "labelSMTPPass";
            this.labelSMTPPass.Size = new System.Drawing.Size(90, 15);
            this.labelSMTPPass.TabIndex = 7;
            this.labelSMTPPass.Text = "Password SMTP";
            // 
            // labelSMTPHost
            // 
            this.labelSMTPHost.AutoSize = true;
            this.labelSMTPHost.Location = new System.Drawing.Point(12, 97);
            this.labelSMTPHost.Name = "labelSMTPHost";
            this.labelSMTPHost.Size = new System.Drawing.Size(65, 15);
            this.labelSMTPHost.TabIndex = 9;
            this.labelSMTPHost.Text = "Host SMTP";
            // 
            // textBoxSMTPHost
            // 
            this.textBoxSMTPHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSMTPHost.Location = new System.Drawing.Point(12, 115);
            this.textBoxSMTPHost.Name = "textBoxSMTPHost";
            this.textBoxSMTPHost.Size = new System.Drawing.Size(348, 23);
            this.textBoxSMTPHost.TabIndex = 8;
            // 
            // labelNotificationsEmail
            // 
            this.labelNotificationsEmail.AutoSize = true;
            this.labelNotificationsEmail.Location = new System.Drawing.Point(14, 229);
            this.labelNotificationsEmail.Name = "labelNotificationsEmail";
            this.labelNotificationsEmail.Size = new System.Drawing.Size(107, 15);
            this.labelNotificationsEmail.TabIndex = 10;
            this.labelNotificationsEmail.Text = "Notifications Email";
            // 
            // textBoxNotificationsEmail
            // 
            this.textBoxNotificationsEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNotificationsEmail.Location = new System.Drawing.Point(14, 247);
            this.textBoxNotificationsEmail.Name = "textBoxNotificationsEmail";
            this.textBoxNotificationsEmail.Size = new System.Drawing.Size(348, 23);
            this.textBoxNotificationsEmail.TabIndex = 11;
            // 
            // textBoxMonitoredPages
            // 
            this.textBoxMonitoredPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMonitoredPages.Location = new System.Drawing.Point(12, 335);
            this.textBoxMonitoredPages.Multiline = true;
            this.textBoxMonitoredPages.Name = "textBoxMonitoredPages";
            this.textBoxMonitoredPages.Size = new System.Drawing.Size(348, 240);
            this.textBoxMonitoredPages.TabIndex = 13;
            // 
            // labelMonitoredPages
            // 
            this.labelMonitoredPages.AutoSize = true;
            this.labelMonitoredPages.Location = new System.Drawing.Point(14, 317);
            this.labelMonitoredPages.Name = "labelMonitoredPages";
            this.labelMonitoredPages.Size = new System.Drawing.Size(97, 15);
            this.labelMonitoredPages.TabIndex = 12;
            this.labelMonitoredPages.Text = "Monitored pages";
            this.labelMonitoredPages.Click += new System.EventHandler(this.labelMonitoredPages_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(12, 581);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSMTPFrom
            // 
            this.textBoxSMTPFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSMTPFrom.Location = new System.Drawing.Point(14, 203);
            this.textBoxSMTPFrom.Name = "textBoxSMTPFrom";
            this.textBoxSMTPFrom.Size = new System.Drawing.Size(348, 23);
            this.textBoxSMTPFrom.TabIndex = 16;
            // 
            // labelSMTPFrom
            // 
            this.labelSMTPFrom.AutoSize = true;
            this.labelSMTPFrom.Location = new System.Drawing.Point(14, 185);
            this.labelSMTPFrom.Name = "labelSMTPFrom";
            this.labelSMTPFrom.Size = new System.Drawing.Size(70, 15);
            this.labelSMTPFrom.TabIndex = 17;
            this.labelSMTPFrom.Text = "From  Email";
            // 
            // labelSMTPPort
            // 
            this.labelSMTPPort.AutoSize = true;
            this.labelSMTPPort.Location = new System.Drawing.Point(14, 141);
            this.labelSMTPPort.Name = "labelSMTPPort";
            this.labelSMTPPort.Size = new System.Drawing.Size(62, 15);
            this.labelSMTPPort.TabIndex = 18;
            this.labelSMTPPort.Text = "Port SMTP";
            // 
            // textBoxSMTPPort
            // 
            this.textBoxSMTPPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSMTPPort.Location = new System.Drawing.Point(12, 159);
            this.textBoxSMTPPort.Name = "textBoxSMTPPort";
            this.textBoxSMTPPort.Size = new System.Drawing.Size(298, 23);
            this.textBoxSMTPPort.TabIndex = 19;
            // 
            // checkBoxSMTPSSL
            // 
            this.checkBoxSMTPSSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSMTPSSL.AutoSize = true;
            this.checkBoxSMTPSSL.Location = new System.Drawing.Point(318, 163);
            this.checkBoxSMTPSSL.Name = "checkBoxSMTPSSL";
            this.checkBoxSMTPSSL.Size = new System.Drawing.Size(44, 19);
            this.checkBoxSMTPSSL.TabIndex = 20;
            this.checkBoxSMTPSSL.Text = "SSL";
            this.checkBoxSMTPSSL.UseVisualStyleBackColor = true;
            // 
            // labelSubjectEmail
            // 
            this.labelSubjectEmail.AutoSize = true;
            this.labelSubjectEmail.Location = new System.Drawing.Point(14, 273);
            this.labelSubjectEmail.Name = "labelSubjectEmail";
            this.labelSubjectEmail.Size = new System.Drawing.Size(78, 15);
            this.labelSubjectEmail.TabIndex = 21;
            this.labelSubjectEmail.Text = "Subject Email";
            // 
            // textBoxSubjectEmail
            // 
            this.textBoxSubjectEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubjectEmail.Location = new System.Drawing.Point(14, 291);
            this.textBoxSubjectEmail.Name = "textBoxSubjectEmail";
            this.textBoxSubjectEmail.Size = new System.Drawing.Size(348, 23);
            this.textBoxSubjectEmail.TabIndex = 22;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 616);
            this.Controls.Add(this.textBoxSubjectEmail);
            this.Controls.Add(this.labelSubjectEmail);
            this.Controls.Add(this.checkBoxSMTPSSL);
            this.Controls.Add(this.textBoxSMTPPort);
            this.Controls.Add(this.labelSMTPPort);
            this.Controls.Add(this.labelSMTPFrom);
            this.Controls.Add(this.textBoxSMTPFrom);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxMonitoredPages);
            this.Controls.Add(this.labelMonitoredPages);
            this.Controls.Add(this.textBoxNotificationsEmail);
            this.Controls.Add(this.labelNotificationsEmail);
            this.Controls.Add(this.labelSMTPHost);
            this.Controls.Add(this.textBoxSMTPHost);
            this.Controls.Add(this.labelSMTPPass);
            this.Controls.Add(this.textBoxSMTPPass);
            this.Controls.Add(this.textBoxSMTPUser);
            this.Controls.Add(this.labelSMTPUser);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelSMTPUser;
        private Label labelSMTPPass;
        private Label labelSMTPHost;
        private Label labelNotificationsEmail;
        private Label labelMonitoredPages;
        public TextBox textBoxSMTPUser;
        public TextBox textBoxSMTPPass;
        public TextBox textBoxSMTPHost;
        public TextBox textBoxNotificationsEmail;
        public TextBox textBoxMonitoredPages;
        private Button buttonSave;
        public TextBox textBoxSMTPFrom;
        private Label labelSMTPFrom;
        private Label labelSMTPPort;
        public TextBox textBoxSMTPPort;
        private CheckBox checkBoxSMTPSSL;
        private Label labelSubjectEmail;
        public TextBox textBoxSubjectEmail;
    }
}