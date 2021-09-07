using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, chk_Healthy.Checked, chk_Fancy.Checked);
            
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, chk_Fancy_Birthday.Checked, tex_cakeWritig.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            //글자수가 초과 되었을 때는 true, 아닐 때는 false 반환
            lbl_tooLong.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            birthdayCost.Text = cost.ToString("c");
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.Cost;
            costLabel.Text = cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void chk_Fancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations= this.chk_Fancy.Checked;
            DisplayDinnerPartyCost();
        }

        private void chk_Healthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = chk_Healthy.Checked;
            DisplayDinnerPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void chk_Fancy_Birthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = chk_Fancy_Birthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void tex_cakeWritig_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = tex_cakeWritig.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
