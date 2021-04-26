using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5
{
    class MyActionFile
    {
        public string prePath { set; get; }
        public string subPath { set; get; }

        public MyActionFile(string pre, string sub)
        {
            this.prePath = pre;
            this.subPath = sub;
        }

        //phuong thuc xoa file
        public bool deleteFile()
        {
            var path = Path.Combine(prePath, subPath);
            if (File.Exists(path))
            {
                File.Delete(path);
                return true;
            }
            else
            {
                Console.WriteLine("Khong phai file!");
            }
            return false;
        }

        //phuong thuc xoa thu muc con co trong mot thu muc hien hanh
        public void deleteSubFolder(string path)
        {
            if (Directory.Exists(path))
            {
                string[] subFolders = Directory.GetDirectories(path);
                if(subFolders.Length > 0)
                {
                    foreach (string folder in subFolders)
                    {
                        deleteSubFolder(folder);
                        Directory.Delete(folder);
                        Console.WriteLine("Da xoa folder: "+folder);
                    }
                }
                deleteAllFile(path);
            }
        }
        public bool deleteAllFile(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach(var file in files)
            {
                var fileDel = Path.Combine(path, file);
                File.Delete(fileDel);
                Console.WriteLine("Da xoa file: " + fileDel);
            }
            return true;
        }

        //phuong thuc tim kiem file dua tren phan mo rong
        public List<string> findAllFile(string path, string extendsion)
        {
            List<string> listResult = new List<string>();
            if (Directory.Exists(prePath))
            {
                string[] files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    if (Path.GetExtension(file).Equals(extendsion))
                    {
                        listResult.Add(file);
                    }
                }
                string[] subFolders = Directory.GetDirectories(path);
                foreach(var folder in subFolders)
                {
                    findAllFile(folder, extendsion);
                }
            }
            printList(listResult);
            return listResult;
        }

        public void printList(List<string> lists)
        {
            foreach(var item in lists)
            {
                Console.WriteLine(item);
            }
        }


    }
}
