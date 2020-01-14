namespace GameLibraryClient
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
            this.getAllButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.addGameButton = new System.Windows.Forms.Button();
            this.gameNameTextBox = new System.Windows.Forms.TextBox();
            this.gamePriceNumericUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteIdNumericUD = new System.Windows.Forms.NumericUpDown();
            this.modifyIdNumericUD = new System.Windows.Forms.NumericUpDown();
            this.button1modifyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modifyPriceNumericUD = new System.Windows.Forms.NumericUpDown();
            this.modifyNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamePriceNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIdNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyIdNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPriceNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(13, 13);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(94, 13);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // getAllButton
            // 
            this.getAllButton.Location = new System.Drawing.Point(12, 42);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(157, 23);
            this.getAllButton.TabIndex = 2;
            this.getAllButton.Text = "Get All Game";
            this.getAllButton.UseVisualStyleBackColor = true;
            this.getAllButton.Click += new System.EventHandler(this.GetAllButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Location = new System.Drawing.Point(510, 13);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(278, 428);
            this.resultLabel.TabIndex = 3;
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(327, 66);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(177, 23);
            this.addGameButton.TabIndex = 4;
            this.addGameButton.Text = "Add Game";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.AddGameButton_Click);
            // 
            // gameNameTextBox
            // 
            this.gameNameTextBox.Location = new System.Drawing.Point(404, 13);
            this.gameNameTextBox.Name = "gameNameTextBox";
            this.gameNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.gameNameTextBox.TabIndex = 5;
            // 
            // gamePriceNumericUD
            // 
            this.gamePriceNumericUD.Location = new System.Drawing.Point(404, 40);
            this.gamePriceNumericUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.gamePriceNumericUD.Name = "gamePriceNumericUD";
            this.gamePriceNumericUD.Size = new System.Drawing.Size(100, 20);
            this.gamePriceNumericUD.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(324, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(324, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Game Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(327, 95);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(71, 20);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // deleteIdNumericUD
            // 
            this.deleteIdNumericUD.Location = new System.Drawing.Point(404, 95);
            this.deleteIdNumericUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.deleteIdNumericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deleteIdNumericUD.Name = "deleteIdNumericUD";
            this.deleteIdNumericUD.Size = new System.Drawing.Size(100, 20);
            this.deleteIdNumericUD.TabIndex = 10;
            this.deleteIdNumericUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // modifyIdNumericUD
            // 
            this.modifyIdNumericUD.Location = new System.Drawing.Point(404, 171);
            this.modifyIdNumericUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.modifyIdNumericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.modifyIdNumericUD.Name = "modifyIdNumericUD";
            this.modifyIdNumericUD.Size = new System.Drawing.Size(100, 20);
            this.modifyIdNumericUD.TabIndex = 12;
            this.modifyIdNumericUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1modifyButton
            // 
            this.button1modifyButton.Location = new System.Drawing.Point(327, 171);
            this.button1modifyButton.Name = "button1modifyButton";
            this.button1modifyButton.Size = new System.Drawing.Size(71, 20);
            this.button1modifyButton.TabIndex = 11;
            this.button1modifyButton.Text = "Modify";
            this.button1modifyButton.UseVisualStyleBackColor = true;
            this.button1modifyButton.Click += new System.EventHandler(this.Button1modifyButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(324, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Game Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(324, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Game Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modifyPriceNumericUD
            // 
            this.modifyPriceNumericUD.Location = new System.Drawing.Point(404, 145);
            this.modifyPriceNumericUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.modifyPriceNumericUD.Name = "modifyPriceNumericUD";
            this.modifyPriceNumericUD.Size = new System.Drawing.Size(100, 20);
            this.modifyPriceNumericUD.TabIndex = 14;
            // 
            // modifyNameTextBox
            // 
            this.modifyNameTextBox.Location = new System.Drawing.Point(404, 121);
            this.modifyNameTextBox.Name = "modifyNameTextBox";
            this.modifyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyNameTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modifyPriceNumericUD);
            this.Controls.Add(this.modifyNameTextBox);
            this.Controls.Add(this.modifyIdNumericUD);
            this.Controls.Add(this.button1modifyButton);
            this.Controls.Add(this.deleteIdNumericUD);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamePriceNumericUD);
            this.Controls.Add(this.gameNameTextBox);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.getAllButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Game Library";
            ((System.ComponentModel.ISupportInitialize)(this.gamePriceNumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIdNumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyIdNumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPriceNumericUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button getAllButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.TextBox gameNameTextBox;
        private System.Windows.Forms.NumericUpDown gamePriceNumericUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.NumericUpDown deleteIdNumericUD;
        private System.Windows.Forms.NumericUpDown modifyIdNumericUD;
        private System.Windows.Forms.Button button1modifyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown modifyPriceNumericUD;
        private System.Windows.Forms.TextBox modifyNameTextBox;
    }
}

