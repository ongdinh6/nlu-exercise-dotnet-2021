using System;
using System.IO;

namespace buoi5
{
   
    class Program
    {
        static void Main(string[] args)
        {
            MyActionFile myFile = new MyActionFile("F:\\abc", "abc.txt");
            //bool deleted = myFile.deleteFile();
            myFile.findAllFile(myFile.prePath,".docx");
           // if (deleted) Console.WriteLine("Xoa thanh cong file: " + Path.Combine(myFile.prePath, myFile.subPath));
           // myFile.deleteSubFolder("F:\\abc");
        }
    }
}
