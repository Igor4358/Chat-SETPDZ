namespace Chat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.CreateRoomButton = new System.Windows.Forms.Button();
            this.JoinRoomButton = new System.Windows.Forms.Button();
            this.SendRoomMessageButton = new System.Windows.Forms.Button();
            this.AdminLoginButton = new System.Windows.Forms.Button();
            this.BanUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.AdminNotificationsTextBox = new System.Windows.Forms.TextBox();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.RoomNameTextBox = new System.Windows.Forms.TextBox();
            this.RoomMessageTextBox = new System.Windows.Forms.TextBox();
            this.AdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.BanUsernameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteUsernameTextBox = new System.Windows.Forms.TextBox();
            this.BanMinutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.BanMinutesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 398);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // CreateRoomButton
            // 
            this.CreateRoomButton.Location = new System.Drawing.Point(114, 398);
            this.CreateRoomButton.Name = "CreateRoomButton";
            this.CreateRoomButton.Size = new System.Drawing.Size(75, 40);
            this.CreateRoomButton.TabIndex = 1;
            this.CreateRoomButton.Text = "Create Room";
            this.CreateRoomButton.UseVisualStyleBackColor = true;
            this.CreateRoomButton.Click += new System.EventHandler(this.CreateRoomButton_Click);
            // 
            // JoinRoomButton
            // 
            this.JoinRoomButton.Location = new System.Drawing.Point(222, 398);
            this.JoinRoomButton.Name = "JoinRoomButton";
            this.JoinRoomButton.Size = new System.Drawing.Size(75, 40);
            this.JoinRoomButton.TabIndex = 2;
            this.JoinRoomButton.Text = "Join Room";
            this.JoinRoomButton.UseVisualStyleBackColor = true;
            this.JoinRoomButton.Click += new System.EventHandler(this.JoinRoomButton_Click);
            // 
            // SendRoomMessageButton
            // 
            this.SendRoomMessageButton.Location = new System.Drawing.Point(329, 398);
            this.SendRoomMessageButton.Name = "SendRoomMessageButton";
            this.SendRoomMessageButton.Size = new System.Drawing.Size(75, 59);
            this.SendRoomMessageButton.TabIndex = 3;
            this.SendRoomMessageButton.Text = "Send Room Message";
            this.SendRoomMessageButton.UseVisualStyleBackColor = true;
            this.SendRoomMessageButton.Click += new System.EventHandler(this.SendRoomMessageButton_Click);
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.Location = new System.Drawing.Point(463, 398);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(75, 59);
            this.AdminLoginButton.TabIndex = 4;
            this.AdminLoginButton.Text = "Admin Login";
            this.AdminLoginButton.UseVisualStyleBackColor = true;
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click);
            // 
            // BanUserButton
            // 
            this.BanUserButton.Location = new System.Drawing.Point(592, 398);
            this.BanUserButton.Name = "BanUserButton";
            this.BanUserButton.Size = new System.Drawing.Size(75, 23);
            this.BanUserButton.TabIndex = 5;
            this.BanUserButton.Text = "Ban User";
            this.BanUserButton.UseVisualStyleBackColor = true;
            this.BanUserButton.Click += new System.EventHandler(this.BanUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(712, 397);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteUserButton.TabIndex = 6;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(23, 24);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(238, 22);
            this.UsernameTextBox.TabIndex = 7;
            this.UsernameTextBox.Text = "User Name";
            // 
            // AdminNotificationsTextBox
            // 
            this.AdminNotificationsTextBox.Location = new System.Drawing.Point(23, 52);
            this.AdminNotificationsTextBox.Multiline = true;
            this.AdminNotificationsTextBox.Name = "AdminNotificationsTextBox";
            this.AdminNotificationsTextBox.Size = new System.Drawing.Size(238, 22);
            this.AdminNotificationsTextBox.TabIndex = 8;
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(23, 92);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Size = new System.Drawing.Size(691, 83);
            this.ChatTextBox.TabIndex = 9;
            this.ChatTextBox.Text = "Chat";
            // 
            // RoomNameTextBox
            // 
            this.RoomNameTextBox.Location = new System.Drawing.Point(23, 216);
            this.RoomNameTextBox.Name = "RoomNameTextBox";
            this.RoomNameTextBox.Size = new System.Drawing.Size(319, 22);
            this.RoomNameTextBox.TabIndex = 10;
            this.RoomNameTextBox.Text = "Room name";
            // 
            // RoomMessageTextBox
            // 
            this.RoomMessageTextBox.Location = new System.Drawing.Point(23, 244);
            this.RoomMessageTextBox.Multiline = true;
            this.RoomMessageTextBox.Name = "RoomMessageTextBox";
            this.RoomMessageTextBox.Size = new System.Drawing.Size(381, 65);
            this.RoomMessageTextBox.TabIndex = 11;
            this.RoomMessageTextBox.Text = "Room Message";
            // 
            // AdminPasswordTextBox
            // 
            this.AdminPasswordTextBox.Location = new System.Drawing.Point(385, 24);
            this.AdminPasswordTextBox.Name = "AdminPasswordTextBox";
            this.AdminPasswordTextBox.Size = new System.Drawing.Size(295, 22);
            this.AdminPasswordTextBox.TabIndex = 12;
            this.AdminPasswordTextBox.Text = "Admin Password <admin123";
            // 
            // BanUsernameTextBox
            // 
            this.BanUsernameTextBox.Location = new System.Drawing.Point(463, 216);
            this.BanUsernameTextBox.Name = "BanUsernameTextBox";
            this.BanUsernameTextBox.Size = new System.Drawing.Size(329, 22);
            this.BanUsernameTextBox.TabIndex = 13;
            this.BanUsernameTextBox.Text = "Ban User";
            // 
            // DeleteUsernameTextBox
            // 
            this.DeleteUsernameTextBox.Location = new System.Drawing.Point(463, 315);
            this.DeleteUsernameTextBox.Name = "DeleteUsernameTextBox";
            this.DeleteUsernameTextBox.Size = new System.Drawing.Size(340, 22);
            this.DeleteUsernameTextBox.TabIndex = 14;
            this.DeleteUsernameTextBox.Text = "Delete User";
            // 
            // BanMinutesNumericUpDown
            // 
            this.BanMinutesNumericUpDown.Location = new System.Drawing.Point(463, 268);
            this.BanMinutesNumericUpDown.Name = "BanMinutesNumericUpDown";
            this.BanMinutesNumericUpDown.Size = new System.Drawing.Size(167, 22);
            this.BanMinutesNumericUpDown.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 547);
            this.Controls.Add(this.BanMinutesNumericUpDown);
            this.Controls.Add(this.DeleteUsernameTextBox);
            this.Controls.Add(this.BanUsernameTextBox);
            this.Controls.Add(this.AdminPasswordTextBox);
            this.Controls.Add(this.RoomMessageTextBox);
            this.Controls.Add(this.RoomNameTextBox);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.AdminNotificationsTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.BanUserButton);
            this.Controls.Add(this.AdminLoginButton);
            this.Controls.Add(this.SendRoomMessageButton);
            this.Controls.Add(this.JoinRoomButton);
            this.Controls.Add(this.CreateRoomButton);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BanMinutesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button CreateRoomButton;
        private System.Windows.Forms.Button JoinRoomButton;
        private System.Windows.Forms.Button SendRoomMessageButton;
        private System.Windows.Forms.Button AdminLoginButton;
        private System.Windows.Forms.Button BanUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox AdminNotificationsTextBox;
        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.TextBox RoomNameTextBox;
        private System.Windows.Forms.TextBox RoomMessageTextBox;
        private System.Windows.Forms.TextBox AdminPasswordTextBox;
        private System.Windows.Forms.TextBox BanUsernameTextBox;
        private System.Windows.Forms.TextBox DeleteUsernameTextBox;
        private System.Windows.Forms.NumericUpDown BanMinutesNumericUpDown;
    }
}

