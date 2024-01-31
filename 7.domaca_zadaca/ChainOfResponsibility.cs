using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.domaca_zadaca
{
    abstract class Approver
    {
        protected Approver successor;

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(PurchaseRequest request);
    }

    class PurchaseRequest
    {
        public int Number { get; set; }
        public decimal Amount { get; set; }
        public string Purpose { get; set; }

    }

    class Director : Approver
    {
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 10000)
            {
                Console.WriteLine($"Director approved request #{request.Number}");
            }
            else if (successor != null)
            {
                successor.ProcessRequest(request);
            }
        }
    }

    class VicePresident : Approver
    {
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 25000)
            {
                Console.WriteLine($"Vice President approved request #{request.Number}");
            }
            else if (successor != null)
            {
                successor.ProcessRequest(request);
            }
        }
    }

    class President : Approver
    {
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 100000)
            {
                Console.WriteLine($"President approved request #{request.Number}");
            }
            else
            {
                Console.WriteLine($"Request #{request.Number} requires CFO approval");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            PurchaseRequest pr1 = new PurchaseRequest { Number = 2034, Amount = 3500, Purpose = "Supplies" };

        }
    }

}
