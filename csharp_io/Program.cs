using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace csharp_io
{
    class Program
    {
        static void Main(string[] args)
        {
            // http://www.cnblogs.com/netlyf/archive/2011/06/22/2086718.html
            {
                string str = Process.GetCurrentProcess().MainModule.FileName;
                Console.WriteLine(str);

                // 这个函数会返回路径名字
                //      比如              str="F:\github3\test_csharp_io\csharp_io\bin\Debug\csharp_io.vshost.exe"
                //      那么返回的文件夹名字为"F:\github3\test_csharp_io\csharp_io\bin\Debug"
                str = Path.GetDirectoryName(str);
                Console.WriteLine(str);
            }

            Console.WriteLine("按任意键继续...");
            Console.ReadKey();
        }
    }
}
