using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FirstProject
{
    public partial class Management : Form
    {
        List<Student> students = new List<Student>();
        int referenceIndex = 0;
        public Management()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                var student = new Student();
                student.Id = i;
                student.Name = "Nguyen Van " + i.ToString();
                student.Age = 20 + i;
                student.Created = DateTime.Now;
                student.PhoneNumber = "037777876" + i.ToString();
                student.Email = "helloco" + i.ToString() + "@gmail.com";
                student.Decription = "Bad Boy";
                students.Add(student);
            }

            dgvStudent.DataSource = new BindingSource() { DataSource = students };
            dgvStudent.AutoResizeColumns();
            dgvStudent.ReadOnly = true;

            foreach (DataGridViewColumn column in dgvStudent.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                var student = new Student();
                student.Id = int.Parse(txtID.Text);
                student.Name = txtName.Text;
                student.Age = int.Parse(txtAge.Text);
                student.Created = DateTime.Now;
                student.PhoneNumber = txtPhoneNumber.Text;
                student.Email = txtEmail.Text;
                student.Decription = txtDescription.Text;

                if (IsIDUnique(student.Id))
                {
                    throw new ArgumentException("ID already exists. Please enter a unique ID.");
                }

                if (student.Id <= 0)
                {
                    throw new ArgumentException("Invalid ID format. ID must be a positive number.");
                }

                if (string.IsNullOrEmpty(student.Name))
                {
                    throw new ArgumentException("Name is required.");
                }

                if (student.Age <= 0)
                {
                    throw new ArgumentException("Invalid age format. Age must be a positive number.");
                }

                if (!IsNumeric(student.PhoneNumber))
                {
                    throw new ArgumentException("Invalid phone number format. Phone number must be a numeric value.");
                }

                if (!Regex.IsMatch(student.Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    throw new ArgumentException("Invalid email format.");
                }

                students.Add(student);
                dgvStudent.DataSource = new BindingSource() { DataSource = students };
                dgvStudent.AutoResizeColumns();
                dgvStudent.ReadOnly = true;
                MessageBox.Show("Student created successfully!\n\nID: " + student.Id
                    + "\nName: " + student.Name + "\nAge: " + student.Age
                    + "\nPhone Number: " + student.PhoneNumber + "\nEmail: " + student.Email);
                txtID.Text = "";
                txtName.Text = "";
                txtAge.Text = "";
                txtPhoneNumber.Text = "";
                txtEmail.Text = "";
                txtDescription.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format. Please enter valid numeric values.",
                    "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Validation error occurred:\n\n" + ex.Message,
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsNumeric(string value)
        {
            return double.TryParse(value, out _);
        }

        private bool IsIDUnique(int id)
        {
            return students.Any(student => student.Id == id);
        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = students[e.RowIndex];
            referenceIndex = e.RowIndex;
            txtID.Text = student.Id.ToString();
            txtAge.Text = student.Age.ToString();
            txtName.Text = student.Name.ToString();
            txtPhoneNumber.Text = student.PhoneNumber.ToString();
            txtEmail.Text = student.Email.ToString();
            txtDescription.Text = student.Decription.ToString();
            txtID.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student();
                student.Id = int.Parse(txtID.Text);
                student.Name = txtName.Text;
                student.Age = int.Parse(txtAge.Text);
                student.Created = DateTime.Now;
                student.PhoneNumber = txtPhoneNumber.Text;
                student.Email = txtEmail.Text;
                student.Decription = txtDescription.Text;

                if (student.Id <= 0)
                {
                    throw new ArgumentException("Invalid ID format. ID must be a positive number.");
                }

                if (string.IsNullOrEmpty(student.Name))
                {
                    throw new ArgumentException("Name is required.");
                }

                if (student.Age <= 0)
                {
                    throw new ArgumentException("Invalid age format. Age must be a positive number.");
                }

                if (!IsNumeric(student.PhoneNumber))
                {
                    throw new ArgumentException("Invalid phone number format. Phone number must be a numeric value.");
                }

                if (!Regex.IsMatch(student.Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    throw new ArgumentException("Invalid email format.");
                }

                txtID.Enabled = true;
                students[referenceIndex] = student;
                dgvStudent.DataSource = new BindingSource() { DataSource = students };
                dgvStudent.AutoResizeColumns();
                dgvStudent.ReadOnly = true;
                MessageBox.Show("Student updated successfully!\n\nID: " + student.Id +
                    "\nName: " + student.Name + "\nAge: " + student.Age + "\nPhone Number: " +
                    student.PhoneNumber + "\nEmail: " + student.Email);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format. Please enter valid numeric values.",
                    "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Validation error occurred:\n\n" + ex.Message,
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtDescription.Text = "";


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int idToRemove = int.Parse(txtID.Text);
            RemoveStudentById(students, idToRemove);
        }

        public void RemoveStudentById(List<Student> students, int id)
        {
            int index = students.FindIndex(student => student.Id == id);

            if (index != -1)
            {
                students.RemoveAt(index);
                Console.WriteLine($"Student with ID {id} has been removed.");
                dgvStudent.DataSource = new BindingSource() { DataSource = students };
                dgvStudent.AutoResizeColumns();
                dgvStudent.ReadOnly = true;
            }
            else
            {
                Console.WriteLine($"No student found with ID {id}.");
            }
        }
    }
}
