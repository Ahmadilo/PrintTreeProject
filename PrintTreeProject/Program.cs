using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTreeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> options = Parsers.ArgsParser.Parse(args);

            if(Parsers.ValidtionParser.IsValid(options))
            {
                Console.WriteLine("Hello World");
            }
        }
    }
}
