using System.Net.NetworkInformation;

namespace PingServers;

public partial class FRm_Ping : Form
{
    public FRm_Ping()
    {
        InitializeComponent();
    }

    private void btnPing_Click(object sender, EventArgs e)
    {
        var serverAddress = txtIP.Text;
        if (!string.IsNullOrEmpty(serverAddress)) PingServer(serverAddress);
    }

    private void PingServer(string serverAddress)
    {
        var ping = new Ping();
        var reply = ping.Send(serverAddress);

        if (reply.Status == IPStatus.Success)
            resultTextBox.Text = $"Server Replay {serverAddress}. Time: {reply.RoundtripTime}ms";
        else
            resultTextBox.Text = $"Server out {serverAddress}. Error: {reply.Status}";
    }
}