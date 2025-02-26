namespace WindowsFormsApp1
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
            this.SendButton = new System.Windows.Forms.Button();
            this.SendPrivateButton = new System.Windows.Forms.Button();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.PrivateUserTextBox = new System.Windows.Forms.TextBox();
            this.PrivateMessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(53, 429);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(243, 429);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendPrivateButton
            // 
            this.SendPrivateButton.Location = new System.Drawing.Point(463, 429);
            this.SendPrivateButton.Name = "SendPrivateButton";
            this.SendPrivateButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SendPrivateButton.Size = new System.Drawing.Size(108, 23);
            this.SendPrivateButton.TabIndex = 2;
            this.SendPrivateButton.Text = "Send Private";
            this.SendPrivateButton.UseVisualStyleBackColor = true;
            this.SendPrivateButton.Click += new System.EventHandler(this.SendPrivateButton_Click);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(53, 61);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Size = new System.Drawing.Size(518, 108);
            this.ChatTextBox.TabIndex = 3;
            this.ChatTextBox.Text = "chat";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(53, 33);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(518, 22);
            this.UsernameTextBox.TabIndex = 4;
            this.UsernameTextBox.Text = "user";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(53, 175);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(518, 22);
            this.MessageTextBox.TabIndex = 5;
            this.MessageTextBox.Text = "message";
            // 
            // PrivateUserTextBox
            // 
            this.PrivateUserTextBox.Location = new System.Drawing.Point(53, 227);
            this.PrivateUserTextBox.Multiline = true;
            this.PrivateUserTextBox.Name = "PrivateUserTextBox";
            this.PrivateUserTextBox.Size = new System.Drawing.Size(518, 22);
            this.PrivateUserTextBox.TabIndex = 6;
            this.PrivateUserTextBox.Text = "privateuser";
            // 
            // PrivateMessageTextBox
            // 
            this.PrivateMessageTextBox.Location = new System.Drawing.Point(53, 302);
            this.PrivateMessageTextBox.Multiline = true;
            this.PrivateMessageTextBox.Name = "PrivateMessageTextBox";
            this.PrivateMessageTextBox.Size = new System.Drawing.Size(518, 83);
            this.PrivateMessageTextBox.TabIndex = 7;
            this.PrivateMessageTextBox.Text = "private message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 585);
            this.Controls.Add(this.PrivateMessageTextBox);
            this.Controls.Add(this.PrivateUserTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.SendPrivateButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button SendPrivateButton;
        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox PrivateUserTextBox;
        private System.Windows.Forms.TextBox PrivateMessageTextBox;
    }
}

