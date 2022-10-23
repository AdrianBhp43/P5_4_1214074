namespace P5_4_1214074
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.cLBGender = new System.Windows.Forms.ComboBox();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.Course = new System.Windows.Forms.GroupBox();
            this.cbAspiring = new System.Windows.Forms.CheckBox();
            this.cbSefton = new System.Windows.Forms.CheckBox();
            this.cbAdvanced = new System.Windows.Forms.CheckBox();
            this.cbIntermediate = new System.Windows.Forms.CheckBox();
            this.cbAoraki = new System.Windows.Forms.CheckBox();
            this.cbBasic = new System.Windows.Forms.CheckBox();
            this.Date = new System.Windows.Forms.GroupBox();
            this.rbDate6 = new System.Windows.Forms.RadioButton();
            this.rbDate5 = new System.Windows.Forms.RadioButton();
            this.rbDate4 = new System.Windows.Forms.RadioButton();
            this.rbDate3 = new System.Windows.Forms.RadioButton();
            this.rbDate2 = new System.Windows.Forms.RadioButton();
            this.rbDate1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTampil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Course.SuspendLayout();
            this.Date.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.TabIndex = 10;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(612, 83);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(298, 26);
            this.tbNama.TabIndex = 4;
            // 
            // cLBGender
            // 
            this.cLBGender.FormattingEnabled = true;
            this.cLBGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cLBGender.Location = new System.Drawing.Point(614, 148);
            this.cLBGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cLBGender.Name = "cLBGender";
            this.cLBGender.Size = new System.Drawing.Size(204, 28);
            this.cLBGender.TabIndex = 5;
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(612, 212);
            this.dateTimeBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(298, 26);
            this.dateTimeBirth.TabIndex = 6;
            // 
            // Course
            // 
            this.Course.Controls.Add(this.cbAspiring);
            this.Course.Controls.Add(this.cbSefton);
            this.Course.Controls.Add(this.cbAdvanced);
            this.Course.Controls.Add(this.cbIntermediate);
            this.Course.Controls.Add(this.cbAoraki);
            this.Course.Controls.Add(this.cbBasic);
            this.Course.Location = new System.Drawing.Point(118, 295);
            this.Course.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Course.Name = "Course";
            this.Course.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Course.Size = new System.Drawing.Size(412, 242);
            this.Course.TabIndex = 0;
            this.Course.TabStop = false;
            this.Course.Text = "Course List";
            // 
            // cbAspiring
            // 
            this.cbAspiring.AutoSize = true;
            this.cbAspiring.Location = new System.Drawing.Point(226, 168);
            this.cbAspiring.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAspiring.Name = "cbAspiring";
            this.cbAspiring.Size = new System.Drawing.Size(118, 24);
            this.cbAspiring.TabIndex = 6;
            this.cbAspiring.Text = "Mt. Aspiring";
            this.cbAspiring.UseVisualStyleBackColor = true;
            // 
            // cbSefton
            // 
            this.cbSefton.AutoSize = true;
            this.cbSefton.Location = new System.Drawing.Point(226, 114);
            this.cbSefton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSefton.Name = "cbSefton";
            this.cbSefton.Size = new System.Drawing.Size(109, 24);
            this.cbSefton.TabIndex = 5;
            this.cbSefton.Text = "Mt. Sefton";
            this.cbSefton.UseVisualStyleBackColor = true;
            // 
            // cbAdvanced
            // 
            this.cbAdvanced.AutoSize = true;
            this.cbAdvanced.Location = new System.Drawing.Point(9, 168);
            this.cbAdvanced.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAdvanced.Name = "cbAdvanced";
            this.cbAdvanced.Size = new System.Drawing.Size(169, 24);
            this.cbAdvanced.TabIndex = 3;
            this.cbAdvanced.Text = "Adv. Alpine Course";
            this.cbAdvanced.UseVisualStyleBackColor = true;
            // 
            // cbIntermediate
            // 
            this.cbIntermediate.AutoSize = true;
            this.cbIntermediate.Location = new System.Drawing.Point(9, 114);
            this.cbIntermediate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIntermediate.Name = "cbIntermediate";
            this.cbIntermediate.Size = new System.Drawing.Size(161, 24);
            this.cbIntermediate.TabIndex = 2;
            this.cbIntermediate.Text = "Int. Alpine Course";
            this.cbIntermediate.UseVisualStyleBackColor = true;
            // 
            // cbAoraki
            // 
            this.cbAoraki.AutoSize = true;
            this.cbAoraki.Location = new System.Drawing.Point(226, 66);
            this.cbAoraki.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAoraki.Name = "cbAoraki";
            this.cbAoraki.Size = new System.Drawing.Size(147, 24);
            this.cbAoraki.TabIndex = 4;
            this.cbAoraki.Text = "Mt. Aoraki/Cook";
            this.cbAoraki.UseVisualStyleBackColor = true;
            // 
            // cbBasic
            // 
            this.cbBasic.AutoSize = true;
            this.cbBasic.Location = new System.Drawing.Point(9, 65);
            this.cbBasic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBasic.Name = "cbBasic";
            this.cbBasic.Size = new System.Drawing.Size(177, 24);
            this.cbBasic.TabIndex = 0;
            this.cbBasic.Text = "Basic Alpine Course";
            this.cbBasic.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            this.Date.Controls.Add(this.rbDate6);
            this.Date.Controls.Add(this.rbDate5);
            this.Date.Controls.Add(this.rbDate4);
            this.Date.Controls.Add(this.rbDate3);
            this.Date.Controls.Add(this.rbDate2);
            this.Date.Controls.Add(this.rbDate1);
            this.Date.Location = new System.Drawing.Point(638, 295);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Date.Name = "Date";
            this.Date.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Date.Size = new System.Drawing.Size(420, 242);
            this.Date.TabIndex = 0;
            this.Date.TabStop = false;
            this.Date.Text = "Choose Date";
            // 
            // rbDate6
            // 
            this.rbDate6.AutoSize = true;
            this.rbDate6.Location = new System.Drawing.Point(186, 166);
            this.rbDate6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDate6.Name = "rbDate6";
            this.rbDate6.Size = new System.Drawing.Size(171, 24);
            this.rbDate6.TabIndex = 5;
            this.rbDate6.TabStop = true;
            this.rbDate6.Text = "Saturday && Sunday";
            this.rbDate6.UseVisualStyleBackColor = true;
            // 
            // rbDate5
            // 
            this.rbDate5.AutoSize = true;
            this.rbDate5.Location = new System.Drawing.Point(186, 112);
            this.rbDate5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDate5.Name = "rbDate5";
            this.rbDate5.Size = new System.Drawing.Size(77, 24);
            this.rbDate5.TabIndex = 4;
            this.rbDate5.TabStop = true;
            this.rbDate5.Text = "Friday";
            this.rbDate5.UseVisualStyleBackColor = true;
            // 
            // rbDate4
            // 
            this.rbDate4.AutoSize = true;
            this.rbDate4.Location = new System.Drawing.Point(186, 65);
            this.rbDate4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDate4.Name = "rbDate4";
            this.rbDate4.Size = new System.Drawing.Size(99, 24);
            this.rbDate4.TabIndex = 3;
            this.rbDate4.TabStop = true;
            this.rbDate4.Text = "Thursday";
            this.rbDate4.UseVisualStyleBackColor = true;
            // 
            // rbDate3
            // 
            this.rbDate3.AutoSize = true;
            this.rbDate3.Location = new System.Drawing.Point(9, 166);
            this.rbDate3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDate3.Name = "rbDate3";
            this.rbDate3.Size = new System.Drawing.Size(118, 24);
            this.rbDate3.TabIndex = 2;
            this.rbDate3.TabStop = true;
            this.rbDate3.Text = "Wednesday";
            this.rbDate3.UseVisualStyleBackColor = true;
            // 
            // rbDate2
            // 
            this.rbDate2.AutoSize = true;
            this.rbDate2.Location = new System.Drawing.Point(9, 112);
            this.rbDate2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDate2.Name = "rbDate2";
            this.rbDate2.Size = new System.Drawing.Size(94, 24);
            this.rbDate2.TabIndex = 1;
            this.rbDate2.TabStop = true;
            this.rbDate2.Text = "Tuesday";
            this.rbDate2.UseVisualStyleBackColor = true;
            // 
            // rbDate1
            // 
            this.rbDate1.AutoSize = true;
            this.rbDate1.Location = new System.Drawing.Point(9, 63);
            this.rbDate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDate1.Name = "rbDate1";
            this.rbDate1.Size = new System.Drawing.Size(94, 24);
            this.rbDate1.TabIndex = 0;
            this.rbDate1.TabStop = true;
            this.rbDate1.Text = "Monday ";
            this.rbDate1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of Birth";
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(454, 565);
            this.btnTampil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(112, 35);
            this.btnTampil.TabIndex = 7;
            this.btnTampil.Text = "Tampilkan";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 565);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 702);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.dateTimeBirth);
            this.Controls.Add(this.cLBGender);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Technical Alpine Course ";
            this.Course.ResumeLayout(false);
            this.Course.PerformLayout();
            this.Date.ResumeLayout(false);
            this.Date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.ComboBox cLBGender;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.GroupBox Course;
        private System.Windows.Forms.CheckBox cbAoraki;
        private System.Windows.Forms.CheckBox cbBasic;
        private System.Windows.Forms.GroupBox Date;
        private System.Windows.Forms.CheckBox cbAspiring;
        private System.Windows.Forms.CheckBox cbSefton;
        private System.Windows.Forms.CheckBox cbAdvanced;
        private System.Windows.Forms.CheckBox cbIntermediate;
        private System.Windows.Forms.RadioButton rbDate6;
        private System.Windows.Forms.RadioButton rbDate5;
        private System.Windows.Forms.RadioButton rbDate4;
        private System.Windows.Forms.RadioButton rbDate3;
        private System.Windows.Forms.RadioButton rbDate2;
        private System.Windows.Forms.RadioButton rbDate1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button button2;
    }
}

