using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.GUI;
using Lab3.DAL;
using Lab3.BLL;
using System.Data.SqlClient;

namespace Lab3.GUI
{
    public partial class StudentForm : Form
    {

       
        SqlDataAdapter da;

        DataSet dsCollegeDB;


        DataTable dtStudents;


        SqlCommandBuilder sqlBuilder;


        Student aStudent = new Student();


        public StudentForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to leave?", "Warning", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Hide();
                MainMenuFormcs mainForm = new MainMenuFormcs();
                mainForm.ShowDialog();
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // create an object of type DataSet and name it as CollegeDS
            dsCollegeDB = new DataSet("CollegeDB");
            // Create a DataTable; name : Students; add it to the DataSet object
            dtStudents = new DataTable("Students");
            dsCollegeDB.Tables.Add(dtStudents);
            //Create columns, add the columns to the DataTable Students
            dtStudents.Columns.Add("StudentId", typeof(Int32));
            dtStudents.Columns.Add("FirstName", typeof(string));
            dtStudents.Columns.Add("LastName", typeof(string));
            dtStudents.Columns.Add("Email", typeof(string));
            dtStudents.PrimaryKey = new DataColumn[] { dtStudents.Columns["StudentId"] };

            dtStudents.Columns["StudentId"].AutoIncrement = true;
            dtStudents.Columns["StudentId"].AutoIncrementStep = 1;
            dtStudents.Columns["StudentId"].AutoIncrementSeed = 1111111;

            da = new SqlDataAdapter("SELECT * FROM Students", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da);
        }

        private void btnListStud_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            dgvStud.DataSource = student.ListStudent();


            MessageBox.Show(UtilityDB.ConnectDB().State.ToString());
        }

        private void btnListDataSet_Click(object sender, EventArgs e)
        {
            da.Fill(dsCollegeDB.Tables["Students"]);
            dataGridView1.DataSource = dsCollegeDB.Tables["Students"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //input data validation

            //valid input data
            DataRow dr = dtStudents.NewRow();
            dr["FirstName"] = textBox1.Text.Trim();
            dr["LastName"] = textBox2.Text.Trim();
            dr["Email"] = txtMail.Text.Trim();
            dtStudents.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search by StudentId
            aStudent = new Student();
            //Data validation first : DO it yourself
            int searchId = Convert.ToInt32(txtStudent.Text.Trim());
            DataRow dr = dtStudents.Rows.Find(searchId);
            if (dr != null)
            {
                textBox1.Text= dr["FirstName"].ToString();
               textBox2.Text = dr["LastName"].ToString();
                txtMail.Text = dr["Email"].ToString();

            }
            else
            {
                MessageBox.Show("Student not found!", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //data validation do yourself
            //studentid : valid format
            int searchId = Convert.ToInt32(txtStudent.Text.Trim());
            DataRow dr = dtStudents.Rows.Find(searchId);
            dr["StudentID"] = Convert.ToInt32(txtStudent.Text.Trim());
            dr["FirstName"] = textBox1.Text.Trim();
            dr["LastName"] = textBox2.Text.Trim();
            dr["Email"] = txtMail.Text.Trim();
            MessageBox.Show(dr.RowState.ToString());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Make sure there is no course registered by this student
            int searchId = Convert.ToInt32(txtStudent.Text.Trim());
            DataRow dr = dtStudents.Rows.Find(searchId);
            dr.Delete();
            MessageBox.Show(dr.RowState.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            da.Update(dsCollegeDB.Tables["Students"]);
            MessageBox.Show("Database has been updated sucessfull.", "Confirmation");
        }

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            da.Update(dsCollegeDB.Tables["Students"]);
            MessageBox.Show("Database has been updated successfully.", "Confirmation");
           
        }
    }
}
