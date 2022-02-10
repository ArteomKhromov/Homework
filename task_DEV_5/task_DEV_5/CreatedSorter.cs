using System;
using System.IO;
using System.Text;

namespace task_DEV_5
{
    class CreatedSorter
    {
        private string path;
        private FileStream stream;

        public CreatedSorter(string path)
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
            byte[] firstStringBytes = Encoding.Default.GetBytes(firstString + '\n');
            byte[] secondStringBytes = Encoding.Default.GetBytes(secondString + '\n');
            stream.Seek(-(firstStringBytes.Length + secondStringBytes.Length), SeekOrigin.Current);
            stream.Write(secondStringBytes, 0, secondStringBytes.Length);
            stream.Write(firstStringBytes, 0, firstStringBytes.Length);
        }        

        public void Sort()
        {
            using (stream = new FileStream(path, FileMode.Open))
            {
                bool sorts = true;
                do
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    string firstString = ReadString();
                    sorts = false;

                    while (stream.Length > stream.Position)
                    {
                        string secondString = ReadString();

                        if (String.Compare(firstString, secondString) > 0)
                        {                            
                            Recording(firstString, secondString);
                            sorts = true;                            
                        }                        
                        firstString = secondString;
                    }
                }
                while (sorts);
            }
        }
    }
}
