using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintTreeProject.Core.Controllers;

namespace PrintTreeProject.Routes
{
    internal class handler
    {
        public static void handle()
        {
            Route.Process(Format: "", action: () => { FileController.PrintFilesTree(); });

            Route.Process(Format: "show", action: () => { FileController.PrintFilesTree(); });
        }
    }
}
