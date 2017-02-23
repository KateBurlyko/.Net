using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.ParseExcel
{
    class GettingFilesFromFolder
    {
        public string[] GetBatches(string folderPath)
        {
            string[] dirs = Directory.GetFiles(folderPath);
            //string[] names = new string[dirs.Length];
            //for (int i = 0; i < dirs.Length; i++)
            //{
            //    names[i] = Path.GetFileName(dirs[i]);
            //}
            return dirs;
        }
    }
}
