using FluentFTP;

namespace MordorLauncher
{
    public partial class Form1 : Form
    {
        private FtpClient _client;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string ip = IPBox.Text;
            string host = ip.Split(':')[0];
            string port = ip.Split(':')[1];
            Connect(host, int.Parse(port));
            var a = _client.GetListing("/");
        }

        private void Connect(string host, int port)
        {
            _client = new FtpClient(host, port, null, null);
            _client.AutoConnect();
        }
    }
}