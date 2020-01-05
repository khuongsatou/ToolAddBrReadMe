using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    public class WriteFileBrMD
    {
        public void InputAndWriteBr()
        {
            string[] lines = File.ReadAllLines(@"D:\\README.md");
            using(StreamWriter sw = new StreamWriter(@"D:\\README.md"))
            {
                foreach (var line in lines)
                {
                    sw.WriteLine(line + "</br>");
                }
            }
        }
    }
}
