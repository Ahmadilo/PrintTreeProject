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
        private static bool isFormat(string format)
        {
            if(format == "" && (Cls.Option == null || Cls.Option.Count == 0))
                return true;
            string[] required = null;
            if (format.Contains(","))
            {
                required = format.Split(',');

            }
            else
            {
                if (Cls.Option.Count != 1)
                    return false;

                if (format == "")
                    return false;

                if (!Cls.Option.ContainsKey(format) && !Cls.Option.ContainsKey(format[0].ToString()))
                    return false;

                return true;
            }


            if (required.Length != Cls.Option.Count)
                return false;

            foreach (var key in required)
            {
                if (!Cls.Option.ContainsKey(key) && !Cls.Option.ContainsKey(key[0].ToString()))
                    return false;
            }

            return true;
        }


        public static void Process(string Format, Action action, bool Order = false)
        {
            bool isthis = Route.isFormat(Format);

            if (isthis)
                action?.Invoke();
        }
    }
}
