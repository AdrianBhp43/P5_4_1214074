using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_1214074
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            string Course = "";
            string Date = "";

            if (rbDate1.Checked)
            {
                Date = "Monday 8 AM";
            }
            else if (rbDate2.Checked)
            {
                Date = "Tuesday 8 AM";
            }
            else if (rbDate3.Checked)
            {
                Date = "Wednesday 8 AM";
            }
            else if (rbDate4.Checked)
            {
                Date = "Thursday 8 AM";
            }
            else if (rbDate5.Checked)
            {
                Date = "Friday 8 AM";
            }
            else if (rbDate6.Checked)
            {
                Date = "Saturday - Sunday 8 AM";
            }


            if (cbBasic.Checked)
            {
                Course = Course + "Basic Alpine Course, ";
            }
            if (cbIntermediate.Checked)
            {
                Course = Course + "Intermediate Alpine Course, ";
            }
            if (cbAdvanced.Checked)
            {
                Course = Course + "Advanced Alpine Course, ";
            }
            if (cbAoraki.Checked)
            {
                Course = Course + "Climb Mt Aoraki, ";
            }
            if (cbSefton.Checked)
            {
                Course = Course + "Climb Mt Sefton, ";
            }
            if (cbAspiring.Checked)
            {
                Course = Course + "Climb Mt Aspiring, ";
            }


            if (tbNama.Text == "")
            {
                MessageBox.Show("Masukkan nama anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cLBGender.Text == "")
            {
                MessageBox.Show("Masukkan jenis kelamin anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Course == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan course", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Date == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan Date", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show
                ("Name\t\t: " + tbNama.Text +
                "\nGender\t: " + cLBGender.Text +
                "\nDate of Birth\t: " + dateTimeBirth.Text +
                "\nCourse List \t: " + Course +
                "\nChoose Date\t: " + Date,
                "Registration Form",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Button Selesai

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

