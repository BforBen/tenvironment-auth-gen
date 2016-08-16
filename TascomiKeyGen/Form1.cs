using System;
using System.Windows.Forms;

namespace TascomiKeyGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(PublicKey.Text + PrivateKey.Text))
            {
                var ApiClient = new APIClient(PublicKey.Text, PrivateKey.Text);
                Token.Text = ApiClient.GetToken();
                StatusLabel.Text = "This token is valid until " + ApiClient.Generated.ToShortTimeString();
            }
        }
    }
}
