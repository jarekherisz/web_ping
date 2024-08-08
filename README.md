# WebPing Application

## Overview
WebPing is a Windows Forms application developed in .NET C# designed to monitor the availability of specified websites. The application periodically pings the listed websites and sends notifications via email if a site becomes unavailable.

## Features
- **Website Availability Monitoring:** Periodically pings specified websites.
- **Email Notifications:** Sends notifications via SMTP when a monitored website is unavailable.
- **Configurable Settings:** User-configurable SMTP settings, email addresses, and monitored websites.
- **System Tray Integration:** Minimizes to the system tray with an icon for quick access.

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/WebPing.git
   ```
2. Open the solution file WebPing.sln in Visual Studio.
3. Build the solution to restore NuGet packages and compile the project.

## Usage

1. Launch the application.
2. Click on the Settings button to configure the SMTP and website settings.
3. Fill in the necessary fields:
    - User SMTP: Your SMTP user email address.
    - Password SMTP: Your SMTP password.
    - Host SMTP: SMTP host address (e.g., smtp.poczta.onet.pl).
    - Port SMTP: SMTP port (e.g., 465), and select SSL if required.
    - From Email: The email address from which notifications will be sent.
    - Notifications Email: The email address to receive notifications.
    - Subject Email: Subject line for the notification emails.
    - Monitored pages: List of URLs to monitor.
4. Click Save to apply the settings.
5.Use the Test button to verify SMTP settings.
6. Check the Uruchom checkbox to start monitoring the websites.
