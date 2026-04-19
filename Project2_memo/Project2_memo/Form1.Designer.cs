namespace Project2_memo
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
            txtNotepad = new TextBox();
            mns = new MenuStrip();
            파일ToolStripMenuItem = new ToolStripMenuItem();
            tsmiNew = new ToolStripMenuItem();
            tsmiOpen = new ToolStripMenuItem();
            tsmiSave = new ToolStripMenuItem();
            tsmiSaveAs = new ToolStripMenuItem();
            끝내기ToolStripMenuItem = new ToolStripMenuItem();
            편집ToolStripMenuItem = new ToolStripMenuItem();
            실행취소ToolStripMenuItem = new ToolStripMenuItem();
            잘라내기ToolStripMenuItem = new ToolStripMenuItem();
            복사ToolStripMenuItem = new ToolStripMenuItem();
            붙여넣기ToolStripMenuItem = new ToolStripMenuItem();
            삭제ToolStripMenuItem = new ToolStripMenuItem();
            모두선택ToolStripMenuItem = new ToolStripMenuItem();
            서식ToolStripMenuItem = new ToolStripMenuItem();
            자동줄바꿈ToolStripMenuItem = new ToolStripMenuItem();
            글꼴ToolStripMenuItem = new ToolStripMenuItem();
            글자색바꾸기ToolStripMenuItem = new ToolStripMenuItem();
            바탕색바꾸기ToolStripMenuItem = new ToolStripMenuItem();
            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();
            fnd = new FontDialog();
            cld = new ColorDialog();
            mns.SuspendLayout();
            SuspendLayout();
            // 
            // txtNotepad
            // 
            txtNotepad.Dock = DockStyle.Fill;
            txtNotepad.Location = new Point(0, 33);
            txtNotepad.Multiline = true;
            txtNotepad.Name = "txtNotepad";
            txtNotepad.ScrollBars = ScrollBars.Both;
            txtNotepad.Size = new Size(800, 417);
            txtNotepad.TabIndex = 0;
            txtNotepad.WordWrap = false;
            // 
            // mns
            // 
            mns.ImageScalingSize = new Size(24, 24);
            mns.Items.AddRange(new ToolStripItem[] { 파일ToolStripMenuItem, 편집ToolStripMenuItem, 서식ToolStripMenuItem });
            mns.Location = new Point(0, 0);
            mns.Name = "mns";
            mns.Size = new Size(800, 33);
            mns.TabIndex = 1;
            mns.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            파일ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiNew, tsmiOpen, tsmiSave, tsmiSaveAs, 끝내기ToolStripMenuItem });
            파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size = new Size(64, 29);
            파일ToolStripMenuItem.Text = "파일";
            // 
            // tsmiNew
            // 
            tsmiNew.Name = "tsmiNew";
            tsmiNew.Size = new Size(270, 34);
            tsmiNew.Text = "새로만들기(&N)";
            // 
            // tsmiOpen
            // 
            tsmiOpen.Name = "tsmiOpen";
            tsmiOpen.Size = new Size(270, 34);
            tsmiOpen.Text = "열기";
            // 
            // tsmiSave
            // 
            tsmiSave.Name = "tsmiSave";
            tsmiSave.Size = new Size(270, 34);
            tsmiSave.Text = "저장";
           
            // 끝내기ToolStripMenuItem
            // 
            끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            끝내기ToolStripMenuItem.Size = new Size(270, 34);
            끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // 편집ToolStripMenuItem
            // 
            편집ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 실행취소ToolStripMenuItem, 잘라내기ToolStripMenuItem, 복사ToolStripMenuItem, 붙여넣기ToolStripMenuItem, 삭제ToolStripMenuItem, 모두선택ToolStripMenuItem });
            편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            편집ToolStripMenuItem.Size = new Size(64, 29);
            편집ToolStripMenuItem.Text = "편집";
            // 
            // 실행취소ToolStripMenuItem
            // 
            실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            실행취소ToolStripMenuItem.Size = new Size(270, 34);
            실행취소ToolStripMenuItem.Text = "실행취소";
            // 
            // 잘라내기ToolStripMenuItem
            // 
            잘라내기ToolStripMenuItem.Name = "잘라내기ToolStripMenuItem";
            잘라내기ToolStripMenuItem.Size = new Size(270, 34);
            잘라내기ToolStripMenuItem.Text = "잘라내기";
            // 
            // 복사ToolStripMenuItem
            // 
            복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            복사ToolStripMenuItem.Size = new Size(270, 34);
            복사ToolStripMenuItem.Text = "복사";
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            붙여넣기ToolStripMenuItem.Size = new Size(270, 34);
            붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            // 
            // 삭제ToolStripMenuItem
            // 
            삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            삭제ToolStripMenuItem.Size = new Size(270, 34);
            삭제ToolStripMenuItem.Text = "삭제";
            // 
            // 모두선택ToolStripMenuItem
            // 
            모두선택ToolStripMenuItem.Name = "모두선택ToolStripMenuItem";
            모두선택ToolStripMenuItem.Size = new Size(270, 34);
            모두선택ToolStripMenuItem.Text = "모두선택";
            // 
            // 서식ToolStripMenuItem
            // 
            서식ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 자동줄바꿈ToolStripMenuItem, 글꼴ToolStripMenuItem, 글자색바꾸기ToolStripMenuItem, 바탕색바꾸기ToolStripMenuItem });
            서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            서식ToolStripMenuItem.Size = new Size(64, 29);
            서식ToolStripMenuItem.Text = "서식";
            // 
            // 자동줄바꿈ToolStripMenuItem
            // 
            자동줄바꿈ToolStripMenuItem.Name = "자동줄바꿈ToolStripMenuItem";
            자동줄바꿈ToolStripMenuItem.Size = new Size(270, 34);
            자동줄바꿈ToolStripMenuItem.Text = "자동줄바꿈";
            // 
            // 글꼴ToolStripMenuItem
            // 
            글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            글꼴ToolStripMenuItem.Size = new Size(270, 34);
            글꼴ToolStripMenuItem.Text = "글꼴";
            // 
            // 글자색바꾸기ToolStripMenuItem
            // 
            글자색바꾸기ToolStripMenuItem.Name = "글자색바꾸기ToolStripMenuItem";
            글자색바꾸기ToolStripMenuItem.Size = new Size(270, 34);
            글자색바꾸기ToolStripMenuItem.Text = "글자색바꾸기";
            // 
            // 바탕색바꾸기ToolStripMenuItem
            // 
            바탕색바꾸기ToolStripMenuItem.Name = "바탕색바꾸기ToolStripMenuItem";
            바탕색바꾸기ToolStripMenuItem.Size = new Size(270, 34);
            바탕색바꾸기ToolStripMenuItem.Text = "바탕색바꾸기";
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNotepad);
            Controls.Add(mns);
            MainMenuStrip = mns;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            mns.ResumeLayout(false);
            mns.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNotepad;
        private MenuStrip mns;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem tsmiNew;
        private ToolStripMenuItem tsmiOpen;
        private ToolStripMenuItem tsmiSave;
        private ToolStripMenuItem tsmiSaveAs;
        private ToolStripMenuItem 끝내기ToolStripMenuItem;
        private ToolStripMenuItem 편집ToolStripMenuItem;
        private ToolStripMenuItem 실행취소ToolStripMenuItem;
        private ToolStripMenuItem 잘라내기ToolStripMenuItem;
        private ToolStripMenuItem 복사ToolStripMenuItem;
        private ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private ToolStripMenuItem 삭제ToolStripMenuItem;
        private ToolStripMenuItem 모두선택ToolStripMenuItem;
        private ToolStripMenuItem 서식ToolStripMenuItem;
        private ToolStripMenuItem 자동줄바꿈ToolStripMenuItem;
        private ToolStripMenuItem 글꼴ToolStripMenuItem;
        private ToolStripMenuItem 글자색바꾸기ToolStripMenuItem;
        private ToolStripMenuItem 바탕색바꾸기ToolStripMenuItem;
        private OpenFileDialog ofd;
        private SaveFileDialog sfd;
        private FontDialog fnd;
        private ColorDialog cld;
    }
}
