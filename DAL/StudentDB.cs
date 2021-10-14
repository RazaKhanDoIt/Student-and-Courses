using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.BLL;
using System.Data.SqlClient;

namespace Lab3.DAL
{
    class StudentDB
    {

        public static List<Student> ListRecord()
        {
            List<Student> listStudent = new List<Student>();
            using (SqlConnection conn = UtilityDB.ConnectDB())
            {
                Student aStudent;
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Students", conn);
                SqlDataReader reader = cmdSelect.ExecuteReader();



                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        aStudent = new Student();
                        aStudent.StudentId = Convert.ToInt32(reader["StudentId"]);
                        aStudent.FirstName = reader["FirstName"].ToString();
                        aStudent.LastName = reader["LastName"].ToString();
                        aStudent.Email = reader["Email"].ToString();
                        listStudent.Add(aStudent);
                    }
                }
                else
                {
                    listStudent = null;
                }
            }
            
            return listStudent;

        }
    }

}
