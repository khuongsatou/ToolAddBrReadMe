using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    public class ReadFile2
    {
        public void Readfile()
        {
            
            string[] lines = File.ReadAllLines(@"D:\\test.txt");
            //Đọc từng dòng
            foreach (var row in lines)
            {
                Console.WriteLine(row);
            }
        }
    }
        
}
