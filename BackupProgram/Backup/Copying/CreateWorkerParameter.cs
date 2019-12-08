using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupProgram.Backup.Copying
{
    public class CreateWorkerParameter
    {
        public CreateWorkerParameter(string sourceDir, string templateName, bool onlyChanged)
        {
            SourceDir = sourceDir;
            TemplateName = templateName;
            OnlyChanged = onlyChanged;
        }

        public string SourceDir { get; set; }

        public string TemplateName { get; set; }
        public bool OnlyChanged { get; set; }

    }
}
