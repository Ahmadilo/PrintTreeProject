using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace PrintTreeProject.Parsers
{
    internal class ValidtionParser
    {
        public static bool IsValid(Dictionary<string, string> options)
        {
            if (options == null || options.Count == 0)
                return true;

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\admin\\source\\repos\\PrintTreeProject\\PrintTreeProject\\Options.xml");

            XmlNodeList xmlOptions = doc.SelectNodes("/Options/Option");

            // بناء قائمة بكل المفاتيح المسموح بها (Name و Short)
            HashSet<string> validKeys = new HashSet<string>(
                xmlOptions
                .Cast<XmlNode>()
                .SelectMany(opt => new[] {
            opt.Attributes["Name"]?.Value,
            opt.Attributes["Short"]?.Value
                })
                .Where(k => !string.IsNullOrEmpty(k))
            );

            // تحقق من أن كل خيار موجود في القائمة المسموح بها
            foreach (var userOption in options.Keys)
            {
                if (!validKeys.Contains(userOption))
                {
                    Console.WriteLine($"The option '{userOption}' is not defined in Options list!");
                    return false;
                }
            }

            // تحقق من القيم بناءً على regex إن وجد
            foreach (XmlNode xmlOption in xmlOptions)
            {
                string name = xmlOption.Attributes["Name"]?.Value;
                string shortName = xmlOption.Attributes["Short"]?.Value;
                string regex = xmlOption.Attributes["regex"]?.Value;

                if (string.IsNullOrEmpty(regex)) continue;

                // تحقق إذا كان هذا الخيار مستخدم (بالاسم أو الاختصار)
                string value = null;

                if (options.ContainsKey(name))
                    value = options[name];
                else if (options.ContainsKey(shortName))
                    value = options[shortName];

                if (value != null && !Regex.IsMatch(value, regex))
                {
                    Console.WriteLine($"❌ Invalid value '{value}' for option '{name}'. It must match pattern: {regex}");
                    return false;
                }
            }

            return true; // ✅ جميع القيم صحيحة
        }

    }
}
