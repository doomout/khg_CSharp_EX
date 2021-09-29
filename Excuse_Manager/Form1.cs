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

namespace Excuse_Manager
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }

        //컨트롤에 대한 내용 갱신
        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
        }

        private void folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //사용자가 폴더를 선택하면 각 버튼 활성화
                selectedFolder = folderBrowserDialog1.SelectedPath;
                save.Enabled = true;
                open.Enabled = true;
                randomExcuse.Enabled = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            //설명 창이나 결과 창이 비어 있으면 에러 메세지 띄움
            if (String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("변명이나 결과를 지정해라!!",
                     "저장할 수 없다!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //폴더의 디렉토리 위치
            saveFileDialog1.InitialDirectory = selectedFolder;
            //txt 파일을 저장할꺼야
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //파일명은 변명 텍스트명으로 할꺼야
            saveFileDialog1.FileName = description.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("변명 저장~!");
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                //폴더 디렉토리 위치라능
                openFileDialog1.InitialDirectory = selectedFolder;
                //형식은 txt 방식
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                //파일 명은 변명
                openFileDialog1.FileName = description.Text + ".txt";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void randomExcuse_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                //랜덤 변명 생성자
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }
        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                      "The current excuse has not been saved. Continue?",
                       "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }
    }
}
