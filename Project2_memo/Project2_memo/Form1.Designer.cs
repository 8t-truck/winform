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
            tsmiExit = new ToolStripMenuItem();
            편집ToolStripMenuItem = new ToolStripMenuItem();
            tsmiUndo = new ToolStripMenuItem();
            tsmiCut = new ToolStripMenuItem();
            tsmiCopy = new ToolStripMenuItem();
            tsmiPaste = new ToolStripMenuItem();
            tsmiDelete = new ToolStripMenuItem();
            tsmiSelectAll = new ToolStripMenuItem();
            서식ToolStripMenuItem = new ToolStripMenuItem();
            tsmiWordWrap = new ToolStripMenuItem();
            tsmiFont = new ToolStripMenuItem();
            tsmiFontColor = new ToolStripMenuItem();
            tsmiBackColor = new ToolStripMenuItem();
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
            파일ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiNew, tsmiOpen, tsmiSave, tsmiSaveAs, tsmiExit });
            파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size = new Size(64, 29);
            파일ToolStripMenuItem.Text = "파일";
            // 
            // tsmiNew
            // 
            tsmiNew.Name = "tsmiNew";
            tsmiNew.Size = new Size(258, 34);
            tsmiNew.Text = "새로만들기(&N)";
            tsmiNew.Click += tsmiNew_Click;
            // 
            // tsmiOpen
            // 
            tsmiOpen.Name = "tsmiOpen";
            tsmiOpen.Size = new Size(258, 34);
            tsmiOpen.Text = "열기";
            tsmiOpen.Click += tsmiOpen_Click;
            // 
            // tsmiSave
            // 
            tsmiSave.Name = "tsmiSave";
            tsmiSave.Size = new Size(258, 34);
            tsmiSave.Text = "저장";
            tsmiSave.Click += tsmiSave_Click;
            // 
            // tsmiSaveAs
            // 
            tsmiSaveAs.Name = "tsmiSaveAs";
            tsmiSaveAs.Size = new Size(258, 34);
            tsmiSaveAs.Text = "다른이름으로저장";
            tsmiSaveAs.Click += tsmiSaveAs_Click;
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(258, 34);
            tsmiExit.Text = "끝내기";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // 편집ToolStripMenuItem
            // 
            편집ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiUndo, tsmiCut, tsmiCopy, tsmiPaste, tsmiDelete, tsmiSelectAll });
            편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            편집ToolStripMenuItem.Size = new Size(64, 29);
            편집ToolStripMenuItem.Text = "편집";
            // 
            // tsmiUndo
            // 
            tsmiUndo.Name = "tsmiUndo";
            tsmiUndo.Size = new Size(186, 34);
            tsmiUndo.Text = "실행취소";
            tsmiUndo.Click += tsmiUndo_Click;
            // 
            // tsmiCut
            // 
            tsmiCut.Name = "tsmiCut";
            tsmiCut.Size = new Size(186, 34);
            tsmiCut.Text = "잘라내기";
            tsmiCut.Click += tsmiCut_Click;
            // 
            // tsmiCopy
            // 
            tsmiCopy.Name = "tsmiCopy";
            tsmiCopy.Size = new Size(186, 34);
            tsmiCopy.Text = "복사";
            tsmiCopy.Click += tsmiCopy_Click;
            // 
            // tsmiPaste
            // 
            tsmiPaste.Name = "tsmiPaste";
            tsmiPaste.Size = new Size(186, 34);
            tsmiPaste.Text = "붙여넣기";
            tsmiPaste.Click += tsmiPaste_Click;
            // 
            // tsmiDelete
            // 
            tsmiDelete.Name = "tsmiDelete";
            tsmiDelete.Size = new Size(186, 34);
            tsmiDelete.Text = "삭제";
            tsmiDelete.Click += tsmiDelete_Click;
            // 
            // tsmiSelectAll
            // 
            tsmiSelectAll.Name = "tsmiSelectAll";
            tsmiSelectAll.Size = new Size(186, 34);
            tsmiSelectAll.Text = "모두선택";
            tsmiSelectAll.Click += tsmiSelectAll_Click;
            // 
            // 서식ToolStripMenuItem
            // 
            서식ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiWordWrap, tsmiFont, tsmiFontColor, tsmiBackColor });
            서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            서식ToolStripMenuItem.Size = new Size(64, 29);
            서식ToolStripMenuItem.Text = "서식";
            // 
            // tsmiWordWrap
            // 
            tsmiWordWrap.Name = "tsmiWordWrap";
            tsmiWordWrap.Size = new Size(222, 34);
            tsmiWordWrap.Text = "자동줄바꿈";
            tsmiWordWrap.Click += tsmiWordWrap_Click;
            // 
            // tsmiFont
            // 
            tsmiFont.Name = "tsmiFont";
            tsmiFont.Size = new Size(222, 34);
            tsmiFont.Text = "글꼴";
            tsmiFont.Click += tsmiFont_Click;
            // 
            // tsmiFontColor
            // 
            tsmiFontColor.Name = "tsmiFontColor";
            tsmiFontColor.Size = new Size(222, 34);
            tsmiFontColor.Text = "글자색바꾸기";
            tsmiFontColor.Click += tsmiFontColor_Click;
            // 
            // tsmiBackColor
            // 
            tsmiBackColor.Name = "tsmiBackColor";
            tsmiBackColor.Size = new Size(222, 34);
            tsmiBackColor.Text = "바탕색바꾸기";
            tsmiBackColor.Click += tsmiBackColor_Click;
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
            FormClosing += Form1_FormClosing_1;
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
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem 편집ToolStripMenuItem;
        private ToolStripMenuItem tsmiUndo;
        private ToolStripMenuItem tsmiCut;
        private ToolStripMenuItem tsmiCopy;
        private ToolStripMenuItem tsmiPaste;
        private ToolStripMenuItem tsmiDelete;
        private ToolStripMenuItem tsmiSelectAll;
        private ToolStripMenuItem 서식ToolStripMenuItem;
        private ToolStripMenuItem tsmiWordWrap;
        private ToolStripMenuItem tsmiFont;
        private ToolStripMenuItem tsmiFontColor;
        private ToolStripMenuItem tsmiBackColor;
        private OpenFileDialog ofd;
        private SaveFileDialog sfd;
        private FontDialog fnd;
        private ColorDialog cld;
    }
}
