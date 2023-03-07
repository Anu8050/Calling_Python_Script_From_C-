// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ComponentAce.Compression.Libs.ZLib;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("hi");
            
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = @"C:\Users\User\AppData\Local\Programs\Python\Python310\python.exe";
        start.Arguments = @"F:\\C#Example\\PythonFile\\print.py";
        start.UseShellExecute = false;
        start.CreateNoWindow = true;
        start.RedirectStandardOutput = true;
        string result = "";
        using (Process process = Process.Start(start))
        {
            result = process.StandardOutput.ReadToEnd();
        }
        Console.WriteLine(result);
    }
}

