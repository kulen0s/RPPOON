using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._domaca_zadaca
{
    public class SchoolClass : IClassEvaluation
    {
        private string className;

        private List<Student> students;

        public SchoolClass(string className)
        {
            this.className = className;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if(student != null && !students.Contains(student))
            {
                students.Add(student);
            }
            else
            {
                throw new Exception($"Neispravan unos");
            }
        }

        public void RemoveStudent(Student student)
        {
            if(student != null && students.Contains(student))
            {
                students.Remove(student);
            }
            else
            {
                throw new Exception();
            }
        }

        public void ShowClassMarks()
        {
            foreach(var student in students)
            {
                student.ShowEvaluation();
            }
        }


        
    }
}
