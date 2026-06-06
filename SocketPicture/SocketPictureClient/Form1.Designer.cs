namespace SocketPictureClient
{
    partial class ClientForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtServerIP = new TextBox();
            txtPort = new TextBox();
            btnConnect = new Button();
            btnOpenImage = new Button();
            btnSend = new Button();
            lblStatus = new Label();
            lblIP = new Label();
            lblPort = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            //
            // pictureBox1
            //
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            //
            // lblIP
            //
            lblIP.AutoSize = true;
            lblIP.Location = new Point(490, 15);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(70, 25);
            lblIP.Text = "서버 IP:";
            //
            // txtServerIP
            //
            txtServerIP.Location = new Point(490, 43);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(180, 31);
            txtServerIP.Text = "127.0.0.1";
            //
            // lblPort
            //
            lblPort.AutoSize = true;
            lblPort.Location = new Point(490, 85);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(45, 25);
            lblPort.Text = "포트:";
            //
            // txtPort
            //
            txtPort.Location = new Point(490, 113);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(180, 31);
            txtPort.Text = "5000";
            //
            // btnConnect
            //
            btnConnect.Location = new Point(490, 160);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(180, 40);
            btnConnect.Text = "연결";
            btnConnect.UseVisualStyleBackColor = true;
            //
            // btnOpenImage
            //
            btnOpenImage.Enabled = false;
            btnOpenImage.Location = new Point(490, 215);
            btnOpenImage.Name = "btnOpenImage";
            btnOpenImage.Size = new Size(180, 40);
            btnOpenImage.Text = "이미지 열기";
            btnOpenImage.UseVisualStyleBackColor = true;
            //
            // btnSend
            //
            btnSend.Enabled = false;
            btnSend.Location = new Point(490, 270);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(180, 40);
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = true;
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(490, 330);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(80, 25);
            lblStatus.Text = "연결 안됨";
            //
            // ClientForm
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 380);
            Controls.Add(lblStatus);
            Controls.Add(btnSend);
            Controls.Add(btnOpenImage);
            Controls.Add(btnConnect);
            Controls.Add(txtPort);
            Controls.Add(lblPort);
            Controls.Add(txtServerIP);
            Controls.Add(lblIP);
            Controls.Add(pictureBox1);
            Name = "ClientForm";
            Text = "소켓 이미지 전송 - 클라이언트";
            FormClosing += ClientForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtServerIP;
        private TextBox txtPort;
        private Button btnConnect;
        private Button btnOpenImage;
        private Button btnSend;
        private Label lblStatus;
        private Label lblIP;
        private Label lblPort;
    }
}
