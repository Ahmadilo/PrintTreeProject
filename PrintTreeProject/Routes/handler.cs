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
            Route.Process(Format: "s", action: (s) => Cls.Result = "Heloo World");
        }
    }
}
