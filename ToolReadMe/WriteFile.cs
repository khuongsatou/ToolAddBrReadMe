using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    public class WriteFile
    {
        public void Writefile()
        {
            Console.WriteLine("Ban thich ghi gi?");
            string input = Console.ReadLine();
            FileStream fs = new FileStream(@"D:\\testFile.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine("Đây là text new");
            sw.WriteLine(input);
            //clear cache
            sw.Flush();
          
            sw.Close();
        }
    }
}
