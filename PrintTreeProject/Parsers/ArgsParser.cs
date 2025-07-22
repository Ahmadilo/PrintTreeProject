using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTreeProject.Parsers
{
    public class ArgsParser
    {
        public static Dictionary<string, string> Parse(string[] args)
        {
            var options = new Dictionary<string, string>();

            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i];

                // إذا الخيار يبدأ بـ "-" أو "--"
                if (arg.StartsWith("-"))
                {
                    // هل له قيمة تالية؟ (وليست خيارًا جديدًا)
                    if (i + 1 < args.Length && !args[i + 1].StartsWith("-"))
                    {
                        options[arg] = args[i + 1];
                        i++; // تخطى القيمة
                    }
                    else
                    {
                        options[arg] = null; // بدون قيمة (flag فقط)
                    }
                }
            }

            return options;
        }
    }
}
