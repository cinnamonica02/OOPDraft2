using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form3 : Form
    {
        private int currentIndex = 0;
        private List<string> students;
        public Form3()
        {
            InitializeComponent();
            LoadStudents();
            DisplayStudents();
        }

        private void LoadStudents()
        {
            try
            {
                students = File.ReadAllLines("Students.txt").ToList();
            }
            catch (FileNotFoundException)
            {
                // handle case when file is not found
                students = new List<string>();
            }
        }

        private void DisplayStudents()
        {
            if (students.Count > 0)
            {
                string[] currentStudent = students[currentIndex].Split(';');
                textBox1.Text = currentStudent[0];
                textBox2.Text = currentStudent[1];
                textBox3.Text = currentStudent[2];
                textBox4.Text = currentStudent[3];
                textBox5.Text = currentStudent[4];
                page_marker.Text = $"{currentIndex + 1} / {students.Count}";
            }
            else
            {
                ClearTextBoxes();
                page_marker.Text = "0/0";
            }
        }

        private void ClearTextBoxes()
        {
            // Clear all textBoxes
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + students.Count) % students.Count;
            DisplayStudents();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % students.Count;
            DisplayStudents();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            // Implement backward navigation for the second "Back" button
            currentIndex = (currentIndex - 1 + students.Count) % students.Count;
            DisplayStudents();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (students.Count > 0)
                {
                    students.RemoveAt(currentIndex);
                    File.WriteAllLines("Students.txt", students);
                    currentIndex = Math.Min(currentIndex, students.Count - 1);
                    DisplayStudents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

       
    }
    

