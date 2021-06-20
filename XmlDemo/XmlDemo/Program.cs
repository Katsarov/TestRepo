using System;
using System.IO;

namespace XmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = File.ReadAllText("Data.xml");
            Console.WriteLine(xml);
        }
    }
}
