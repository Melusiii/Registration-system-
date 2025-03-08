using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg_System
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public string Course { get; set; }

        public Student(string name, int studentId, string course)
        {
            Name = name;
            StudentId = studentId;
            Course = course;
        }
        public override string ToString() 
        {
            return $"ID: {StudentId}, Name: {Name}, Course: {Course}";
        }
    }
}
