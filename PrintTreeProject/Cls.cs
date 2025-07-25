using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTreeProject
{
    internal class Cls
    {
        public static Dictionary<string, string> Option = null;
        public static bool isValid = false;
        public static string Result = string.Empty;

        public static void Input(string[] args)
        {
            Option = Parsers.ArgsParser.Parse(args);
            isValid = Parsers.ValidtionParser.IsValid(Option);
        }

        public static void Process()
        {
            Routes.handler.handle();
        }

        public static void Output()
        {
            Console.WriteLine(Result);
        }
    }
}
