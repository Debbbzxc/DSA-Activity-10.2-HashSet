using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Activity_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * DSA Activity 10.2 - Baltazar, Mark Daves L.
             * Program Description: A program uses HashSets to perform and display set operations—union, 
             * intersection, difference, and symmetric difference—on two arrays of names, 
             * showcasing efficient data manipulation and comparison.
             */

            string[] names1 = new string[] { "mahesh", "sabnis", "manish", "sharma", "saket", "karnik" };
            string[] names2 = new string[] { "suprotim", "agarwal", "vikram", "pendse", "mahesh", "mitkari" };

            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in First HashSet:");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------");
            HashSet<string> hSetN2 = new HashSet<string>(names2);
            Console.WriteLine("Data in Second HashSet:");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------");
            HashSet<string> union = new HashSet<string>(hSetN1);
            union.UnionWith(hSetN2);
            Console.WriteLine("UNION:");
            foreach (var n in union)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine($"Count: {union.Count}");
            Console.WriteLine("----------------------------------------");
            HashSet<string> intersection = new HashSet<string>(hSetN1);
            intersection.IntersectWith(hSetN2);
            Console.WriteLine("INTERSECTION:");
            foreach (var n in intersection)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine($"Count: {intersection.Count}");
            Console.WriteLine("----------------------------------------");
            HashSet<string> difference = new HashSet<string>(hSetN1);
            difference.ExceptWith(hSetN2);
            Console.WriteLine("DIFFERENCE:");
            foreach (var n in difference)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine($"Count: {difference.Count}");
            Console.WriteLine("----------------------------------------");
            HashSet<string> symDiff = new HashSet<string>(hSetN1);
            symDiff.SymmetricExceptWith(hSetN2);
            Console.WriteLine("SYMMETRIC DIFFERENCE:");
            foreach (var n in symDiff)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine($"Count: {symDiff.Count}");
            Console.WriteLine("----------------------------------------");
            
            Console.ReadKey();
        }
    }
}
