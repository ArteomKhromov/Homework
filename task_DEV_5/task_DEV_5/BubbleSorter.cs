using System;
using System.IO;
using System.Text;

namespace task_DEV_5
{
    class BubbleSorter
    {
        private string path;
        private FileStream stream;

        public BubbleSorter(string path)
        {
            this.path = path;
        }

        public void Sort()
        {
            using (stream = new FileStream(path, FileMode.Open))
            {
                bool needSorting = true;
                do
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    string firstString = ReadString();
                    needSorting = false;

                    while (stream.Length > stream.Position)
                    {
                        string secondString = ReadString();

                        if (String.Compare(firstString, secondString) > 0)
                        {
                            WriteLinesToAFile(firstString, secondString);
                            needSorting = true;
                        }
                        else
                        {
                            firstString = secondString;
                        }
                    }
                }
                while (needSorting);
            }
        }

        private string ReadString()
        {
            StringBuilder builder = new StringBuilder();
            char symbol;
            while ((symbol = (char)stream.ReadByte()) != '\n' && stream.Length != stream.Position)
            {                
                builder.Append(symbol);                
            }            
            return builder.ToString();
        }

        private void WriteLinesToAFile(string firstString, string secondString)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(secondString);
            stringBuilder.Append('\n');
            stringBuilder.Append(firstString);
            stringBuilder.Append('\n');
            
            byte[] stringBytes = Encoding.Default.GetBytes(stringBuilder.ToString());
            
            stream.Seek(-(stringBytes.Length), SeekOrigin.Current);            
            stream.Write(stringBytes, 0, stringBytes.Length);
        }
    }
}
