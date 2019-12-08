using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupProgram.Backup.Template
{
    class ListConverter
    {
        public static string ListToString(List<string> list, string split = ",")
        {
            string output = "";
            foreach (string s in list)
            {
                output += s + split;
            }
            // remove last split character
            if (output.Length > split.Length)
            {
                output = output.Substring(0, output.Length - split.Length);
            }
            return output;
        }

        public static List<string> StringToList(string input, string split = ",")
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return new List<string>();
            }
            // split, remove empty, trim
            return input.Trim().Split(new string[] { split }, StringSplitOptions.RemoveEmptyEntries).Select(item1 => item1.Trim()).ToList();
        }
    }
}
