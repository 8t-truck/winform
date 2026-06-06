namespace _1to1Chattingprogram
{
    partial class Form1
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
            btn_exit = new Button();
            btn_send = new Button();
            btn_Connect = new Button();
            btn_Server = new Button();
            txt_ServerIp = new TextBox();
            txt_send = new TextBox();
            txt_all = new TextBox();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(523, 317);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(214, 34);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "프로그램 종료";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(523, 368);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(214, 34);
            btn_send.TabIndex = 1;
            btn_send.Text = "보내기";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            btn_send.KeyDown += btn_send_KeyDown;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(523, 121);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(214, 34);
            btn_Connect.TabIndex = 2;
            btn_Connect.Text = "서버 연결";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += button3_Click;
            // 
            // btn_Server
            // 
            btn_Server.Location = new Point(523, 55);
            btn_Server.Name = "btn_Server";
            btn_Server.Size = new Size(214, 34);
            btn_Server.TabIndex = 3;
            btn_Server.Text = "서버 켜기";
            btn_Server.UseVisualStyleBackColor = true;
            btn_Server.Click += btn_Server_Click;
            // 
            // txt_ServerIp
            // 
            txt_ServerIp.Location = new Point(523, 181);
            txt_ServerIp.Name = "txt_ServerIp";
            txt_ServerIp.Size = new Size(214, 31);
            txt_ServerIp.TabIndex = 4;
            txt_ServerIp.Text = "127.0.0.1";
            // 
            // txt_send
            // 
            txt_send.Location = new Point(30, 388);
            txt_send.Name = "txt_send";
            txt_send.Size = new Size(385, 31);
            txt_send.TabIndex = 5;
            // 
            // txt_all
            // 
            txt_all.Location = new Point(30, 25);
            txt_all.Multiline = true;
            txt_all.Name = "txt_all";
            txt_all.Size = new Size(385, 326);
            txt_all.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_all);
            Controls.Add(txt_send);
            Controls.Add(txt_ServerIp);
            Controls.Add(btn_Server);
            Controls.Add(btn_Connect);
            Controls.Add(btn_send);
            Controls.Add(btn_exit);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_exit;
        private Button btn_send;
        private Button btn_Connect;
        private Button btn_Server;
        private TextBox txt_ServerIp;
        private TextBox txt_send;
        private TextBox txt_all;
    }
}
