using System;
using System.IO;
namespace task_DEV_5
{
    class SecondSorterText
    {
        public string inFile;
        public string outFile;
        public string[] contents;

        public SecondSorterText(string inFile, string outFile)
        {
            this.inFile = inFile;
            this.outFile = outFile;
        }

        public void ReadText()
        {
            using (StreamReader reader = new StreamReader(inFile))
            {
                contents = reader.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public void WriteText ()
        {
            ReadText();
            using (StreamWriter writer = new StreamWriter(outFile))
            {               
                Array.Sort(contents);
                writer.Write(string.Join(Environment.NewLine, contents));
            }
        }
    }
}
