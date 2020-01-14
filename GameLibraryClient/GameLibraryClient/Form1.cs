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
        Session_Id guid = new Session_Id();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = new User(); user.Name = "u"; user.Passwd = "p";
            Session_Id guid = new Session_Id();
            this.guid = client.Login(user);
            MessageBox.Show("Logged in\nSessiond id:\n" + this.guid.Id);
            loggedInLabel.Text = "Logged in";
            loggedInLabel.ForeColor = Color.Green;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res = client.Logout(this.guid);
            MessageBox.Show(res.Success);
            this.guid = new Session_Id();
            loggedInLabel.Text = "Not logged in";
            loggedInLabel.ForeColor = Color.Red;
        }

        private async void GetAllButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "All Games:\n";
            IAsyncStreamReader<Game> response = client.GetGames(guid).ResponseStream;
            while (await response.MoveNext())
            {
                resultLabel.Text += response.Current.ToString() + "\n";
            }
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res = client.AddGame(new GameUID { Uid = guid.Id, Name = gameNameTextBox.Text, Price = (int)gamePriceNumericUD.Value });
            MessageBox.Show(res.Success);
            addGroupBox.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res = client.DeleteGame(new GameID { Gid = (int)deleteIdNumericUD.Value, Id = guid.Id });
            MessageBox.Show(res.Success);
            deleteGroupBox.Visible = false;
        }

        private void Button1modifyButton_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res = client.ModifyGame(new GameIdUid { Gid = (int)modifyIdNumericUD.Value, Name = modifyNameTextBox.Text, Price = (int)modifyPriceNumericUD.Value, Uid = guid.Id });
            MessageBox.Show(res.Success);
            modifyGroupBox.Visible = false;
        }

        private void AddVisualButton_Click(object sender, EventArgs e)
        {
            addGroupBox.Visible = true;
        }

        private void DeleteVisualizeButton_Click(object sender, EventArgs e)
        {
            deleteGroupBox.Visible = true;
        }

        private void ModifyVisualizeButton_Click(object sender, EventArgs e)
        {
            modifyGroupBox.Visible = true;
        }
    }
}
