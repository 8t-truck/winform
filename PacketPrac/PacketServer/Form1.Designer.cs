namespace PacketServer
{
    partial class PacketServer
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
            txt_server_state = new TextBox();
            SuspendLayout();
            // 
            // txt_server_state
            // 
            txt_server_state.Dock = DockStyle.Fill;
            txt_server_state.Location = new Point(0, 0);
            txt_server_state.Multiline = true;
            txt_server_state.Name = "txt_server_state";
            txt_server_state.Size = new Size(800, 450);
            txt_server_state.TabIndex = 0;
            // 
            // PacketServer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_server_state);
            Name = "PacketServer";
            Text = "PacketServer";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_server_state;
    }
}
