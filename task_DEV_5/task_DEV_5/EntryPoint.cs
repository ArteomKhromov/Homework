using System;
using System.IO;

namespace task_DEV_5
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = args[0];
                int numberOfLines = int.Parse(args[1]);
                string path = Path.GetFullPath(@"..\\..\\" + fileName);

                FileGenerator fileGenerator = new FileGenerator(path, numberOfLines);
                fileGenerator.Generate();

                BubbleSorter bubbleSorter = new BubbleSorter(path);
                bubbleSorter.Sort();
            }
            catch (System.IndexOutOfRangeException a)
            {
                Console.WriteLine(a.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Invalid file path specified");
            }
        }
    }
}
