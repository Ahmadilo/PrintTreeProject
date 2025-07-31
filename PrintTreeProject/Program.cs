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
            args = new string[] { "--show" };
            Cls.Input(args);
            Cls.Process();
            Cls.Output();
        }
    }
}
