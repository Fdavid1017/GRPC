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
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modifyGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addVisualButton = new System.Windows.Forms.Button();
            this.deleteVisualizeButton = new System.Windows.Forms.Button();
            this.modifyVisualizeButton = new System.Windows.Forms.Button();
            this.loggedInLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamePriceNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIdNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyIdNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPriceNumericUD)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.deleteGroupBox.SuspendLayout();
            this.modifyGroupBox.SuspendLayout();
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
            this.getAllButton.Location = new System.Drawing.Point(13, 42);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(156, 23);
            this.getAllButton.TabIndex = 2;
            this.getAllButton.Text = "Get All Game";
            this.getAllButton.UseVisualStyleBackColor = true;
            this.getAllButton.Click += new System.EventHandler(this.GetAllButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(382, 13);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(406, 308);
            this.resultLabel.TabIndex = 3;
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(9, 69);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(177, 23);
            this.addGameButton.TabIndex = 4;
            this.addGameButton.Text = "Add Game";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.AddGameButton_Click);
            // 
            // gameNameTextBox
            // 
            this.gameNameTextBox.Location = new System.Drawing.Point(86, 17);
            this.gameNameTextBox.Name = "gameNameTextBox";
            this.gameNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.gameNameTextBox.TabIndex = 5;
            // 
            // gamePriceNumericUD
            // 
            this.gamePriceNumericUD.Location = new System.Drawing.Point(86, 43);
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
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Game Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 45);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(177, 20);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // deleteIdNumericUD
            // 
            this.deleteIdNumericUD.Location = new System.Drawing.Point(83, 19);
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
            this.modifyIdNumericUD.Location = new System.Drawing.Point(86, 67);
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
            this.button1modifyButton.Location = new System.Drawing.Point(9, 93);
            this.button1modifyButton.Name = "button1modifyButton";
            this.button1modifyButton.Size = new System.Drawing.Size(177, 20);
            this.button1modifyButton.TabIndex = 11;
            this.button1modifyButton.Text = "Modify";
            this.button1modifyButton.UseVisualStyleBackColor = true;
            this.button1modifyButton.Click += new System.EventHandler(this.Button1modifyButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Game Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Game Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modifyPriceNumericUD
            // 
            this.modifyPriceNumericUD.Location = new System.Drawing.Point(86, 41);
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
            this.modifyNameTextBox.Location = new System.Drawing.Point(86, 17);
            this.modifyNameTextBox.Name = "modifyNameTextBox";
            this.modifyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyNameTextBox.TabIndex = 13;
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.label1);
            this.addGroupBox.Controls.Add(this.gameNameTextBox);
            this.addGroupBox.Controls.Add(this.label2);
            this.addGroupBox.Controls.Add(this.gamePriceNumericUD);
            this.addGroupBox.Controls.Add(this.addGameButton);
            this.addGroupBox.Location = new System.Drawing.Point(175, 13);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(201, 100);
            this.addGroupBox.TabIndex = 17;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add Game";
            this.addGroupBox.Visible = false;
            // 
            // deleteGroupBox
            // 
            this.deleteGroupBox.Controls.Add(this.label5);
            this.deleteGroupBox.Controls.Add(this.deleteButton);
            this.deleteGroupBox.Controls.Add(this.deleteIdNumericUD);
            this.deleteGroupBox.Location = new System.Drawing.Point(175, 119);
            this.deleteGroupBox.Name = "deleteGroupBox";
            this.deleteGroupBox.Size = new System.Drawing.Size(201, 74);
            this.deleteGroupBox.TabIndex = 18;
            this.deleteGroupBox.TabStop = false;
            this.deleteGroupBox.Text = "Delete Game";
            this.deleteGroupBox.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modifyGroupBox
            // 
            this.modifyGroupBox.Controls.Add(this.label6);
            this.modifyGroupBox.Controls.Add(this.label4);
            this.modifyGroupBox.Controls.Add(this.button1modifyButton);
            this.modifyGroupBox.Controls.Add(this.modifyIdNumericUD);
            this.modifyGroupBox.Controls.Add(this.label3);
            this.modifyGroupBox.Controls.Add(this.modifyNameTextBox);
            this.modifyGroupBox.Controls.Add(this.modifyPriceNumericUD);
            this.modifyGroupBox.Location = new System.Drawing.Point(175, 199);
            this.modifyGroupBox.Name = "modifyGroupBox";
            this.modifyGroupBox.Size = new System.Drawing.Size(201, 122);
            this.modifyGroupBox.TabIndex = 19;
            this.modifyGroupBox.TabStop = false;
            this.modifyGroupBox.Text = "Modify Game";
            this.modifyGroupBox.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addVisualButton
            // 
            this.addVisualButton.Location = new System.Drawing.Point(13, 72);
            this.addVisualButton.Name = "addVisualButton";
            this.addVisualButton.Size = new System.Drawing.Size(156, 23);
            this.addVisualButton.TabIndex = 20;
            this.addVisualButton.Text = "Add Game";
            this.addVisualButton.UseVisualStyleBackColor = true;
            this.addVisualButton.Click += new System.EventHandler(this.AddVisualButton_Click);
            // 
            // deleteVisualizeButton
            // 
            this.deleteVisualizeButton.Location = new System.Drawing.Point(13, 101);
            this.deleteVisualizeButton.Name = "deleteVisualizeButton";
            this.deleteVisualizeButton.Size = new System.Drawing.Size(156, 23);
            this.deleteVisualizeButton.TabIndex = 21;
            this.deleteVisualizeButton.Text = "Delete Game";
            this.deleteVisualizeButton.UseVisualStyleBackColor = true;
            this.deleteVisualizeButton.Click += new System.EventHandler(this.DeleteVisualizeButton_Click);
            // 
            // modifyVisualizeButton
            // 
            this.modifyVisualizeButton.Location = new System.Drawing.Point(13, 130);
            this.modifyVisualizeButton.Name = "modifyVisualizeButton";
            this.modifyVisualizeButton.Size = new System.Drawing.Size(156, 23);
            this.modifyVisualizeButton.TabIndex = 22;
            this.modifyVisualizeButton.Text = "Modify Game";
            this.modifyVisualizeButton.UseVisualStyleBackColor = true;
            this.modifyVisualizeButton.Click += new System.EventHandler(this.ModifyVisualizeButton_Click);
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loggedInLabel.ForeColor = System.Drawing.Color.Red;
            this.loggedInLabel.Location = new System.Drawing.Point(10, 292);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(159, 29);
            this.loggedInLabel.TabIndex = 23;
            this.loggedInLabel.Text = "Not logged in";
            this.loggedInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.loggedInLabel);
            this.Controls.Add(this.modifyVisualizeButton);
            this.Controls.Add(this.deleteVisualizeButton);
            this.Controls.Add(this.addVisualButton);
            this.Controls.Add(this.modifyGroupBox);
            this.Controls.Add(this.deleteGroupBox);
            this.Controls.Add(this.addGroupBox);
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
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.deleteGroupBox.ResumeLayout(false);
            this.modifyGroupBox.ResumeLayout(false);
            this.modifyGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.GroupBox deleteGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox modifyGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addVisualButton;
        private System.Windows.Forms.Button deleteVisualizeButton;
        private System.Windows.Forms.Button modifyVisualizeButton;
        private System.Windows.Forms.Label loggedInLabel;
    }
}

