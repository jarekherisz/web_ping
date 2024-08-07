using System.Net;
using System.Text.Json;
using MailKit.Net.Smtp;
using MimeKit;

namespace WebPing
{
    public partial class WebPing : Form
    {
        protected string SettingsPath;

        SettingsData SettingsData = new SettingsData();

        Dictionary<string, int> UrlResponseCounter = new Dictionary<string, int>();


        public WebPing()
        {
            SettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WebPingSettings.json");
            SettingsLoadFromFile();

            InitializeComponent();
            notifyIcon1.Text = "WebPing";

            timer1.Interval = SettingsData.CheckIntervalMilliseconds;

            if (SettingsData.AutoStart)
            {
                checkBoxAutoStart.Checked = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        // Metoda do zapisywania do pliku JSON
        public void SettingsSaveToFile()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // Dla lepszej czytelnoœci zapisanego pliku JSON
            };
            string jsonString = JsonSerializer.Serialize(SettingsData, options);
            File.WriteAllText(SettingsPath, jsonString);
        }

        // Metoda do wczytywania z pliku JSON
        public void SettingsLoadFromFile()
        {
            if (File.Exists(SettingsPath))
            {
                string jsonString = File.ReadAllText(SettingsPath);
                var loadedSettings = JsonSerializer.Deserialize<SettingsData>(jsonString);
                if (loadedSettings != null)
                {
                    SettingsData = loadedSettings;
                }
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            
            SettingsForm settingsForm = new SettingsForm(SettingsData);
            SettingsData =  settingsForm.ShowDialog();
            SettingsSaveToFile();

        }

        private void checkBoxAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAutoStart.Checked)
            {
                timer1.Start();
            }else
            {
                timer1.Stop();
            }

            SettingsData.AutoStart = checkBoxAutoStart.Checked;
            SettingsSaveToFile();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            string errorMessage = "";

            foreach( string url in SettingsData.MonitoredPages)
            {
                if (!UrlResponseCounter.ContainsKey(url))
                    UrlResponseCounter[url] = 0;

                var (statusCode, responseTime) = await CheckUrlResponseTimeAsync(url);
                if (statusCode == HttpStatusCode.OK)
                {
                    UrlResponseCounter[url] = 0;
                    AddLineLog($"URL {url} responded in {responseTime.TotalMilliseconds} ms");
                }
                else
                {
                    string errorLine = $"URL {url} failed status code: " + statusCode.ToString();
                    AddLineLog(UrlResponseCounter[url].ToString() + " - " + errorLine);
                    if (UrlResponseCounter[url]++ > 4 || sender is Button)
                    {
                        errorMessage += errorLine;
                        UrlResponseCounter[url] = 0;
                    }
                }
            }

            if(errorMessage!="")
            {
                SendEmail(errorMessage);
            }
        }

        private void AddLineLog(String line)
        {
            // Pobierz wszystkie linie z textBoxLogs
            var lines = textBoxLogs.Lines.ToList();

            // Dodaj now¹ liniê na pocz¹tek listy
            lines.Insert(0, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + line);

            // Jeœli liczba linii przekracza 100, usuñ ostatni¹ liniê
            if (lines.Count > 20)
            {
                lines.RemoveAt(lines.Count - 1);
            }

            // Ustaw zaktualizowane linie z powrotem do textBoxLogs
            textBoxLogs.Lines = lines.ToArray();
        }

        public static async Task<(HttpStatusCode statusCode, TimeSpan responseTime)> CheckUrlResponseTimeAsync(string url)
        {
            try
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(url);
                    stopwatch.Stop();
                    return (response.StatusCode, stopwatch.Elapsed);
                }
            }
            catch
            {
                return (HttpStatusCode.BadGateway, TimeSpan.Zero);
            }
        }

        private void SendEmail(string body)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Sender", SettingsData.SmtpFrom));

                foreach (var email in SettingsData.NotificationEmails)
                    message.To.Add(new MailboxAddress("Recipient", email));

                message.Subject = SettingsData.SubjectEmail;
                message.Body = new TextPart("plain")
                {
                    Text = body
                };

                using (var client = new SmtpClient())
                {
                    client.Connect(SettingsData.SmtpHost, SettingsData.SmtpPort, SettingsData.SmtpSsl);

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate(SettingsData.SmtpUser, SettingsData.SmtpPassword);

                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d podczas wysy³ania e-maila: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxAutoStart.Checked = false;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
    }
}