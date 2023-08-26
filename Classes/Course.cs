using System;
using System.Collections.Generic;
using Classes;

namespace SchoolPractice
{
	public class Course
	{
        private string topic;
		private Teacher instructor;

        private class Teacher
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Subject { get; set; }
            public string YearsTeaching { get; set; }
        }
        private List<Student> enrolledStudents;
    }
}

