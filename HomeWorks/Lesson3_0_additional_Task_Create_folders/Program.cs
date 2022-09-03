using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_0_additional_Task_Create_folders
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Folders' creation started");
            DirectoryInfo path = new DirectoryInfo(@"C:\Users\User\Desktop\Test");
            for (int i = 0; i < 100; i++)
                path.CreateSubdirectory($"Folder_{i}");
            Console.WriteLine("all folders created");
            Console.WriteLine("Press any key to delete all created subfolders");
            Console.WriteLine("Folders deletion started");
            for (int i = 0; i < 100; i++)
            {
                new DirectoryInfo($@"C:\Users\User\Desktop\Test\Folder_{i}").Delete();
            }
            Console.WriteLine("Folders deletion finished");
            Console.ReadKey();
        }
    }
}
