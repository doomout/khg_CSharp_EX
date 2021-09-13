using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_Management_System
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            
            workerBeeJob.SelectedIndex = 0;
            
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "꽃에서 꿀 따오기", "꿀 만들기"}, 175);
            workers[1] = new Worker(new string[] { "알 돌보기", "새끼 돌보기" }, 114);
            workers[2] = new Worker(new string[] { "벌집 수선", "벌집 지키기" }, 149);
            workers[3] = new Worker(new string[] { "꽃에서 꿀 따오기",  "꿀 만들기", "알 돌보기",  "새끼 돌보기", "벌집 수선", "벌집 지키기" }, 155);
            
            queen = new Queen(workers, 275);
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
            {
                MessageBox.Show("No workers are available to do the job '" + workerBeeJob.Text + "'", "The queen bee says...");
            }
            else
            {
                MessageBox.Show("The job '" +workerBeeJob.Text+"' will be done in " +shifts.Value + " shifts", "The queen bee says....");
            }
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
