using System;
using System.IO;
namespace task_DEV_5
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            int number = int.Parse(args[1]);
            string path = Path.GetFullPath(@"..\\..\\" + fileName);

            try
            {
                GeneratorFile generatorFile = new GeneratorFile(path, number);
                generatorFile.WriteToFile();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                LineSorter lineSorter = new LineSorter(path);
                lineSorter.Sort();
                ArraSorter arraSorter = new ArraSorter(path);
                arraSorter.Sort();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid file path specified");
            }
        }
    }
}
