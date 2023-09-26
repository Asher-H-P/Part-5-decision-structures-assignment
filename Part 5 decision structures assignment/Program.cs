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
            Console.WriteLine("Based on what you told me, this is what I've gathered.");
            if (will > bill)
            {
                Console.WriteLine("Will is older than Bill.");
            }
            if (phil < will)
            {
                Console.WriteLine("Phil is younger than Will.");
            }
            if (bill == phil)
            {
                Console.WriteLine("Bill and Phil are the same age.");
            }
            if (bill < will && bill < phil)
            {
                Console.WriteLine("Bill is the youngest.");
            }
            if (will > bill && will > phil)
            {
                Console.WriteLine("Will is the oldest.");
            }
            if (bill == will || bill == phil && will != phil)
            {
                Console.WriteLine("Bill is the same age one other person.");
            }
            if (will != bill && will != phil)
            {
                Console.WriteLine("No one is the same age as Will.");
            }
            if (will == bill && will == phil && bill == phil)
            {
                Console.WriteLine("They're all the same age.");
            }
            if (will != bill && will != phil && bill != phil)
            {
                Console.WriteLine("They're all different ages.");
            }
            if ((will == bill && bill != phil) || (will == phil && phil != bill) || (bill == phil && phil != will))
            {
                Console.WriteLine("Two are the same age, but not all three.");
            }
            Console.ReadLine();
        }
    }
}
