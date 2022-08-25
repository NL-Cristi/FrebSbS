using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrebIt
{
    public class FilesEntry
    {
        public string SiteId { get; set; }

        public string FileName { get; set; }

        public string Url { get; set; }

        public string Verb { get; set; }

        public string AppPoolID { get; set; }

        public string StatusCode { get; set; }

        public int TimeTaken { get; set; }
        public string FileFullPath { get; set; }
        public string FolderPath { get; set; }

    }
    public class ConvertInfo
    {
        public string FileName { get; set; }
        public string FileFullPath { get; set; }
        public string FileFolderPath { get; set; }

    }
}
