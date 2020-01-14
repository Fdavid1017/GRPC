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
            userPasswordTextBox.PasswordChar = '*';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!InvalidInputs())
            {
                MessageBox.Show("Invalid inputs");
                return;
            }

            User user = new User { Name = userNameTextBox.Text, Passwd = userPasswordTextBox.Text };
            Session_Id guid = new Session_Id();
            this.guid = client.Login(user);

            if (this.guid.Id == "NOT_FOUND")
            {
                MessageBox.Show("No user found with this name and password pair!");
                return;
            }

            MessageBox.Show("Logged in\nSessiond id:\n" + this.guid.Id);
            loggedInLabel.Text = "Logged in";
            loggedInLabel.ForeColor = Color.Green;
            registerGroupBox.Visible = false;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res = client.Logout(this.guid);
            MessageBox.Show(res.Success);
            this.guid = new Session_Id();
            loggedInLabel.Text = "Not logged in";
            loggedInLabel.ForeColor = Color.Red;
            registerGroupBox.Visible = true;
            userNameTextBox.Text = "";
            userPasswordTextBox.Text = "";
        }

        private async void GetAllButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "All Games:\n";
            IAsyncStreamReader<Game> response = client.GetGames(guid).ResponseStream;
            while (await response.MoveNext())
            {
                resultLabel.Text += string.Format("Id: {0}  Name: {1}   Price:{2}\n", response.Current.Gid, response.Current.Name, response.Current.Price);
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!InvalidInputs())
            {
                MessageBox.Show("Invalid inputs");
                return;
            }

            User user = new User { Name = userNameTextBox.Text, Passwd = userPasswordTextBox.Text };
            Result res = new Result();
            res = client.Register(user);
            MessageBox.Show(res.Success);
        }

        bool InvalidInputs()
        {
            return userNameTextBox.Text != "" || userPasswordTextBox.Text != "";
        }
    }
}
