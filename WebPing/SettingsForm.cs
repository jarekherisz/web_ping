using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPing
{
    public partial class SettingsForm : Form
    {
        SettingsData SettingsData;

        public SettingsForm(SettingsData settingsData)
        {
            SettingsData = settingsData;

            InitializeComponent();

            textBoxSMTPUser.Text = SettingsData.SmtpUser;
            textBoxSMTPPass.Text = SettingsData.SmtpPassword;
            textBoxSMTPHost.Text = SettingsData.SmtpHost;
            textBoxSMTPFrom.Text = SettingsData.SmtpFrom;
            textBoxSMTPPort.Text = SettingsData.SmtpPort.ToString();
            checkBoxSMTPSSL.Checked = SettingsData.SmtpSsl;
            textBoxSubjectEmail.Text = SettingsData.SubjectEmail;

            textBoxNotificationsEmail.Text = string.Join("; ", settingsData.NotificationEmails);
            textBoxMonitoredPages.Text = String.Join(Environment.NewLine, settingsData.MonitoredPages);
        }

        public new SettingsData ShowDialog()
        {
            DialogResult dialogResult = base.ShowDialog();
            return SettingsData;
        }

        public Boolean UpdateSettings()
        {
            Boolean error = false;
            if (!AssignWithCatch(() => SettingsData.SmtpUser = textBoxSMTPUser.Text)) error = true;
            if (!AssignWithCatch(() => SettingsData.SubjectEmail = textBoxSubjectEmail.Text)) error = true;
            if (!AssignWithCatch(() => SettingsData.SmtpPassword = textBoxSMTPPass.Text)) error = true;
            if (!AssignWithCatch(() => SettingsData.SmtpHost = textBoxSMTPHost.Text)) error = true;
            if (!AssignWithCatch(() => SettingsData.SmtpFrom = textBoxSMTPFrom.Text)) error = true;
            if (!AssignWithCatch(() => SettingsData.SmtpPortString = textBoxSMTPPort.Text)) error = true;
            if (!AssignWithCatch(() => SettingsData.SmtpSsl = checkBoxSMTPSSL.Checked)) error = true;
            if (!AssignWithCatch(() => SettingsData.NotificationEmails = textBoxNotificationsEmail.Text
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(email => email.Trim())
                .ToList())) error = true;
            if (!AssignWithCatch(() => SettingsData.MonitoredPages = textBoxMonitoredPages.Text
                .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                .Select(page => page.Trim())
                .ToList())) error = true;

            return !error;

        }

        Boolean AssignWithCatch(Action assignAction)
        {
            try
            {
                assignAction();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (UpdateSettings())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void labelMonitoredPages_Click(object sender, EventArgs e)
        {

        }
    }
}
