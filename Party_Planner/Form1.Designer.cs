
namespace Party_Planner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.costLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_Healthy = new System.Windows.Forms.CheckBox();
            this.chk_Fancy = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tex_cakeWritig = new System.Windows.Forms.TextBox();
            this.lbl_tooLong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_Fancy_Birthday = new System.Windows.Forms.CheckBox();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(216, 272);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chk_Healthy);
            this.tabPage1.Controls.Add(this.chk_Fancy);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(208, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "저녁 파티";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costLabel.Location = new System.Drawing.Point(67, 183);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(112, 25);
            this.costLabel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost";
            // 
            // chk_Healthy
            // 
            this.chk_Healthy.AutoSize = true;
            this.chk_Healthy.Location = new System.Drawing.Point(19, 132);
            this.chk_Healthy.Name = "chk_Healthy";
            this.chk_Healthy.Size = new System.Drawing.Size(108, 19);
            this.chk_Healthy.TabIndex = 9;
            this.chk_Healthy.Text = "Healthy Option";
            this.chk_Healthy.UseVisualStyleBackColor = true;
            this.chk_Healthy.CheckedChanged += new System.EventHandler(this.chk_Healthy_CheckedChanged);
            // 
            // chk_Fancy
            // 
            this.chk_Fancy.AutoSize = true;
            this.chk_Fancy.Checked = true;
            this.chk_Fancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Fancy.Location = new System.Drawing.Point(19, 92);
            this.chk_Fancy.Name = "chk_Fancy";
            this.chk_Fancy.Size = new System.Drawing.Size(125, 19);
            this.chk_Fancy.TabIndex = 8;
            this.chk_Fancy.Text = "Fancy Decorations";
            this.chk_Fancy.UseVisualStyleBackColor = true;
            this.chk_Fancy.CheckedChanged += new System.EventHandler(this.chk_Fancy_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(19, 44);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tex_cakeWritig);
            this.tabPage2.Controls.Add(this.lbl_tooLong);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.chk_Fancy_Birthday);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(208, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "생일 파티";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tex_cakeWritig
            // 
            this.tex_cakeWritig.Location = new System.Drawing.Point(24, 160);
            this.tex_cakeWritig.Name = "tex_cakeWritig";
            this.tex_cakeWritig.Size = new System.Drawing.Size(160, 23);
            this.tex_cakeWritig.TabIndex = 20;
            this.tex_cakeWritig.Text = "Happy Birthday";
            this.tex_cakeWritig.TextChanged += new System.EventHandler(this.tex_cakeWritig_TextChanged);
            // 
            // lbl_tooLong
            // 
            this.lbl_tooLong.AutoSize = true;
            this.lbl_tooLong.BackColor = System.Drawing.Color.Red;
            this.lbl_tooLong.ForeColor = System.Drawing.Color.Black;
            this.lbl_tooLong.Location = new System.Drawing.Point(109, 137);
            this.lbl_tooLong.Name = "lbl_tooLong";
            this.lbl_tooLong.Size = new System.Drawing.Size(67, 15);
            this.lbl_tooLong.TabIndex = 19;
            this.lbl_tooLong.Text = "TOO LONG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cake Wniting\r\n";
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthdayCost.Location = new System.Drawing.Point(72, 203);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(112, 15);
            this.birthdayCost.TabIndex = 17;
            this.birthdayCost.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cost";
            // 
            // chk_Fancy_Birthday
            // 
            this.chk_Fancy_Birthday.AutoSize = true;
            this.chk_Fancy_Birthday.Location = new System.Drawing.Point(24, 102);
            this.chk_Fancy_Birthday.Name = "chk_Fancy_Birthday";
            this.chk_Fancy_Birthday.Size = new System.Drawing.Size(125, 19);
            this.chk_Fancy_Birthday.TabIndex = 14;
            this.chk_Fancy_Birthday.Text = "Fancy Decorations";
            this.chk_Fancy_Birthday.UseVisualStyleBackColor = true;
            this.chk_Fancy_Birthday.CheckedChanged += new System.EventHandler(this.chk_Fancy_Birthday_CheckedChanged);
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(24, 54);
            this.numberBirthday.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 23);
            this.numberBirthday.TabIndex = 13;
            this.numberBirthday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 272);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner 2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_Healthy;
        private System.Windows.Forms.CheckBox chk_Fancy;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_Fancy_Birthday;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_tooLong;
        private System.Windows.Forms.TextBox tex_cakeWritig;
    }
}

