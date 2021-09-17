using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //로또 번호 넣을 배열
            int[] lotto = new int[6];

            //번호 생성
            //6번 반복하며 각 배열에 값 넣기
            for (int i = 0; i < 6; i++)
            {
                //랜덤값 생성
                Random random = new Random();
                lotto[i] = random.Next(1, 45);

                //중복값 체크
                for (int j = 0; j < i; j++)
                {
                    if (lotto[i] == lotto[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            
            //배열 정렬
            Array.Sort(lotto);

            //각 번호 마다 공백으로 띄우기
            string temp = "";
            foreach (var item in lotto)
            {
                 temp += item + " ";
            }
            
            this.label1.Text = temp;
        }
    }
}
