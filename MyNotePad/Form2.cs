using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class Form2 : Form
    {
        public Form2() //생성자(클래스 명과 동일함)
        {
            InitializeComponent();

            cbStopBit.Items.Add("1"); // '1'로 처리하면 에러날 수 있음(string)
            cbStopBit.Items.Add("2");
        }

        [DllImport("kernel32.dll")] //WIN32 SDK
        static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder buf, int bSize, string path);
        [DllImport("kernel32.dll")] //이거 한개당 함수 한개씩 Import 가능 >> 왜 이런식이지?
        static extern bool WritePrivateProfileString(string section, string key, string val, string path);

        string iniPath = ".\\MyNotePad.ini"; // .ini파일의 fullpath
        public string iniLABEL = "";
        private void Form2_Load(object sender, EventArgs e)
        {
            // .ini 파일의 key-value 쌍의 value의 최대 사이즈
            StringBuilder buf = new StringBuilder(500);

            //Form2 관련
            GetPrivateProfileString("Form2", "LABEL", "", buf, 500, iniPath);
                iniLABEL = buf.ToString();
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form2 관련
            WritePrivateProfileString("Form2", "LABEL", $"{iniLABEL}", iniPath);
        }
    }
}
