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

namespace $safeprojectname$
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            father_Name_Label.Click += new System.EventHandler(this.label4_Click);
            add_student_title.Click += new System.EventHandler(this.add_student_title_Click);
        }
        //saveBtn1
        private void saveBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validating Input
                if (string.IsNullOrWhiteSpace(nametextBox1.Text) ||
                    string.IsNullOrWhiteSpace(lastNameTextBox1.Text) ||
                    string.IsNullOrWhiteSpace(fatherNameTextBox1.Text) ||
                    string.IsNullOrWhiteSpace(dateOfBirthTextBox1.Text) ||
                    string.IsNullOrWhiteSpace(nationalityTextBox1.Text))

                {

                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // checking for character separators

                char separator = ';';
                if (nametextBox1.Text.Contains(separator) || lastNameTextBox1.Text.Contains(separator) ||
                    fatherNameTextBox1.Text.Contains(separator) || dateOfBirthTextBox1.Text.Contains(separator) ||
                    nationalityTextBox1.Text.Contains(separator))
                {
                    MessageBox.Show("Fields cannot contain the separator character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Saving student data to file
                using (StreamWriter sw = new StreamWriter("Students.txt", true))
                {
                    sw.WriteLine($"{nametextBox1.Text};{lastNameTextBox1.Text};{fatherNameTextBox1.Text};" +
                        $"{dateOfBirthTextBox1.Text};{nationalityTextBox1.Text}");
                }

                // clearing after saving

                // Clear textboxes after saving
                nametextBox1.Clear();
                lastNameTextBox1.Clear();
                fatherNameTextBox1.Clear();
                dateOfBirthTextBox1.Clear();
                nationalityTextBox1.Clear();


                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cancelBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // adding event Handler for Name textbox
        private void nametextBox1_TextChanged(object sender, EventArgs e)
        {
            string enteredName = nametextBox1.Text;

        }

        private void add_student_title_Click(object sender, EventArgs e)
        {
            // Get student details from textboxes
            // include {joinDatetextBox5.Text}; once I add it bc I forgot this part in the form
           string studentDetails = $"{nametextBox1.Text};{lastNameTextBox1.Text};{fatherNameTextBox1.Text};{dateOfBirthTextBox1.Text};{nationalityTextBox1.Text}";

            // Save to file
            File.AppendAllText("Students.txt", studentDetails + Environment.NewLine);

            // Clear textboxes after saving
            // ClearTextBoxes();

       }
        // Manually adding the Click event handler
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

    }
}
