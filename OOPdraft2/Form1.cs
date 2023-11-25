using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_students_btn_Click(object sender, EventArgs e)
        {
            // Open the form to add students
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }
        
        private void show_Students_btn_Click(object sender, EventArgs e)
        {
            // Open the form to show students
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        // // search_Student_Btn
        private void search_Student_Btn_Click(object sender, EventArgs e)
        {
            // Open the form for optional search functionality
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
        //exitBtn
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void show_Students_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
