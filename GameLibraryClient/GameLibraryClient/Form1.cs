using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Core;
using GamesN;

namespace GameLibraryClient
{
    public partial class Form1 : Form
    {
        static Channel channel = new Channel("127.0.0.1:1234", ChannelCredentials.Insecure);
        GamesLibrary.GamesLibraryClient client = new GamesLibrary.GamesLibraryClient(channel);
        Session_Id guid;

        public Form1()
        {
            InitializeComponent();
            guid = new Session_Id();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = new User(); user.Name = "u"; user.Passwd = "p";
            Session_Id guid = new Session_Id();
            guid = client.Login(user);
            MessageBox.Show("Logged in\nSessiond id:\n" + guid.Id);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res = client.Logout(guid);
            MessageBox.Show(res.Success);
        }

        private async void GetAllButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "All Games:";
            IAsyncStreamReader<Game> response = client.GetGames(guid).ResponseStream;
            while (await response.MoveNext(System.Threading.CancellationToken.None))
            {
                resultLabel.Text += response.Current.ToString();
            }
        }
    }
}
