using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class MyNotePad : Form
    {
        public MyNotePad()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll")] //WIN32 SDK
        static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder buf, int bSize,  string path);
        [DllImport("kernel32.dll")] //이거 한개당 함수 한개씩 Import 가능 >> 왜 이런식이지?
        static extern bool WritePrivateProfileString(string section, string key, string val, string path);

        // string GetToken(int n, string str, char d);
        //      int n: n번째 아이템
        //      string str: 문자열 
        //      char d: 구분자
        //  설명) 문자열 str에 있는 데이터 중 구분자 d를 통해 
        //        필드를 구분하여 그 중 n번째 데이터을 반환
        //  예시) GetToken(1, "a,b,c,d" ',')  returns 'b'
        public string GetToken(int n, string str, char d)
        {
            
            if (str.Contains(d))
            {
                //split version
                //string[] items = str.Split(d);

                ////강사님 버전
                //// str의 적합한 인덱스 start~end를 체크해서
                //// str의 substring을 반환
                // for(int i=j=k=start=end=0;i<str.Length;i++)
                // {
                //      if (str[i] == d) k++;
                //      if (k == n) start = i;
                //      if (k == n + 1) end = i;
                // }
                // if (start == 0) return "";
                // if (end == 0) end = str.Length;
                // return str.Substring(start,end-(start+1));
                
                //My Non-split version:
                  var items = new List<string>();
                string item = "";
                for(int i = 0; i < str.Length; i++)
                {
                    if (str[i] != d)
                        item+=str[i];
                    if (str[i] == d || i == str.Length-1)
                    {
                        items.Add(item);
                        item = "";
                    }
                       
                }
                string[] ITEMS = items.ToArray();
                if (n <= ITEMS.Length && n >= 0) // n > 0으로 되어 있었음..
                    return ITEMS[n];
                else return "index out of bounds";
                }
            else return $"does not contain \'{d}\'";            
        }

        //전역변수의 초기화
        string strOrigin = "";
        int viewState = 0; //0:Normal, 1.Lower, 2.Upper, 3.Hexa
        private void MNToLower_Click(object sender, EventArgs e)
        {
            //string str = tbMemo.Text.ToLower();
            //tbMemo.Text = str;
            if(viewState != 1) //Lower View가 아니라면..
            { 
                if(strOrigin == "") strOrigin = tbMemo.Text; //원판보존
                tbMemo.Text = strOrigin.ToLower(); //현재 화면이 아니라 원판을 기준으로 출력
                tbMemo.ReadOnly = true;
                viewState = 1;
            }
            
        }

        private void MNToUpper_Click(object sender, EventArgs e)
        {
            if (viewState != 2) //Upper View가 아니라면..
            {
                if (strOrigin == "") strOrigin = tbMemo.Text;
                tbMemo.Text = strOrigin.ToUpper(); 
                tbMemo.ReadOnly = true;
                viewState = 2;
            }
        }

        private void MNToHex_Click(object sender, EventArgs e)
        {
            if (viewState != 3) //Hexa View가 아니라면..
            {
                if (strOrigin == "") strOrigin = tbMemo.Text;
                tbMemo.Text = "";
                //인코딩을 안하면 한글(2byte) 짤림
                byte[] bArr1 = Encoding.Default.GetBytes(strOrigin); // C/C++과 다른 배열선언

                for (int i = 0; i < bArr1.Length; i++)
                {
                    //{}: manipulator, format, 변환문자   2X가 아니라 X2임을 명심할 것
                    //C#의 char값은 정수형과 호환되지 않는다
                    //tbMemo.Text += string.Format("{0:X2} ", (byte)strOrigin[i]);
                    tbMemo.Text += $"{bArr1[i]:X2} "; //$" ": 보간 문자열(String Interpolation) 지시자
                    if (i % 16 == 15) tbMemo.Text += "\r\n";
                }

                //int cnt = 0;
                //foreach (byte bt in bArr1)
                //{
                //    tbMemo.Text += $"{bt:x2} ";
                //    if (cnt++ % 16 == 15) tbMemo.Text += "\r\n";
                //}

                tbMemo.ReadOnly = true;
                viewState = 3;
            }
          
        }
      
        private void MNReturn_Click(object sender, EventArgs e)
        {
            if (tbMemo.ReadOnly == true) // 이거 없으면 빈칸으로 만들수도 있다
            {
                tbMemo.Text = strOrigin;
                strOrigin = "";
                tbMemo.ReadOnly = false;
                viewState = 0;
            }
        }

        private void tbMemo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MNReturn_Click(sender, e);
            }
        }

        //파일 입출력 관련 글로벌 변수
        bool isFileOpen = false;
        string filePath = ""; //fullpath로 받음
        //string fileName = ""; 

        private void MNOpenFile_Click(object sender, EventArgs e)
        {
            //ShowDialog() DoModal과 유사한 종속적인 호출
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName); //new 생성자 호출
                filePath = openFileDialog.FileName;
                tbMemo.Text = sr.ReadToEnd();
                sr.Close(); //파일 종료
                MyNotePad.ActiveForm.Text = Path.GetFileName(filePath);
                isFileOpen = true;
            }
        }

        

        private void MNSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "모든 파일|*.*|텍스트 파일|*.txt";
            saveFileDialog.FilterIndex = 2;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                filePath = saveFileDialog.FileName;
                sw.Write(tbMemo.Text);
                sw.Close();
                //char c = '\\';
                MyNotePad.ActiveForm.Text = GetToken((filePath.Split('\\').Length -1), filePath , '\\');
                isFileOpen = true;
            }
            
        }

        private void MNSave_Click(object sender, EventArgs e)
        {
            if (isFileOpen)
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write(tbMemo.Text);
                sw.Close();
            }
            else
            {
                MNSaveAs_Click(sender, e);
            }
        }

        private void MNNew_Click(object sender, EventArgs e)
        {
            //TODO: 확인 메세지
            MNSave_Click(sender, e);
            isFileOpen = false;
            filePath = "";
            tbMemo.Text = "";
            MyNotePad.ActiveForm.Text = "MyNotePad";

        }

        void AddLine(string str)
        {
            tbMemo.Text += str + "\r\n";
        }

        Point p; //전역변수 p
        string iniLABEL = "";
        private void MnCallTest_Click(object sender, EventArgs e)
        {
            //namespace MyNotePad 안에 Form2가 존재한다..
            Form2 dlg = new Form2(); //인스턴스 초기화, 이거 로컬변수임
            dlg.Location = p; // 다이얼로그 생성 위치를 p로 잡아둠
            //Point p = new Point(100, 100); // (100, 100) 위치에 점 생성

            //dlg.iniLABEL; TODO: 요거 Access 하는거 해야됨

            //이 위치에 선언하는 것이 맞나??
            if (sbLabel1.Text != "sbLabel1")
            {
                string LABEL = sbLabel1.Text; // ex) COM1:9200,N81
                string chosenCOM = LABEL.Split(':')[0];
                if (chosenCOM == "COM1") dlg.rbCOM1.Checked = true;
                else dlg.rbCOM2.Checked = true;
                dlg.cbSpeed.Text = LABEL.Split(',')[0].Split(':')[1];
                // None Odd Even
                if (LABEL[LABEL.Length - 3] == 'N') dlg.cbParity.Text = "None";
                if (LABEL[LABEL.Length - 3] == 'O') dlg.cbParity.Text = "Odd";
                if (LABEL[LABEL.Length - 3] == 'E') dlg.cbParity.Text = "Even";
                dlg.cbDataBit.Text = LABEL[LABEL.Length - 2].ToString(); //아래 참조
                dlg.cbStopBit.Text = $"{LABEL[LABEL.Length - 1]}"; //보간문자열로 ToString 대체
            }

            if (dlg.ShowDialog() == DialogResult.OK) //DoModal로 호출한 느낌
            {

                //삼항연산자(ternary operator):  조건식 ? True : False
                //nested ternary operator도 가능함, 가독성 구린듯
                string str = dlg.rbCOM1.Checked ? "COM1:" :
                             dlg.rbCOM2.Checked ? "COM2:" : "N/A";
                str += dlg.cbSpeed.Text + ",";
                if (dlg.cbParity.Text != "")
                    str += dlg.cbParity.Text.Trim().ToUpper()[0]; //string.Trim()
                str += dlg.cbDataBit.Text;
                str += dlg.cbStopBit.Text;
                //AddLine(str);
                sbLabel1.Text = str;
            }
            p = dlg.Location; // Form2에서 StartingPosition 속성을 Manual로 바꿔야 동작함

        }

        private void getTokenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                tbMemo.Text += GetToken(i, "0, 1, 2, 3, 4", ',');
            }
            
        }

        //경로 path
        string iniPath = ".\\MyNotePad.ini"; // .ini파일의 fullpath
        //ini load
        private void MyNotePad_Load(object sender, EventArgs e)
        {
            // .ini 파일의 key-value 쌍의 value의 최대 사이즈
            StringBuilder buf = new StringBuilder(500);

            //GetPrivateProfileString(string sec, string key, string def, StringBuilder buf, int bSize, string path);
            GetPrivateProfileString("Form1", "LocationX", "0", buf, 500, iniPath); 
                int x = int.Parse(buf.ToString()) ; // LocationX에서 읽어서 int x에 저장
            GetPrivateProfileString("Form1", "LocationY", "0", buf, 500, iniPath);
                int y = int.Parse(buf.ToString());
            Location = new Point(x, y); // Location이 Form.Location 의 약어다

            


        }

        //ini save
        private void MyNotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            //WritePrivateProfileString(string section, string key, string val, string path);
            WritePrivateProfileString("Form1", "LocationX", $"{Location.X}", iniPath);
            WritePrivateProfileString("Form1", "LocationY", $"{Location.Y}", iniPath);

            
        }
    }
}
