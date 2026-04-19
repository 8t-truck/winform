namespace Project1_timer
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
            components = new System.ComponentModel.Container();
            tmrClock = new System.Windows.Forms.Timer(components);
            lblDisplay = new Label();
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // tmrClock
            // 
            tmrClock.Tick += tmrClock_Tick;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(450, 216);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(22, 25);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "0";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(266, 283);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(504, 283);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(112, 34);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrClock;
        private Label lblDisplay;
        private Button btnStart;
        private Button btnStop;
    }
}
