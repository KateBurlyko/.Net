using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serealization2
{
    class FileWorker
    {
        public long GetSize(string path)
        {
            FileInfo file = new FileInfo(path);
            return file.Length;
        }
        public void Delete(string path)
        {
            File.Delete(path);
        }

        public void Create(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists == false) //Если файл не существует
            {
                file.Create(); //Создаем
            }
        }
    }
}
