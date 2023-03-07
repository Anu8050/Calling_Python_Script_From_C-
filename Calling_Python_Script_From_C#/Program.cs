// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using IronPython.Hosting;

namespace ConsoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi");
            var engine = Python.CreateEngine();
        }
    }
}
