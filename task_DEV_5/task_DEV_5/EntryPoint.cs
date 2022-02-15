using System;
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
                int number = int.Parse(args[1]);
                string path = Path.GetFullPath(@"..\\..\\" + fileName);

                //FileGenerator fileGenerator = new FileGenerator(path, number);
                //fileGenerator.Generate();
              
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                Sorter sorter =  new Sorter(Path.GetFullPath(@"..\\..\\" + "Text1.txt"));
                sorter.Sort();
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("RunTime " + elapsedTime);

                Stopwatch stopWatch1 = new Stopwatch();
                stopWatch1.Start();

                BubbleSorter bubbleSorter = new BubbleSorter(Path.GetFullPath(@"..\\..\\" + "Text2.txt"));
                bubbleSorter.Sort();

                stopWatch1.Stop();

                TimeSpan ts1 = stopWatch1.Elapsed;
                string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts1.Hours, ts1.Minutes, ts1.Seconds,
                    ts1.Milliseconds / 10);
                Console.WriteLine("RunTime " + elapsedTime1);              

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
