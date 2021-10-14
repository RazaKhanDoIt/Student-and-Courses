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
    public partial class CourseForm : Form
    {

        SqlDataAdapter da;


        DataSet dsCollegeDB;


        DataTable dtCourseForm;


        SqlCommandBuilder sqlBuilder;


        Course aCourse = new Course();

        public CourseForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            StudentForm courseForm = new StudentForm();
            this.Hide();
            courseForm.ShowDialog();
        }

        private void btnListCourse_Click(object sender, EventArgs e)
        {
            da.Fill(dsCollegeDB.Tables["Courses"]);
            dgvStud.DataSource = dsCollegeDB.Tables["Courses"];
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
           //You need the code in form load to bring information over-----------
            dsCollegeDB = new DataSet("CollegeDS");
            dtCourseForm = new DataTable("Courses");
            dsCollegeDB.Tables.Add(dtCourseForm);

            dtCourseForm.Columns.Add("CourseCode", typeof(string));
            dtCourseForm.Columns.Add("CourseTitle", typeof(string));
            dtCourseForm.Columns.Add("TotalHour", typeof(int));
            dtCourseForm.PrimaryKey = new DataColumn[] { dtCourseForm.Columns["CourseCode"] };


            da = new SqlDataAdapter("SELECT * FROM Courses", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da);
        }

        private void btnListCouseSet_Click(object sender, EventArgs e)
        {

        }

        private void btnCourseClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to leave?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                MainMenuFormcs mainForm = new MainMenuFormcs();
                mainForm.ShowDialog();
            }
            
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //valid input data
            DataRow dr = dtCourseForm.NewRow();
            dr["CourseCode"] = txtCourse.Text.Trim();
            dr["CourseTitle"] = txtCourseTitle.Text.Trim();
            dr["TotalHour"] = txtTotalHour.Text.Trim();
            dtCourseForm.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search by StudentId
            aCourse = new Course();
            //Data validation first : DO it yourself
            string searchId = (txtCourse.Text.Trim());
            DataRow dr = dtCourseForm.Rows.Find(searchId);
            if (dr != null)
            {
                txtCourse.Text = dr["CourseCode"].ToString();
                txtCourseTitle.Text = dr["CourseTitle"].ToString();
                txtTotalHour.Text = dr["TotalHour"].ToString();

            }
            else
            {
                MessageBox.Show("Course not found!", "Invalid Course Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //data validation do yourself
            //studentid : valid format
            string searchId = (txtCourse.Text.Trim());
            DataRow dr = dtCourseForm.Rows.Find(searchId);
            dr["CourseCode"] = (txtCourse.Text.Trim());
            dr["CourseTitle"] = txtCourseTitle.Text.Trim();
            dr["TotalHour"] = txtTotalHour.Text.Trim();
           
            MessageBox.Show(dr.RowState.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Make sure there is no course registered by this student
            string searchId =(txtCourse.Text.Trim());
            DataRow dr = dtCourseForm.Rows.Find(searchId);
            dr.Delete();
            MessageBox.Show(dr.RowState.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            da.Update(dsCollegeDB.Tables["Courses"]);
            MessageBox.Show("Database has been updated successfully.", "Confirmation");
        }
    }
}
