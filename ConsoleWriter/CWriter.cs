using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWriter
{
    class CWriter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bot Online--\n--\n");

            Console.ReadLine();
        }

        CWriter() { }

        public void Cwriter(string message)
        {
            Console.WriteLine($"-- {message} --");
        }
    }
}
