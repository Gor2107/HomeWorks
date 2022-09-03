using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_2_create_write_read_FIle
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (FileStream fileStream =
                new FileStream(@"C:\Users\User\Desktop\Test\UserInfo.txt",
                                 FileMode.OpenOrCreate,
                                FileAccess.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine("Անուն Ազգանուն՝    Գոռ Մելքումյան");
                    writer.WriteLine("Ծննդյան ամսաթիվ՝  07/08/1984");
                    writer.WriteLine("Սեռ՝               արական");
                }
            }

            using (FileStream stream =
                new FileStream(@"C:\Users\User\Desktop\Test\UserInfo.txt",
                                FileMode.OpenOrCreate,
                                FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        Console.WriteLine(reader.ReadLine());
                    }
                    // reader.BaseStream.Position = 0;
                    // method 2
                    // Console.WriteLine(reader.ReadToEnd());
                }
            }
            Console.WriteLine("##################################");
            #region method 3
            using (StreamWriter strWriter =
                  File.CreateText(@"C:\Users\User\Desktop\Test\UserInfo1.txt"))
            {
                strWriter.WriteLine("Row1");
                strWriter.WriteLine("Row2");
            }

            Console.WriteLine(File.ReadAllText(@"C:\Users\User\Desktop\Test\UserInfo1.txt"));

                #endregion
                Console.ReadKey();
        }
    }
}
