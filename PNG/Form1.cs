using System.Net.NetworkInformation;
using PNG.Properties;

namespace PNG;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void SaveEmailAddress(string Text)
    {
        Settings.Default.IP = txtIP.Text;
        Settings.Default.Save();
    }

    private void btnPing_Click(object sender, EventArgs e)
    {
        var serverAddress = txtIP.Text;
        if (!string.IsNullOrEmpty(serverAddress))
            PingServer(serverAddress);
        SaveEmailAddress(txtIP.Text);
    }

    private async void PingServer(string serverAddress)
    {
        for (var i = 0; i < 900000; i++)
        {
            var ping = new Ping();
            var reply = await ping.SendPingAsync(serverAddress);

            if (reply.Status == IPStatus.Success)
                resultTextBox.AppendText($"Server Reply {serverAddress}. Time: {reply.RoundtripTime}ms" +
                                         Environment.NewLine);
            else
                resultTextBox.AppendText($"Server out {serverAddress}. Error: {reply.Status}" + Environment.NewLine);
        }
    }

    private void btnEmail_Click(object sender, EventArgs e)
    {
        var frm = new FRM_EMail();
        frm.ShowDialog();
    }
}