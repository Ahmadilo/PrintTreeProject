using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrintTreeProject.Routes
{
    internal class Route
    {
        private static bool isFormat(string Format)
        {
            return true;
        }

        public static void Process(string Format, Action<object> action, bool Order = false)
        {
            bool isthis = Route.isFormat(Format);
            object result = null;

            if (isthis)
                action?.Invoke(result);
        }
    }
}
