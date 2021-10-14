using Lab3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.BLL
{
    class Student
    { 
        private int studentId;
        private string firstName;
        private string lastName;
        private string email;

       public Student()
        {
            StudentId = 0;
            FirstName = "";
            LastName = "";
            Email = "";
        }

        public Student(int studentid,string firstname,string lastname,string email)
        {
            StudentId = studentid;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }

        public int StudentId { get => studentId; set => studentId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }

        public List<Student> ListStudent()
        {
            return StudentDB.ListRecord();
        }
    }
}
