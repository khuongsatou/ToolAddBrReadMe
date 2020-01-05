using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    public class ReadFile
    {
        public void Readfile()
        {
            FileStream fs = new FileStream("D:\\test.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string giatri = rd.ReadToEnd();// ReadLine() chỉ đọc 1 dòng đầu thoy, ReadToEnd là đọc hết
            rd.Close();
            Console.WriteLine(giatri);
        }
    }
}
