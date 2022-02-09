using System;
using System.IO;
using System.Text;
namespace task_DEV_5
{
    class LineSorter
    {
        private string path;
        private FileStream stream;

        public LineSorter(string path)
        {
            this.path = path;
        }

        private string ReadString()
        {
            StringBuilder builder = new StringBuilder();
            char symbol;
            while ((symbol = (char)stream.ReadByte()) != '\n' || stream.Length == stream.Position)
            {
                builder.Append(symbol);
            }
            return builder.ToString();
        }
        private void Recording(string firstString, string secondString)
        {
            byte[] bytes = Encoding.Default.GetBytes(firstString + '\n');
            byte[] toBytes = Encoding.Default.GetBytes(secondString + '\n');
            stream.Seek(-(bytes.Length + toBytes.Length), SeekOrigin.Current);
            stream.Write(bytes, 0, bytes.Length);
            stream.Write(toBytes, 0, toBytes.Length);
        }

        private void SortBubble(string firstString, string secondString)
        {
            var compareString = firstString;
            firstString = secondString;
            secondString = compareString;
        }

        public void Sort()
        {
            using (stream = new FileStream(path, FileMode.Open))
            {
                bool sort = true;
                do
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    string firstString = ReadString();
                    sort = false;

                    while (stream.Length > stream.Position)
                    {
                        string secondString = ReadString();

                        if (String.Compare(firstString, secondString) > 0)
                        {
                            SortBubble(firstString, secondString);
                            sort = true;
                        }
                        Recording(firstString, secondString);
                        firstString = secondString;
                    }
                }
                while (sort);
            }
        }
    }
}
