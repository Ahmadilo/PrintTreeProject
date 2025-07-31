using System;
using System.Collections.Generic;
using System.IO; // هذا الفضاء الاسمي ضروري للتعامل مع الملفات والمجلدات
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTreeProject.Core.Controllers
{
    internal class FileController
    {
        // الدالة الرئيسية التي سيتم استدعاؤها بدون وسائط
        public static void PrintFilesTree()
        {
            // استنتاج المسار الحالي للتطبيق
            string currentPath = Directory.GetCurrentDirectory();
            Console.OutputEncoding = Encoding.UTF8; // لضمان عرض الأحرف بشكل صحيح

            Console.WriteLine($"\nLoading Current The Dirctory to PrintTree: {currentPath}\n");

            // استدعاء الدالة المساعدة (Overload) التي تقوم بالعمل الفعلي
            // يتم تمرير المسار الحالي كأول وسيط
            PrintFilesTree(currentPath, "", true);
        }

        // هذه الدالة المساعدة هي التي تقوم بالعمل التكراري لطباعة الشجرة
        // قمنا بجعلها خاصة (private) لأنها ليست مخصصة للاستدعاء الخارجي المباشر
        private static void PrintFilesTree(string path, string indent, bool isLast)
        {
            // التحقق مما إذا كان المسار المحدد موجودًا
            if (!Directory.Exists(path) && !File.Exists(path))
            {
                Console.WriteLine($"Error: Path '{path}' does not exist.");
                return;
            }

            // إذا كان المسار ملفًا، اطبعه مباشرة
            if (File.Exists(path))
            {
                Console.WriteLine($"{indent}{(isLast ? "└── " : "├── ")}{Path.GetFileName(path)}");
                return;
            }

            if(Path.GetFileName(path) == ".git")
            {
                return;
            }

            if(Path.GetFileName(path) == ".vs")
            {
                return;
            }

            // طباعة اسم المجلد الحالي
            Console.WriteLine($"{indent}{(isLast ? "└── " : "├── ")}{Path.GetFileName(path)}");

            // الحصول على جميع المجلدات الفرعية والملفات في المسار الحالي
            string[] directories = Directory.GetDirectories(path);
            
            string[] files = Directory.GetFiles(path);

            // دمج المجلدات والملفات لترتيب العرض
            string[] allEntries = directories.Concat(files).ToArray();

            for (int i = 0; i < allEntries.Length; i++)
            {
                bool lastEntry = (i == allEntries.Length - 1);
                // تحديد المسافة البادئة (indent) لإنشاء شكل الشجرة
                string newIndent = indent + (isLast ? "    " : "│   ");

                // استدعاء الدالة بشكل تكراري (recursively) لكل مجلد أو ملف فرعي
                PrintFilesTree(allEntries[i], newIndent, lastEntry);
            }
        }
    }
}