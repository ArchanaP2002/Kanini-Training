using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class FileOperation
    {
        public void Createfile() 
        {
            FileInfo fi= new FileInfo("C:\\Users\\archa\\Downloads\\Kanini\\"
                +"Sample-cls.txt");
            using StreamWriter stwr = fi.CreateText();
            Console.WriteLine("File has been created");

            stwr.WriteLine("hello");
            stwr.WriteLine("hi");
            stwr.WriteLine("Archana");

           
        }
        public void Deletefile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\archa\\Downloads\\Kanini\\"

              + "Sample-cls.txt");
            fi.Delete();
        }

        public void CopyMove_file()
        {
            FileInfo fi1 = new FileInfo("C:\\Users\\archa\\Downloads\\Kanini\\Sample-cls.txt");
           // FileInfo fi2 = new FileInfo("C:\\Users\\archa\\Downloads\\Kanini\\C#\\Temp\\"+"Sample-cls.txt");
            
            fi1.CopyTo(" C:\\Users\\archa\\Downloads\\Kanini\\Temp\\Sample-cls.txt");
            Console.WriteLine("file copied");
        }
    }
}
