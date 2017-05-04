namespace DeltaSystemTray
{
    partial class Settings
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
            this.connectButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.environmentField = new System.Windows.Forms.TextBox();
            this.environmentLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.loggedInLabel = new System.Windows.Forms.Label();
            this.loggedOutMessage = new System.Windows.Forms.Label();
            this.userLoggedInLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(35, 197);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(32, 94);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(32, 144);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(35, 110);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(215, 20);
            this.usernameField.TabIndex = 3;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(35, 160);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(215, 20);
            this.passwordField.TabIndex = 4;
            // 
            // environmentField
            // 
            this.environmentField.Location = new System.Drawing.Point(35, 58);
            this.environmentField.Margin = new System.Windows.Forms.Padding(2);
            this.environmentField.Name = "environmentField";
            this.environmentField.Size = new System.Drawing.Size(215, 20);
            this.environmentField.TabIndex = 5;
            // 
            // environmentLabel
            // 
            this.environmentLabel.AutoSize = true;
            this.environmentLabel.Location = new System.Drawing.Point(32, 44);
            this.environmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.environmentLabel.Name = "environmentLabel";
            this.environmentLabel.Size = new System.Drawing.Size(136, 13);
            this.environmentLabel.TabIndex = 6;
            this.environmentLabel.Text = "Dynamics 365 Environment";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(595, 420);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 7;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.AutoSize = true;
            this.loggedInLabel.ForeColor = System.Drawing.Color.Green;
            this.loggedInLabel.Location = new System.Drawing.Point(366, 44);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(71, 13);
            this.loggedInLabel.TabIndex = 8;
            this.loggedInLabel.Text = "Logged in as:";
            this.loggedInLabel.Visible = false;
            // 
            // loggedOutMessage
            // 
            this.loggedOutMessage.AutoSize = true;
            this.loggedOutMessage.ForeColor = System.Drawing.Color.Crimson;
            this.loggedOutMessage.Location = new System.Drawing.Point(366, 44);
            this.loggedOutMessage.Name = "loggedOutMessage";
            this.loggedOutMessage.Size = new System.Drawing.Size(63, 13);
            this.loggedOutMessage.TabIndex = 9;
            this.loggedOutMessage.Text = "Logged Out";
            // 
            // userLoggedInLabel
            // 
            this.userLoggedInLabel.AutoSize = true;
            this.userLoggedInLabel.Location = new System.Drawing.Point(443, 44);
            this.userLoggedInLabel.Name = "userLoggedInLabel";
            this.userLoggedInLabel.Size = new System.Drawing.Size(0, 13);
            this.userLoggedInLabel.TabIndex = 10;
            this.userLoggedInLabel.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 455);
            this.Controls.Add(this.userLoggedInLabel);
            this.Controls.Add(this.loggedOutMessage);
            this.Controls.Add(this.loggedInLabel);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.environmentLabel);
            this.Controls.Add(this.environmentField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.connectButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(698, 494);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(698, 494);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox environmentField;
        private System.Windows.Forms.Label environmentLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label loggedInLabel;
        private System.Windows.Forms.Label loggedOutMessage;
        private System.Windows.Forms.Label userLoggedInLabel;
    }
}