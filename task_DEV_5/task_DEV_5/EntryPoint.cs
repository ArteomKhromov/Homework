﻿using System;
using System.IO;
using System.Diagnostics;

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

                Sorter sorter = new Sorter(path);
                sorter.Sort();

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
