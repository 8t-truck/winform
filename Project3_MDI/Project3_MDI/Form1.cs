using System.IO;
namespace Project3_MDI
{
    public partial class Parent : Form
    {
        // 자식 폼 객체 선언 (MDI 자식 창)
        Child child;

        // 새 파일 생성 시 제목에 붙을 번호 카운터
        int nChild = 0;

        public Parent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 초기화 작업 (필요 시 추가)
        }

        // ===================== 파일 메뉴 =====================

        // [파일] → [새 파일] 클릭 이벤트 핸들러
        // 새로운 자식 폼을 생성하고 부모 폼(MDI 컨테이너)에 표시
        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = new Child();                        // 자식 폼(Child) 인스턴스 생성
            child.MdiParent = this;                     // 자식 폼의 부모를 현재 Parent 폼으로 설정 (MDI 연결)
            child.Text = "NONAME" + nChild++;           // 제목을 "NONAME0", "NONAME1" 형식으로 설정하고 번호 증가
            child.Show();                               // 자식 폼 화면에 표시
        }

        // [파일] → [열기] 클릭 이벤트 핸들러
        // openFileDialog를 통해 파일 선택 후 해당 내용을 새 자식 폼에 불러옴
        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 열기 대화상자를 띄우고 사용자가 확인(OK)을 누른 경우에만 처리
            if (openFDlg.ShowDialog() == DialogResult.OK)
            {
                // 선택한 파일을 스트림으로 열기
                Stream str = openFDlg.OpenFile();
                // StreamReader로 텍스트를 읽을 준비
                StreamReader reader = new StreamReader(str);

                child = new Child();                    // 새 자식 폼 생성
                child.MdiParent = this;                 // MDI 부모 연결
                child.Text = "NONAME" + nChild++;       // 임시 제목 설정
                child.Show();                           // 자식 폼 표시

                // 파일 내용 전체를 읽어 자식 폼의 텍스트박스에 표시
                child.getTextBox().Text = reader.ReadToEnd();
                reader.Close();                         // StreamReader 닫기
                str.Close();                            // Stream 닫기
            }
        }

        // [파일] → [저장] 클릭 이벤트 핸들러
        // saveFileDialog를 이용해 현재 활성화된 자식 폼 내용을 기존 제목(파일명)으로 저장
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFDlg.ShowDialog() == DialogResult.OK)
            {
                // 현재 활성화된 MDI 자식 폼을 Child 타입으로 캐스팅
                child = (Child)(this.ActiveMdiChild);
                // 자식 폼의 제목(파일명)을 가져옴
                string fName = child.Text;
                // 해당 파일명으로 StreamWriter를 생성하여 텍스트 저장
                StreamWriter write = new StreamWriter(fName);
                write.Write(child.getTextBox().Text);   // 텍스트박스 내용을 파일에 씀
                write.Close();                          // StreamWriter 닫기
            }
        }

        // [파일] → [다른 이름으로 저장] 클릭 이벤트 핸들러
        // saveFileDialog에서 선택한 경로/파일명으로 저장하고 자식 폼 제목도 해당 파일명으로 갱신
        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFDlg.ShowDialog() == DialogResult.OK)
            {
                // 현재 활성화된 MDI 자식 폼을 Child 타입으로 캐스팅
                child = (Child)(this.ActiveMdiChild);
                // 대화상자에서 선택/입력한 파일 전체 경로를 가져옴
                string fName = saveFDlg.FileName;
                // 해당 경로로 StreamWriter를 생성하여 텍스트 저장
                StreamWriter write = new StreamWriter(fName);
                write.Write(child.getTextBox().Text);   // 텍스트박스 내용을 파일에 씀
                write.Close();                          // StreamWriter 닫기
                child.Text = fName;                     // 자식 폼의 제목을 저장된 파일명으로 변경
            }
        }

        // ===================== 편집 메뉴 =====================

        // [편집] → [실행 취소] 클릭 이벤트 핸들러
        // 현재 활성 자식 폼의 텍스트박스에서 마지막 작업을 실행 취소
        private void 실행취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = (Child)(this.ActiveMdiChild);       // 현재 활성화된 자식 폼 가져오기
            child.getTextBox().Undo();                  // TextBox의 Undo() 메서드 호출 (실행 취소)
        }

        // [편집] → [오려내기] 클릭 이벤트 핸들러
        // 현재 선택된 텍스트를 클립보드로 잘라냄
        private void 오려내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = (Child)(this.ActiveMdiChild);       // 현재 활성화된 자식 폼 가져오기
            child.getTextBox().Cut();                   // TextBox의 Cut() 메서드 호출 (오려내기)
        }

        // [편집] → [복사하기] 클릭 이벤트 핸들러
        // 현재 선택된 텍스트를 클립보드에 복사
        private void 복사하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = (Child)(this.ActiveMdiChild);       // 현재 활성화된 자식 폼 가져오기
            child.getTextBox().Copy();                  // TextBox의 Copy() 메서드 호출 (복사하기)
        }

        // [편집] → [붙여넣기] 클릭 이벤트 핸들러
        // 클립보드의 내용을 현재 커서 위치에 붙여넣기
        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = (Child)(this.ActiveMdiChild);       // 현재 활성화된 자식 폼 가져오기
            child.getTextBox().Paste();                 // TextBox의 Paste() 메서드 호출 (붙여넣기)
        }

        // [편집] → [지우기] 클릭 이벤트 핸들러
        // 텍스트박스의 내용을 전부 지움
        private void 지우기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = (Child)(this.ActiveMdiChild);       // 현재 활성화된 자식 폼 가져오기
            child.getTextBox().Text = "";               // 텍스트박스 내용을 빈 문자열로 초기화
        }

        // ===================== 보기 메뉴 =====================

        // [보기] → [자동 줄 바꿈] 클릭 이벤트 핸들러
        // 텍스트박스의 줄 바꿈(WordWrap) 기능을 토글(켜기/끄기)하고 메뉴 체크 상태도 연동
        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = (Child)(this.ActiveMdiChild);       // 현재 활성화된 자식 폼 가져오기

            if (child.getTextBox().WordWrap)            // 현재 WordWrap이 켜진 상태라면
            {
                child.getTextBox().WordWrap = false;            // WordWrap 끄기
                자동줄바꿈ToolStripMenuItem.Checked = false;    // 메뉴 아이템 체크 해제
            }
            else                                        // 현재 WordWrap이 꺼진 상태라면
            {
                child.getTextBox().WordWrap = true;             // WordWrap 켜기
                자동줄바꿈ToolStripMenuItem.Checked = true;     // 메뉴 아이템 체크 표시
            }
        }

        // [보기] → [글꼴] 클릭 이벤트 핸들러
        // FontDialog를 열어 사용자가 선택한 글꼴을 텍스트박스에 적용
        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = (Child)(this.ActiveMdiChild);       // 현재 활성화된 자식 폼 가져오기

            if (fontDlg.ShowDialog() == DialogResult.OK)    // 글꼴 대화상자에서 확인을 누른 경우
            {
                child.getTextBox().Font = fontDlg.Font;     // 선택한 글꼴을 텍스트박스에 적용
            }
        }

        // [보기] → [글자색 바꾸기] 클릭 이벤트 핸들러
        // ColorDialog를 열어 사용자가 선택한 색을 텍스트(글자) 색상으로 적용
        private void 글자색바꾸기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = (Child)(this.ActiveMdiChild);       // 현재 활성화된 자식 폼 가져오기

            if (colorDlg.ShowDialog() == DialogResult.OK)   // 색상 대화상자에서 확인을 누른 경우
            {
                child.getTextBox().ForeColor = colorDlg.Color;  // 선택한 색을 글자 색상(ForeColor)으로 적용
            }
        }

        // [보기] → [바탕색 바꾸기] 클릭 이벤트 핸들러
        // ColorDialog를 열어 사용자가 선택한 색을 텍스트박스 배경색으로 적용
        private void 바탕색바꾸기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = (Child)(this.ActiveMdiChild);       // 현재 활성화된 자식 폼 가져오기

            if (colorDlg.ShowDialog() == DialogResult.OK)   // 색상 대화상자에서 확인을 누른 경우
            {
                child.getTextBox().BackColor = colorDlg.Color;  // 선택한 색을 배경색(BackColor)으로 적용
            }
        }

        // ===================== 창 메뉴 =====================

        // [창] → [바둑판 배열(세로)] 클릭 이벤트 핸들러
        // 모든 자식 폼을 세로 방향의 타일 형태로 정렬
        private void 바둑판배열ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MdiLayout.TileVertical: 세로 바둑판 배열 (자식 창들을 세로로 분할)
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // [창] → [바둑판 배열(가로)] 클릭 이벤트 핸들러
        // 모든 자식 폼을 가로 방향의 타일 형태로 정렬
        private void 바둑판배열가로ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MdiLayout.TileHorizontal: 가로 바둑판 배열 (자식 창들을 가로로 분할)
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // [창] → [계단식 배열] 클릭 이벤트 핸들러
        // 모든 자식 폼을 계단식으로 겹쳐서 정렬
        private void 계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MdiLayout.Cascade: 계단식 배열 (자식 창들을 대각선으로 겹침)
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}