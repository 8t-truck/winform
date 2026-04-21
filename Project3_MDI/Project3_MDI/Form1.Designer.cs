namespace Project3_MDI
{
    partial class Parent
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
            mainMenu = new MenuStrip();
            파일ToolStripMenuItem = new ToolStripMenuItem();
            새파일ToolStripMenuItem = new ToolStripMenuItem();
            열기ToolStripMenuItem = new ToolStripMenuItem();
            저장ToolStripMenuItem = new ToolStripMenuItem();
            다른이름으로저장ToolStripMenuItem = new ToolStripMenuItem();
            편집ToolStripMenuItem = new ToolStripMenuItem();
            실행취소ToolStripMenuItem = new ToolStripMenuItem();
            오려내기ToolStripMenuItem = new ToolStripMenuItem();
            복사하기ToolStripMenuItem = new ToolStripMenuItem();
            붙여넣기ToolStripMenuItem = new ToolStripMenuItem();
            지우기ToolStripMenuItem = new ToolStripMenuItem();
            보기ToolStripMenuItem = new ToolStripMenuItem();
            자동줄바꿈ToolStripMenuItem = new ToolStripMenuItem();
            글꼴ToolStripMenuItem = new ToolStripMenuItem();
            글자색바꾸기ToolStripMenuItem = new ToolStripMenuItem();
            바탕색바꾸기ToolStripMenuItem = new ToolStripMenuItem();
            창ToolStripMenuItem = new ToolStripMenuItem();
            바둑판배열ToolStripMenuItem = new ToolStripMenuItem();
            바둑판배열가로ToolStripMenuItem = new ToolStripMenuItem();
            계ToolStripMenuItem = new ToolStripMenuItem();
            openFDlg = new OpenFileDialog();
            saveFDlg = new SaveFileDialog();
            fontDlg = new FontDialog();
            colorDlg = new ColorDialog();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(24, 24);
            mainMenu.Items.AddRange(new ToolStripItem[] { 파일ToolStripMenuItem, 편집ToolStripMenuItem, 보기ToolStripMenuItem, 창ToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(800, 33);
            mainMenu.TabIndex = 1;
            mainMenu.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            파일ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 새파일ToolStripMenuItem, 열기ToolStripMenuItem, 저장ToolStripMenuItem, 다른이름으로저장ToolStripMenuItem });
            파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size = new Size(64, 29);
            파일ToolStripMenuItem.Text = "파일";
            // 
            // 새파일ToolStripMenuItem
            // 
            새파일ToolStripMenuItem.Name = "새파일ToolStripMenuItem";
            새파일ToolStripMenuItem.Size = new Size(270, 34);
            새파일ToolStripMenuItem.Text = "새파일";
            새파일ToolStripMenuItem.Click += 새파일ToolStripMenuItem_Click;
            // 
            // 열기ToolStripMenuItem
            // 
            열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            열기ToolStripMenuItem.Size = new Size(270, 34);
            열기ToolStripMenuItem.Text = "열기";
            열기ToolStripMenuItem.Click += 열기ToolStripMenuItem_Click;
            // 
            // 저장ToolStripMenuItem
            // 
            저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            저장ToolStripMenuItem.Size = new Size(270, 34);
            저장ToolStripMenuItem.Text = "저장";
            저장ToolStripMenuItem.Click += 저장ToolStripMenuItem_Click;
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            다른이름으로저장ToolStripMenuItem.Size = new Size(270, 34);
            다른이름으로저장ToolStripMenuItem.Text = "다른이름으로저장";
            다른이름으로저장ToolStripMenuItem.Click += 다른이름으로저장ToolStripMenuItem_Click;
            // 
            // 편집ToolStripMenuItem
            // 
            편집ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 실행취소ToolStripMenuItem, 오려내기ToolStripMenuItem, 복사하기ToolStripMenuItem, 붙여넣기ToolStripMenuItem, 지우기ToolStripMenuItem });
            편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            편집ToolStripMenuItem.Size = new Size(64, 29);
            편집ToolStripMenuItem.Text = "편집";
            // 
            // 실행취소ToolStripMenuItem
            // 
            실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            실행취소ToolStripMenuItem.Size = new Size(270, 34);
            실행취소ToolStripMenuItem.Text = "실행취소";
            실행취소ToolStripMenuItem.Click += 실행취소ToolStripMenuItem_Click;
            // 
            // 오려내기ToolStripMenuItem
            // 
            오려내기ToolStripMenuItem.Name = "오려내기ToolStripMenuItem";
            오려내기ToolStripMenuItem.Size = new Size(270, 34);
            오려내기ToolStripMenuItem.Text = "오려내기";
            오려내기ToolStripMenuItem.Click += 오려내기ToolStripMenuItem_Click;
            // 
            // 복사하기ToolStripMenuItem
            // 
            복사하기ToolStripMenuItem.Name = "복사하기ToolStripMenuItem";
            복사하기ToolStripMenuItem.Size = new Size(270, 34);
            복사하기ToolStripMenuItem.Text = "복사하기";
            복사하기ToolStripMenuItem.Click += 복사하기ToolStripMenuItem_Click;
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            붙여넣기ToolStripMenuItem.Size = new Size(270, 34);
            붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            붙여넣기ToolStripMenuItem.Click += 붙여넣기ToolStripMenuItem_Click;
            // 
            // 지우기ToolStripMenuItem
            // 
            지우기ToolStripMenuItem.Name = "지우기ToolStripMenuItem";
            지우기ToolStripMenuItem.Size = new Size(270, 34);
            지우기ToolStripMenuItem.Text = "지우기";
            지우기ToolStripMenuItem.Click += 지우기ToolStripMenuItem_Click;
            // 
            // 보기ToolStripMenuItem
            // 
            보기ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 자동줄바꿈ToolStripMenuItem, 글꼴ToolStripMenuItem, 글자색바꾸기ToolStripMenuItem, 바탕색바꾸기ToolStripMenuItem });
            보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            보기ToolStripMenuItem.Size = new Size(64, 29);
            보기ToolStripMenuItem.Text = "보기";
            // 
            // 자동줄바꿈ToolStripMenuItem
            // 
            자동줄바꿈ToolStripMenuItem.Name = "자동줄바꿈ToolStripMenuItem";
            자동줄바꿈ToolStripMenuItem.Size = new Size(270, 34);
            자동줄바꿈ToolStripMenuItem.Text = "자동줄바꿈";
            자동줄바꿈ToolStripMenuItem.Click += 자동줄바꿈ToolStripMenuItem_Click;
            // 
            // 글꼴ToolStripMenuItem
            // 
            글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            글꼴ToolStripMenuItem.Size = new Size(270, 34);
            글꼴ToolStripMenuItem.Text = "글꼴";
            글꼴ToolStripMenuItem.Click += 글꼴ToolStripMenuItem_Click;
            // 
            // 글자색바꾸기ToolStripMenuItem
            // 
            글자색바꾸기ToolStripMenuItem.Name = "글자색바꾸기ToolStripMenuItem";
            글자색바꾸기ToolStripMenuItem.Size = new Size(270, 34);
            글자색바꾸기ToolStripMenuItem.Text = "글자색바꾸기";
            글자색바꾸기ToolStripMenuItem.Click += 글자색바꾸기ToolStripMenuItem_Click;
            // 
            // 바탕색바꾸기ToolStripMenuItem
            // 
            바탕색바꾸기ToolStripMenuItem.Name = "바탕색바꾸기ToolStripMenuItem";
            바탕색바꾸기ToolStripMenuItem.Size = new Size(270, 34);
            바탕색바꾸기ToolStripMenuItem.Text = "바탕색바꾸기";
            바탕색바꾸기ToolStripMenuItem.Click += 바탕색바꾸기ToolStripMenuItem_Click;
            // 
            // 창ToolStripMenuItem
            // 
            창ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 바둑판배열ToolStripMenuItem, 바둑판배열가로ToolStripMenuItem, 계ToolStripMenuItem });
            창ToolStripMenuItem.Name = "창ToolStripMenuItem";
            창ToolStripMenuItem.Size = new Size(46, 29);
            창ToolStripMenuItem.Text = "창";
            // 
            // 바둑판배열ToolStripMenuItem
            // 
            바둑판배열ToolStripMenuItem.Name = "바둑판배열ToolStripMenuItem";
            바둑판배열ToolStripMenuItem.Size = new Size(270, 34);
            바둑판배열ToolStripMenuItem.Text = "바둑판배열(세로)";
            바둑판배열ToolStripMenuItem.Click += 바둑판배열ToolStripMenuItem_Click;
            // 
            // 바둑판배열가로ToolStripMenuItem
            // 
            바둑판배열가로ToolStripMenuItem.Name = "바둑판배열가로ToolStripMenuItem";
            바둑판배열가로ToolStripMenuItem.Size = new Size(270, 34);
            바둑판배열가로ToolStripMenuItem.Text = "바둑판배열(가로)";
            바둑판배열가로ToolStripMenuItem.Click += 바둑판배열가로ToolStripMenuItem_Click;
            // 
            // 계ToolStripMenuItem
            // 
            계ToolStripMenuItem.Name = "계ToolStripMenuItem";
            계ToolStripMenuItem.Size = new Size(270, 34);
            계ToolStripMenuItem.Text = "계단식배열";
            계ToolStripMenuItem.Click += 계ToolStripMenuItem_Click;
            // 
            // openFDlg
            // 
            openFDlg.FileName = "openFileDialog1";
            // 
            // Parent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenu);
            IsMdiContainer = true;
            MainMenuStrip = mainMenu;
            Name = "Parent";
            Text = "Parent";
            Load += Form1_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem 새파일ToolStripMenuItem;
        private ToolStripMenuItem 열기ToolStripMenuItem;
        private ToolStripMenuItem 저장ToolStripMenuItem;
        private ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private ToolStripMenuItem 편집ToolStripMenuItem;
        private ToolStripMenuItem 실행취소ToolStripMenuItem;
        private ToolStripMenuItem 오려내기ToolStripMenuItem;
        private ToolStripMenuItem 복사하기ToolStripMenuItem;
        private ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private ToolStripMenuItem 지우기ToolStripMenuItem;
        private ToolStripMenuItem 보기ToolStripMenuItem;
        private ToolStripMenuItem 자동줄바꿈ToolStripMenuItem;
        private ToolStripMenuItem 글꼴ToolStripMenuItem;
        private ToolStripMenuItem 글자색바꾸기ToolStripMenuItem;
        private ToolStripMenuItem 바탕색바꾸기ToolStripMenuItem;
        private ToolStripMenuItem 창ToolStripMenuItem;
        private ToolStripMenuItem 바둑판배열ToolStripMenuItem;
        private ToolStripMenuItem 바둑판배열가로ToolStripMenuItem;
        private ToolStripMenuItem 계ToolStripMenuItem;
        private OpenFileDialog openFDlg;
        private SaveFileDialog saveFDlg;
        private FontDialog fontDlg;
        private ColorDialog colorDlg;
    }
}
