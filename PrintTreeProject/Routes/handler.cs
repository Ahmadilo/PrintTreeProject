using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTreeProject.Routes
{
    internal class handler
    {
        public static void handle()
        {
            Route.Process(Format: "", action: () => Cls.Result = "Hello World");

            Route.Process(Format: "show", action: () => Cls.Result = "Heloo World");
        }
    }
}
