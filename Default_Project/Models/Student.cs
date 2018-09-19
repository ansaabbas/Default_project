using System;
using System.Collections.Generic;

namespace Default_Project.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string RollNo { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Cv { get; set; }
        public string Gpa { get; set; }
        public string ProfilePicture { get; set; }
    }
}
