using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace WebPing
{
    public class SettingsData
    {
        private string smtpUser = "";
        private string smtpFrom = "";
        private string subjectEmail = "Server error";
        private int checkIntervalMilliseconds = 300 * 1000;
        private int smtpPort = 587;
        private bool smtpSsl = true;
        private bool autoStart = false;
        private string smtpPassword = "";
        private string smtpHost = "";
        private List<string> notificationEmails = new List<string>();
        private List<string> monitoredPages = new List<string>();

        public string SmtpUser
        {
            get => smtpUser;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("SmtpUser cannot be empty");
                }
                smtpUser = value;
            }
        }

        public string SmtpFrom
        {
            get => smtpFrom;
            set
            {
                try
                {
                    MailAddress m = new MailAddress(value);
                    smtpFrom = value;
                }
                catch (FormatException)
                {
                    throw new ArgumentException("Invalid email format for SmtpFrom");
                }
            }
        }

        public string SubjectEmail
        {
            get => subjectEmail;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("SubjectEmail cannot be empty");
                }
                subjectEmail = value;
            }
        }

        public int CheckIntervalMilliseconds
        {
            get => checkIntervalMilliseconds;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("CheckIntervalMilliseconds must be greater than 0");
                }
                checkIntervalMilliseconds = value;
            }
        }

        public int SmtpPort
        {
            get => smtpPort;
            set
            {
                if (value <= 0 || value > 65535)
                {
                    throw new ArgumentException("SmtpPort must be between 1 and 65535");
                }
                smtpPort = value;
            }
        }

        public string SmtpPortString
        {
            set
            {
                int smtpPortInt;
                if (int.TryParse(value, out smtpPortInt))
                    SmtpPort = smtpPortInt;
                else
                    throw new ArgumentException("Invalid value for SmtpPortString. It must be a valid integer.");
            }
        }

        public bool SmtpSsl
        {
            get => smtpSsl;
            set => smtpSsl = value;
        }

        public bool AutoStart
        {
            get => autoStart;
            set => autoStart = value;
        }

        public string SmtpPassword
        {
            get => smtpPassword;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("SmtpPassword cannot be empty");
                }
                smtpPassword = value;
            }
        }

        public string SmtpHost
        {
            get => smtpHost;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("SmtpHost cannot be empty");
                }
                smtpHost = value;
            }
        }

        public List<string> NotificationEmails
        {
            get => notificationEmails;
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("NotificationEmails cannot be empty");
                }

                foreach (var email in value)
                {

                    try
                    {
                        MailAddress m = new MailAddress(email);
                    }
                    catch (FormatException)
                    {
                        throw new ArgumentException("Invalid email format for: "+ email);
                    }
                }

                notificationEmails = value;
            }
        }

        public List<string> MonitoredPages
        {
            get => monitoredPages;
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("MonitoredPages cannot be empty");
                }

                foreach (var page in value)
                    if(!IsValidHttpOrHttpsUrl(page))                   
                        throw new ArgumentException("Invalid url format for: "+page);

                monitoredPages = value;
            }
        }

        public static bool IsValidHttpOrHttpsUrl(string url)
        {
            if (url == null)
                return false;

            if (Uri.TryCreate(url, UriKind.Absolute, out Uri? uriResult))
                return uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps;

            return false;
        }

        public static bool IsHttpOrHttps(string url)
        {
            return url.StartsWith("http://") || url.StartsWith("https://");
        }

    }
}
