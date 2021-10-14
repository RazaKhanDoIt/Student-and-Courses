using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.DAL;

namespace Lab3.BLL
{
    class Course
    {
        private string courseCode;
        private string courseTitle;
        private int courseHour;

        public string CourseCode { get => courseCode; set => courseCode = value; }
        public string CourseTitle { get => courseTitle; set => courseTitle = value; }
        public int CourseHour { get => courseHour; set => courseHour = value; }

        public Course (string coursecode,string coursetitle, int coursehour)
        {
            CourseCode = coursecode;
            courseTitle = coursetitle;
            courseHour = coursehour;
        }
        public Course()
        {
            CourseCode ="";
            CourseTitle = "";
            CourseHour = 0;
         
        }
       
    }
   
}
