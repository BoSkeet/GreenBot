using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWriterMain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working");

            Console.ReadLine();
        }

        public string ReturnPath()
        {
            string folder = Environment.CurrentDirectory;
            return folder;
        }

        public Program() { }
    }
}
