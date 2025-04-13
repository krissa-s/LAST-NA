using StudentEnroll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEM
{
    public partial class mainpage : Form
    {
        MySQLConnector mySQLConnector = new MySQLConnector();
        public mainpage()
        {
            InitializeComponent();
        }
        private void SYSTEM_Load(object sender, EventArgs e)
        {
            studentgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            coursegrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            enrollmentgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadStudent();
            LoadCourse();
            LoadEnrollment();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainpage_Load(object sender, EventArgs e)
        {
        }
        private void LoadStudent()
        {
            studentgrid.DataSource = mySQLConnector.FetchStudent();
        }
        private void LoadCourse()
        {
            coursegrid.DataSource = mySQLConnector.FetchStudent();
        }
        private void LoadEnrollment()
        {
            enrollmentgrid.DataSource = mySQLConnector.FetchStudent();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentadd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(studid.Text, out int stud_id))
            {
                MessageBox.Show("Please enter a valid School id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mySQLConnector.InsertStudent(stud_id, firstname.Text, middleinitial.Text, lastname.Text, emailadd.Text, studenttype.Text);
            LoadStudent();
        }

        private void studentupdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(studid.Text, out int stud_id))
            {
                MessageBox.Show("Please enter a valid School id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mySQLConnector.UpdateStudent(stud_id, firstname.Text, middleinitial.Text, lastname.Text, emailadd.Text, studenttype.Text);
            LoadStudent();
        }

        private void studentdelete_Click(object sender, EventArgs e)
        {
            if (studentgrid.SelectedRows.Count > 0)
            {
                int rowIndex = studentgrid.SelectedRows[0].Index; if (int.TryParse(studentgrid.Rows[rowIndex].Cells["stud_id"].Value.ToString(), out int stud_id))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                          "Confirm Delete",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        mySQLConnector.DeleteStudent(stud_id);


                        studentgrid.DataSource = mySQLConnector.FetchStudent();

                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid BookID format. Please select a valid record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void studentclear_Click(object sender, EventArgs e)
        {
            studid.Clear();
            firstname.Clear();
            middleinitial.Clear();
            lastname.Clear();
            emailadd.Clear();
            studenttype.Clear();
        }

        private void studentsearch_Click(object sender, EventArgs e)
        {
            string keyword = studentsearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            studentgrid.DataSource = mySQLConnector.SearchStudent(keyword);
        }
        private void studentgrid_SelectionChanged(object sender, EventArgs e)
        {
            if (studentgrid.SelectedRows.Count > 0)
            {
                var rowIndex = studentgrid.SelectedRows[0].Index;
                DataGridViewRow row = studentgrid.Rows[rowIndex];
                studid.Text = row.Cells[0].Value?.ToString() ?? "";
                firstname.Text = row.Cells[1].Value?.ToString() ?? "";
                middleinitial.Text = row.Cells[2].Value?.ToString() ?? "";
                lastname.Text = row.Cells[3].Value?.ToString() ?? "";
                emailadd.Text = row.Cells[4].Value?.ToString() ?? "";
                studenttype.Text = row.Cells[5].Value?.ToString() ?? "";
            }

        }
    }
}
