using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._domaca_zadaca
{
    public class Dean : IClassEvaluation
    {
        private List<Professor> professorList;
        private List<Student> studentList;

        public Dean(string firstName, string lastName, int id) : base(firstName, lastName,id)
        {
            professorList= new List<Professor>();
            studentList= new List<Student>();
        }
           
        public void AddStudentToClass(Student student)
        {
            studentList.Add(student);
        }

        public void AddProfessor(Professor professor)
        {
            professorList.Add(professor);
        }

        public void ShowClassMarks()
        {
            foreach (Student student in studentList)
            {
                student.ShowEvaluation();
            }
        }
    }
}
