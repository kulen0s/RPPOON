using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._domaca_zadaca
{
    public class Student : Person, IEvaluation
    {
        public List<int> Marks { get; set; }
        public string SchoolClass { get; set; }

        public Student(string firstName, string lastName, int iD, string schoolClass) : base(firstName,lastName,iD)
        {
            Marks = new List<int>();
            SchoolClass = schoolClass;
        }

        public void AddEvaluation(int mark)
        {
           Marks.Add(mark);
        }

        public void ShowEvaluation()
        {
            Console.WriteLine($"Ocjene studenata {FirstName} {LastName} u razredu {SchoolClass}: {string.Join(",",Marks)}");
        }
    }
}
