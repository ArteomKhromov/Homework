using System;
using System.IO;

namespace task_DEV_5
{
    class FirstSorterText
    {
        public string path;
        public string[] contents;

        public FirstSorterText(string path)
        {
            this.path = path;
            
        }

        public void ReadText()
        {
            contents = File.ReadAllLines(path);
        }

        public void SortText()
        {
            ReadText();
            Array.Sort(contents);
        }

        public void WriteText()
        {
            SortText();
            File.WriteAllLines(path, contents);
        }
    }
}
