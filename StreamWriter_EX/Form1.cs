using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamWriter_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Flobbo f = new Flobbo("blue yellow");
            StreamWriter sw = f.Snobbo();
            /*
          실행 시  아래와 같이 저장
            blue yellow
            green purple
            red orange
         */
            //blue yellow -> green purple -> red orange
            f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
        }
    }

    internal class Flobbo
    {
        private string Zap;
        //생성자
        public Flobbo(string Zap)
        {
            this.Zap = Zap;
        }
        //스트림 쓰기 macaw.txt 에 쓰기
        public StreamWriter Snobbo()
        {
            return new StreamWriter("macaw.txt");
        }

        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(Zap);
            Zap = "green purple";
            return false;
        }
        public bool Blobbo(bool Already, StreamWriter sw)
        {
            if (Already)
            {
                sw.WriteLine(Zap);
                sw.Close();
                return false;
            }
            else
            {
                sw.WriteLine(Zap);
                Zap = "red orange";
                return true;
            }
        }
    }
}
