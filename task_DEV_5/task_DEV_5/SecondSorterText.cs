using System;
using System.IO;
using System.Text;
namespace task_DEV_5
{
    class SecondSorterText
    {
        public string path;
        public FileStream stream;

        public SecondSorterText(string path)
        {
            this.path = path;
        }

        public string ReadString()
        {
            StringBuilder sb = new StringBuilder();
            char symbol;
            while ((symbol = (char)stream.ReadByte()) != '\n')
            {
                sb.Append(symbol);
                if (stream.Length == stream.Position)
                {
                    break;
                }
            }
            return sb.ToString();
        }

        public void SortsRows()
        {
            using (stream = new FileStream(path, FileMode.Open))
            {                
                bool symbols = true;
                do
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    string firstString = ReadString();
                    symbols = false;

                    while (stream.Length > stream.Position)
                    {
                        string secondString = ReadString();

                        if (String.Compare(firstString, secondString) > 0)
                        {
                            var compareString = firstString;
                            firstString = secondString;
                            secondString = compareString;
                            symbols = true;
                        }
                        byte[] bytes = Encoding.Default.GetBytes(firstString + '\n');
                        byte[] toBytes = Encoding.Default.GetBytes(secondString + '\n');
                        stream.Seek(-(bytes.Length + toBytes.Length), SeekOrigin.Current);
                        stream.Write(bytes, 0, bytes.Length);
                        stream.Write(toBytes, 0, toBytes.Length);
                        firstString = secondString;
                    }
                }
                while (symbols);
            }
        }
    }
}
