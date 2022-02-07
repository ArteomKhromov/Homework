using System;
using System.IO;
namespace task_DEV_5
{
    class EnteriPoint
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the number of lines : ");
                    int Number = int.Parse(Console.ReadLine());
                    GenerateFile generateFile = new GenerateFile(@"D:\Homework\task_DEV_5\Text.txt", Number);
                    generateFile.EmbedFile();
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                SecondSorterText secondSorterText = new SecondSorterText(@"D:\Homework\task_DEV_5\Text2.txt");
                secondSorterText.SortsRows();



                FirstSorterText firstSorterText = new FirstSorterText(@"D:\Homework\task_DEV_5\Text1.txt");
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
