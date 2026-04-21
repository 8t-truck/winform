using System;
using System.IO;         // 파일 입출력(StreamReader, StreamWriter)을 위한 필수 네임스페이스
using Microsoft.Win32;  // 레지스트리(설정 저장/불러오기)를 위한 필수 네임스페이스
using System.Windows.Forms;

namespace Project2_memo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFileDialog(); // 프로그램 시작 시 대화상자 필터 및 경로 설정
        }

        // 공통 대화상자(Common Dialog) 속성 초기화
        private void InitializeFileDialog()
        {
            // 열기 대화상자의 시작 경로를 사용자의 '바탕화면'으로 설정
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // 파일 필터 설정: "표시될이름|확장자|표시될이름|확장자" (파이프 기호 주의)
            ofd.Filter = "Text (*.txt)|*.txt|" + "All files (*.*)|*.*";
            ofd.FileName = "";

            // 저장 대화상자의 설정도 열기 대화상자와 동일하게 맞춤
            sfd.InitialDirectory = ofd.InitialDirectory;
            sfd.Filter = ofd.Filter;
            sfd.FileName = "*.txt";
        }

        // 폼이 처음 로드될 때 레지스트리에서 저장된 설정 불러오기
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }

        // 폼이 닫힐 때 현재 설정을 레지스트리에 저장
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }

        // [파일] -> [새로 만들기]: 창 제목과 텍스트박스 내용을 초기화
        private void tsmiNew_Click(object sender, EventArgs e)
        {
            Text = "Notepad";               // 폼 제목 초기화
            txtNotepad.Text = string.Empty; // 내용 지우기
        }

        // [파일] -> [열기]: 파일을 읽어와서 텍스트박스에 뿌려줌
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            // 사용자가 파일 선택 후 '열기' 버튼을 눌렀을 때만 실행
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // 선택한 파일의 스트림을 열고 읽기 전용 객체 생성
                Stream stream = ofd.OpenFile();
                StreamReader sr = new StreamReader(stream);

                txtNotepad.Text = sr.ReadToEnd(); // 처음부터 끝까지 다 읽어서 텍스트박스에 저장

                sr.Close();     // 사용한 리소스는 반드시 닫아야 파일이 잠기지 않음
                stream.Close();

                Text = Path.GetFileName(ofd.FileName); // 선택된 파일 이름을 창 제목에 표시
            }
        }

        // [파일] -> [저장]: 현재 내용을 파일에 덮어씀
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            // 만약 저장할 파일명(경로)이 없다면(새 문서라면) '다른 이름으로 저장' 창을 띄움
            // ★중요: 자기 자신(저장)을 호출하면 무한 루프에 빠지므로 tsmiSaveAs_Click을 호출해야 함
            if (ofd.FileName == "")
            {
                tsmiSaveAs_Click(sender, e);
                return;
            }

            sfd.FileName = ofd.FileName;    // 현재 열린 파일 경로를 저장 경로로 지정
            Stream stream = sfd.OpenFile(); // 저장용 스트림 오픈
            StreamWriter sw = new StreamWriter(stream);

            sw.Write(txtNotepad.Text); // 텍스트박스의 내용을 파일에 기록

            sw.Close();     // 기록 후 반드시 닫기
            stream.Close();

            Text = Path.GetFileName(sfd.FileName); // 저장된 파일 이름을 창 제목에 표시
        }

        // [파일] -> [다른 이름으로 저장]: 새로운 파일 경로를 지정받아 저장
        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ofd.FileName = sfd.FileName;    // 새로 지정한 경로를 현재 파일 경로로 업데이트
                tsmiSave_Click(sender, e);      // 실제 저장 로직(위의 메소드) 실행
            }
        }

        // [파일] -> [끝내기]: 프로그램 종료 (FormClosing 이벤트가 연달아 발생함)
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // [편집] 메뉴: 텍스트박스 컨트롤의 내장 함수 활용 (매우 편리함)
        private void tsmiUndo_Click(object sender, EventArgs e) { txtNotepad.Undo(); }           // 실행 취소
        private void tsmiCut_Click(object sender, EventArgs e) { txtNotepad.Cut(); }            // 잘라내기
        private void tsmiCopy_Click(object sender, EventArgs e) { txtNotepad.Copy(); }           // 복사
        private void tsmiPaste_Click(object sender, EventArgs e) { txtNotepad.Paste(); }          // 붙여넣기
        private void tsmiDelete_Click(object sender, EventArgs e) { txtNotepad.SelectedText = string.Empty; } // 삭제: 선택된 텍스트를 빈 문자열로 교체
        private void tsmiSelectAll_Click(object sender, EventArgs e) { txtNotepad.SelectAll(); }      // 모두 선택

        // [서식] -> [자동 줄 바꿈]: 토글 기능 (켜기/끄기)
        private void tsmiWordWrap_Click(object sender, EventArgs e)
        {
            txtNotepad.WordWrap = !txtNotepad.WordWrap;     // 현재 상태의 반대로 변경
            tsmiWordWrap.Checked = txtNotepad.WordWrap;     // 메뉴 항목 옆에 체크 표시 연동
        }

        // [서식] -> [글꼴]: 글꼴 대화상자로 선택한 폰트를 텍스트박스에 적용
        private void tsmiFont_Click(object sender, EventArgs e)
        {
            if (fnd.ShowDialog() == DialogResult.OK) txtNotepad.Font = fnd.Font;
        }

        // [서식] -> [글자색 바꾸기]: 색상 대화상자로 선택한 색을 글자색에 적용
        private void tsmiFontColor_Click(object sender, EventArgs e)
        {
            if (cld.ShowDialog() == DialogResult.OK) txtNotepad.ForeColor = cld.Color;
        }

        // [서식] -> [바탕색 바꾸기]: 색상 대화상자로 선택한 색을 배경색에 적용
        private void tsmiBackColor_Click(object sender, EventArgs e)
        {
            if (cld.ShowDialog() == DialogResult.OK) txtNotepad.BackColor = cld.Color;
        }

        // 레지스트리에 현재 설정(글꼴, 색상) 저장
        private void SaveSetting()
        {
            try // 예기치 않은 시스템 에러 방지를 위해 반드시 try-catch 사용
            {
                // 레지스트리 경로 생성 및 열기 (CurrentUser 하위)
                RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"C# Notepad\Notepad");

                // 저장할 값들을 문자열로 변환 (색상은 Argb 정수값으로 변환)
                var FontName = txtNotepad.Font.FontFamily.GetName(0);
                var FontSize = Convert.ToString(txtNotepad.Font.Size);
                var ForeColor = Convert.ToString(txtNotepad.ForeColor.ToArgb());
                var BackColor = Convert.ToString(txtNotepad.BackColor.ToArgb());

                // 레지스트리 키에 각각의 값 저장
                rk.SetValue("FontName", FontName);
                rk.SetValue("FontSize", FontSize);
                rk.SetValue("ForeColor", ForeColor);
                rk.SetValue("BackColor", BackColor);
            }
            catch (Exception) { /* 에러 발생 시 무시 */ }
        }

        // 레지스트리에서 저장된 설정 불러오기
        private void LoadSetting()
        {
            try
            {
                // 저장된 경로의 키 열기
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"C# Notepad\Notepad");
                if (rk == null) return; // 저장된 데이터가 없으면 함수 종료 (첫 실행 시)

                // 저장된 값을 읽어와 원래의 데이터 타입으로 복원 (형변환 주의)
                var FontName = Convert.ToString(rk.GetValue("FontName"));
                var FontSize = Convert.ToSingle(rk.GetValue("FontSize"));  // float 타입
                var ForeColor = Convert.ToInt32(rk.GetValue("ForeColor"));  // Argb 정수값
                var BackColor = Convert.ToInt32(rk.GetValue("BackColor"));  // Argb 정수값

                // 복원된 정보를 바탕으로 컨트롤 속성 재설정
                txtNotepad.Font = new System.Drawing.Font(FontName, FontSize);
                txtNotepad.ForeColor = System.Drawing.Color.FromArgb(ForeColor);
                txtNotepad.BackColor = System.Drawing.Color.FromArgb(BackColor);

                fnd.Font = txtNotepad.Font; // 다음번 글꼴 창을 열 때 현재 상태가 유지되도록 설정
            }
            catch (Exception) { /* 첫 실행 시 키가 없어 에러가 날 수 있으므로 무시 */ }
        }

        // ※ Form1_FormClosing_1은 디자이너에서 중복 등록된 이벤트이므로 아래 한 곳에서만 처리
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            SaveSetting(); // 종료 시 설정 저장 (Form1_FormClosing과 동일한 역할)
        }
    }
}