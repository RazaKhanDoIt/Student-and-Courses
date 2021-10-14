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
    public partial class CourseRegistration : Form
    {

        SqlDataAdapter da3;


        //DataSetdsCollegeDB;


        DataTable dtCourseRegForm;


        SqlCommandBuilder sqlBuilder3;


        Course aRegCourse = new Course();
        //----------------------------------
        SqlDataAdapter da2;


        //DataSetdsCollegeDB;


        DataTable dtCourseForm;


        SqlCommandBuilder sqlBuilder2;


        Course aCourse = new Course();
        //--------------------------------------------
        SqlDataAdapter da;

        DataSet dsCollegeDB;


        DataTable dtStudents;


        SqlCommandBuilder sqlBuilder;


        Student aStudent = new Student();
        public CourseRegistration()
        {
            InitializeComponent();
        }

        private void lstStudDB_Click(object sender, EventArgs e)
        {
            DataTable CollegeRegForm = dsCollegeDB.Tables["CollegeRegForm"];
            dgvStud.Rows.Clear();
            foreach (DataRow aRow in CollegeRegForm.Rows)
            {
                string currentStudent = aRow["StudentId"].ToString();
                if (currentStudent == txtStudId.Text.Trim())
                {
                    string tempcid = aRow["CourseCode"].ToString();
                    foreach(DataRow courseRow in dsCollegeDB.Tables["Courses"].Rows)
                    {
                        string currentCourse = courseRow["CourseCode"].ToString();
                        if ( currentCourse.ToLower() == tempcid)
                        {
                            dgvStud.Rows.Add(courseRow["CourseCode"].ToString(), courseRow["CourseTitle"].ToString(), aRow["RegistrationDate"].ToString(), aRow["StartingDate"].ToString(), aRow["EndingDate"].ToString());
                            break;
                        }
                    }
                }
            }
            //da.Fill(dsCollegeDB.Tables["Students"]);
            //dgvStud.DataSource = dsCollegeDB.Tables["Students"];
        }

        private void txtGetStud_Click(object sender, EventArgs e)
        {
            //search by StudentId
            aStudent = new Student();
            //Data validation first : DO it yourself
            int searchId = Convert.ToInt32(txtStudId.Text.Trim());
            DataRow dr = dtStudents.Rows.Find(searchId);
            if (dr != null)
            {
                lblStudInfo.Text = dr["FirstName"].ToString();
                lblStudInfo.Text += "\n"+ dr["LastName"].ToString();
                lblStudInfo.Text += "\n" + dr["Email"].ToString();

            }
            else
            {
                MessageBox.Show("Student not found!", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CourseRegistration_Load(object sender, EventArgs e)
        {

            dsCollegeDB = new DataSet("CollegeDS");

            //---------------------------------------------------
            //dsCollegeDB = new DataSet("CollegeDS");
            dtCourseForm = new DataTable("Courses");
           dsCollegeDB.Tables.Add(dtCourseForm);

            dtCourseForm.Columns.Add("CourseCode", typeof(string));
            dtCourseForm.Columns.Add("CourseTitle", typeof(string));
            dtCourseForm.Columns.Add("TotalHour", typeof(int));
            dtCourseForm.PrimaryKey = new DataColumn[] { dtCourseForm.Columns["CourseCode"] };


            da2 = new SqlDataAdapter("SELECT * FROM Courses", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da2);
            da2.Fill(dsCollegeDB.Tables["Courses"]);

            //------------------------------------------------
            // create an object of type DataSet and name it as CollegeDS
            //dsCollegeDB = new DataSet("CollegeDB");
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
            da.Fill(dsCollegeDB.Tables["Students"]);

            //------------------------------------------------------------------

            
            dtCourseRegForm = new DataTable("CollegeRegForm");
            dsCollegeDB.Tables.Add(dtCourseRegForm);

            dtCourseRegForm.Columns.Add("StudentId", typeof(Int32));
            dtCourseRegForm.Columns.Add("CourseCode", typeof(string));
            dtCourseRegForm.Columns.Add("RegistrationDate", typeof(string));
            dtCourseRegForm.Columns.Add("StartingDate", typeof(string));
            dtCourseRegForm.Columns.Add("EndingDate", typeof(string));
            dtCourseRegForm.PrimaryKey = new DataColumn[] { dtCourseRegForm.Columns["StudentId"], dtCourseRegForm.Columns["CourseCode"] };


            da3 = new SqlDataAdapter("SELECT * FROM StudentCourses", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da3);
            da3.Fill(dsCollegeDB.Tables["CollegeRegForm"]);

            DataRelation drStoSC = new DataRelation("StoSC", dtStudents.Columns["StudentId"], dtCourseRegForm.Columns["StudentId"]);
            DataRelation drCtoSC = new DataRelation("CtoSC", dtCourseForm.Columns["CourseCode"], dtCourseRegForm.Columns["CourseCode"]);

            dsCollegeDB.Relations.Add(drStoSC);
            dsCollegeDB.Relations.Add(drCtoSC);

        }

        private void getCourseCode_Click(object sender, EventArgs e)
        {
            //search by StudentId
            aCourse = new Course();
            //Data validation first : DO it yourself
            string searchId = (txtCourseCode.Text.Trim());
            DataRow dr = dtCourseForm.Rows.Find(searchId);
            if (dr != null)
            {
                lblCourseInfo.Text = dr["CourseCode"].ToString();
                lblCourseInfo.Text += "\n" + dr["CourseTitle"].ToString();
                lblCourseInfo.Text += "\n" + dr["TotalHour"].ToString();

            }
            else
            {
                MessageBox.Show("Course not found!", "Invalid Course ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstStudCourse_Click(object sender, EventArgs e)
        {
            DataTable StudentCourse = dsCollegeDB.Tables["CollegeRegForm"];
            dgvStudCourse.Rows.Clear();

            foreach(DataRow courserow in StudentCourse.Rows)
            {
                string currentcourse = courserow["CourseCode"].ToString();
                if (currentcourse.ToLower() ==  txtCourseCode.Text.Trim())
                {
                    string currentStud= courserow["StudentId"].ToString();
                    foreach (DataRow findStud in dsCollegeDB.Tables["Students"].Rows)
                    {
                        if(currentStud == findStud["StudentId"].ToString())
                        {
                            dgvStudCourse.Rows.Add(currentStud, findStud["FirstName"].ToString());
                        }
                    }
                }
            }



        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtStudId.TextLength > 0 && txtCourseCode.Text.Length > 0)
            {
                int studId = Convert.ToInt32(txtStudId.Text.Trim());
                string courseCode = txtCourseCode.Text.Trim();
                DateTime dtReg = dtpRegiDate.Value;
                DateTime dtStart = dtpStartDate.Value;
                DateTime dtEnd = dtpEndDate.Value;
                string datReg = dtReg.Day.ToString() + "/" + dtReg.Month.ToString() + "/" + dtReg.Year.ToString();
                string datStart = dtStart.Day.ToString() + "/" + dtStart.Month.ToString() + "/" + dtStart.Year.ToString();
                string datEnd = dtEnd.Day.ToString() + "/" + dtEnd.Month.ToString() + "/" + dtEnd.Year.ToString();
                dtCourseRegForm.Rows.Add(studId,courseCode,datReg,datStart,datEnd);
                MessageBox.Show("It has been updated!");
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to leave?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                MainMenuFormcs mainForm = new MainMenuFormcs();
                mainForm.ShowDialog();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to modify?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               
                string searchId = (txtCourseCode.Text.Trim());
                DataRow dr = dtCourseRegForm.Rows.Find(searchId);
               // dr["CourseCode"] = (txtCourseCode.Text.Trim());
                //string currenttitle = dsCollegeDB.Tables["Courses"];
                dr["RegistrationDate"] = dtpRegiDate.Text.Trim();
                dr["StartingDate"] = dtpStartDate.Text.Trim();
                dr["EndingDate"] = dtpEndDate.Text.Trim();
                dgvStud.Rows.Add(dr);

              
            }
           
        }

        private void btnUptData_Click(object sender, EventArgs e)
        {
            da3.Update(dsCollegeDB.Tables["StudentCourses"]);
            MessageBox.Show("Database has been updated successfully.", "Confirmation");
        }
    }
}
