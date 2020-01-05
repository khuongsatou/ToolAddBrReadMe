using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    public class WriteFile2
    {
        public void Writefile()
        {
            Console.WriteLine("Vi du minh hoa doc va ghi File trong C#");
            Console.WriteLine("---------------------------------");

            string[] names = new string[] { "Tran Van A", "Nguyen Minh B","Nguyễn Văn C" };
            using (StreamWriter sw = new StreamWriter("textfile.txt"))
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s+"</br>");
                }
            }

            // doc va hien thi du lieu trong textfile.txt
            string line = "";
            using (StreamReader sr = new StreamReader("textfile.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
