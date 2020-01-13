namespace GLClient
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.loginButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.getAllGamesButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(12, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(93, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // getAllGamesButton
            // 
            this.getAllGamesButton.Location = new System.Drawing.Point(13, 42);
            this.getAllGamesButton.Name = "getAllGamesButton";
            this.getAllGamesButton.Size = new System.Drawing.Size(155, 23);
            this.getAllGamesButton.TabIndex = 2;
            this.getAllGamesButton.Text = "Get All Game";
            this.getAllGamesButton.UseVisualStyleBackColor = true;
            this.getAllGamesButton.Click += new System.EventHandler(this.GetAllGamesButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Location = new System.Drawing.Point(524, 9);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(264, 432);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.getAllGamesButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button loginButton;
    private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button getAllGamesButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

