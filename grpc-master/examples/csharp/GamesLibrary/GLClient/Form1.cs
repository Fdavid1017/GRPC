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

namespace GLClient
{
  public partial class Form1 : Form
  {
    static Channel channel = new Channel("127.0.0.1:50052", Credentials.Insecure);
    GamesLibrary.GamesLibraryClient client = GamesLibrary.NewClient(channel);
    Session_Id guid = new Session_Id();

    public Form1()
    {
      InitializeComponent();
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
      client = GamesLibrary.NewClient(channel);
      User user = new User(); user.Name = "u"; user.Passwd = "p";
      Session_Id guid = new Session_Id();
      guid = client.Login(user);
      MessageBox.Show(guid.Id);
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
      Result res = new Result();
      res = client.Logout(guid);
      MessageBox.Show(res.Success);
    }
  }
}
