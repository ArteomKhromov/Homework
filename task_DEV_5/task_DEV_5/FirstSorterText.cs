using System;
using System.IO;

namespace task_DEV_5
{
    class FirstSorterText
    {
        public string inFile;
        public string outFile;
        public string[] contents;

        public FirstSorterText(string inFile, string outFile)
        {
            this.inFile = inFile;
            this.outFile = outFile;
        }

        public void ReadText()
        {
            contents = File.ReadAllLines(inFile);

        }

        public void SortText()
        {
            ReadText();
            Array.Sort(contents);
        }
        public void WriteText()
        {
            SortText();
            File.WriteAllLines(outFile, contents);
        }
    }
}
