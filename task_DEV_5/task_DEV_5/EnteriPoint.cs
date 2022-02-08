using System;
using System.IO;
namespace task_DEV_5
{
    class EnteriPoint
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            int number = int.Parse(args[1]);

            string path = Path.GetFullPath(@"..\\..\\" + fileName);
            try
            {
                try
                {                  
                    GenerateFile generateFile = new GenerateFile(path, number);
                    generateFile.EmbedFile();
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                SecondSorterText secondSorterText = new SecondSorterText(path);
                secondSorterText.SortsRows();



                FirstSorterText firstSorterText = new FirstSorterText(path);
                firstSorterText.ReadText();
                firstSorterText.SortText();
                firstSorterText.WriteText();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid file path specified");
            }
        }
    }
}
