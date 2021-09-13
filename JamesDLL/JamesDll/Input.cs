using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace JamesDll
{
    class FileHandling
    {
        public static string GetFileType(string path)
        {
            string fileType = "";

            string[] pathSplit = path.Split('.');

            return fileType = "." + pathSplit.Last();
        }

        public static void GetFolderPath(out string folderPath)
        {
            Console.WriteLine("Please enter the path to your folder.");
            Console.Write(": ");
            string ans = Console.ReadLine();

            if (!ans.EndsWith("\\"))
                ans = ans + "\\";

            if (Directory.Exists(ans) && Directory.GetFiles(ans).Length > 0)
            {
                folderPath = ans;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That folder is empty or does not exist. Try again.");
                GetFolderPath(out folderPath);
            }
        }

        public static string FileChoice()
        {
            Console.Write("Please enter the name of your file: ");
            return Console.ReadLine();
        }
    }
}
