using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> students;
        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() { "Engin Demiroğ", "Derin Demiroğ", "Salih Demiroğ" };
            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            students.Add(tbxStudentName.Text);
            lbxStudentList.Items.Clear();

            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            students.Remove(lbxStudentList.SelectedItem.ToString());
            lbxStudentList.Items.Clear();

            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }
    }
}
