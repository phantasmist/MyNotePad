using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                char[] chArr = strOrigin.ToCharArray(); // 꼭 한개의 캐릭터로 떨어지진 않음
                byte[] bArr = Encoding.Default.GetBytes(chArr); //이걸 안쓰면 한글(2byte)은 짤림

                for (int i = 0; i < bArr.Length; i++)
                {
                    //{}:manipulator, format, 변환문자
                    //C#의 char값은 정수형과 호환되지 않는다
                    //2X가 아니라 X2임을 명심할 것
                    //tbMemo.Text += string.Format("{0:X2} ", (byte)strOrigin[i]);
                    //위 코드와 비교하면, encoding을 거치지 않으면 2byte 문자가 손실됨
                    tbMemo.Text += $"{bArr[i]:X2} "; //$" ": 보간 문자열(String Interpolation)
                    if (i % 16 == 15) tbMemo.Text += "\r\n";
                }
                //int cnt = 0;
                //foreach (byte ch in strOrigin)
                //{
                //    tbMemo.Text += string.Format("{0:2X} ", ch);
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
    }
}
