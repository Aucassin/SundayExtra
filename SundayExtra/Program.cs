using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundayExtra
{
    class Program
    {
        static void Swap(ref string o1, ref string o2)
        {
            string temp;
            temp = o1;
            o1 = o2;
            o2 = temp;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            string name = "Elias";
            string surname = "Boiko";
            Swap(ref name, ref surname);
            Console.WriteLine($"{name} {surname}");




            //Stopwatch sw1 = new Stopwatch();
            //sw1.Start();
            //string s = "abc";
            //Console.WriteLine(s);
            //sw1.Stop();
            //Console.WriteLine(sw1.ElapsedTicks);
            //Stopwatch sw2 = new Stopwatch();
            //sw2.Start();
            //StringBuilder builder = new StringBuilder();
            //builder.Append("abc");
            //Console.WriteLine(builder);
            //sw2.Stop();
            //Console.WriteLine(sw2.ElapsedTicks);
        }
    }
}
