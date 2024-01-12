using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._domaca_zadaca
{
    public class Professor : Person , IEvaluation
    {
        private List<string> subjects;

        public Professor(string firstName, string lastName, int iD, List<string> subjects) : base(firstName, lastName, iD)
        {
            this.subjects = subjects;
        }

        public void AddEvaluation(Student student, int mark)
        {
            if(student != null && student.Marks == null) {
                student.AddEvaluation(mark);
            }
            else
            {
                throw new MyException($"Neispravan student ili ocjena");
            }
        }

        public void ShowEvaluation()
        {
            Console.WriteLine($"Ocjene učitelja {FirstName} {LastName} za predmete: {string.Join(", ", subjects)}");
        }
    }
}
