namespace PacketClient
{
    partial class PacketClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_ip = new TextBox();
            txt_init = new TextBox();
            txt_login = new TextBox();
            txt_message = new TextBox();
            btn_connect = new Button();
            btn_init = new Button();
            btn_login = new Button();
            btn_message = new Button();
            SuspendLayout();
            // 
            // txt_ip
            // 
            txt_ip.Location = new Point(86, 43);
            txt_ip.Name = "txt_ip";
            txt_ip.Size = new Size(429, 31);
            txt_ip.TabIndex = 0;
            // 
            // txt_init
            // 
            txt_init.Location = new Point(86, 115);
            txt_init.Name = "txt_init";
            txt_init.Size = new Size(429, 31);
            txt_init.TabIndex = 1;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(86, 204);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(429, 31);
            txt_login.TabIndex = 2;
            // 
            // txt_message
            // 
            txt_message.Location = new Point(86, 293);
            txt_message.Name = "txt_message";
            txt_message.Size = new Size(429, 31);
            txt_message.TabIndex = 6;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(592, 41);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(112, 34);
            btn_connect.TabIndex = 3;
            btn_connect.Text = "접속";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_init
            // 
            btn_init.Location = new Point(592, 112);
            btn_init.Name = "btn_init";
            btn_init.Size = new Size(112, 34);
            btn_init.TabIndex = 4;
            btn_init.Text = "init";
            btn_init.UseVisualStyleBackColor = true;
            btn_init.Click += btn_init_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(592, 204);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 34);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_message
            // 
            btn_message.Location = new Point(592, 291);
            btn_message.Name = "btn_message";
            btn_message.Size = new Size(112, 34);
            btn_message.TabIndex = 7;
            btn_message.Text = "Message 전송";
            btn_message.UseVisualStyleBackColor = true;
            btn_message.Click += btn_message_Click;
            // 
            // PacketClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_message);
            Controls.Add(btn_login);
            Controls.Add(btn_init);
            Controls.Add(btn_connect);
            Controls.Add(txt_message);
            Controls.Add(txt_login);
            Controls.Add(txt_init);
            Controls.Add(txt_ip);
            Name = "PacketClient";
            Text = "PacketClient";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ip;
        private TextBox txt_init;
        private TextBox txt_login;
        private TextBox txt_message;
        private Button btn_connect;
        private Button btn_init;
        private Button btn_login;
        private Button btn_message;
    }
}
