using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_decision_structures_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int will, bill, phil;
            Console.WriteLine("How old is Will?");
            will = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How old is Bill?");
            bill = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How old is Phil?");
            phil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(will + bill + phil);
            Console.ReadLine();
        }
    }
}
