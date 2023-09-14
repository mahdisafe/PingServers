using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using PNG.Properties;

namespace PNG;

public partial class FRM_EMail : Form
{
    public FRM_EMail()
    {
        InitializeComponent();
    }

    private void btnPing_Click(object sender, EventArgs e)
    {
        var emailDomain = txtEmailAddress.Text;
        SaveEmailAddress(txtEmailAddress.Text);
        var ipAddress = GetEmailServerIpAddress(emailDomain);

        if (!string.IsNullOrEmpty(ipAddress))
            resultTextBox.Text = $"The IP address of the email server for {emailDomain} is: {ipAddress}";
        else
            resultTextBox.Text = $"Failed to retrieve the IP address of the email server for {emailDomain}";
    }


    private void SaveEmailAddress(string Email)
    {
        Settings.Default.EmailAddress = txtEmailAddress.Text;
        Settings.Default.Save();
    }

    private string GetEmailServerIpAddress(string emailDomain)
    {
        try
        {
            var address = new MailAddress(emailDomain);
            var domain = address.Host;

            var hostEntry = Dns.GetHostEntry(domain);
            var addresses = hostEntry.AddressList;

            var ipAddress = addresses.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
            if (ipAddress != null)
                return ipAddress.ToString();
            throw new Exception("No IP address found for the email server.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while retrieving the IP address: {ex.Message}", "Error");
            return null;
        }
    }
}