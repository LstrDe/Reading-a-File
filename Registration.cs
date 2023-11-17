using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reading_a_File
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
            string[] ListOfGender = new string[]
            {
                "Male",
                "Female"
            };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string docName = txtStudentNo.Text + ".txt";
            string docpath =
           Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] userInfo =
            {
                "Student No.:" + txtStudentNo.Text,
                "Full Name:" + txtLastName.Text + ", " + txtFirstName.Text + ", " +
                txtMiddleInitial.Text,
                "Program: " + cbPrograms.Text,
                "Gender:" + cbGender.Text,
                "Age:" + txtAge.Text,
                "Birthday:" + datePickerBirthday.Text,
                "Contact No.:" + txtContactNo.Text
             };
            using (StreamWriter outputFile = new
           StreamWriter(Path.Combine(docpath, docName)))
            {
                foreach (string info in userInfo)
                {
                    outputFile.WriteLine(info);
                }
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOpenTextFile records = new FrmOpenTextFile();
            records.ShowDialog();
            Close();
        }
    }
}


