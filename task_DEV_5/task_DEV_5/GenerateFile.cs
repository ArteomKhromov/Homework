using System;
using System.Text;
using System.IO;

namespace task_DEV_5
{
    class GeneratorFile
    {
        private const string INVALID_LINE_LENGTH_ERROR_MESSAGE = "String length cannot be negative.";       
        private const int MAX_STRING_LENGTH = 101;
        private const int MIN_STRING_LENGTH = 1;
        private string path;
        private int stringAmount;

        public GeneratorFile(string path, int stringAmount)
        {
            this.path = path;
            this.stringAmount = stringAmount;
        }

        public void CheckStringLength()
        {
            if (stringAmount < 0)
            {
                throw new ArgumentOutOfRangeException(INVALID_LINE_LENGTH_ERROR_MESSAGE);
            }
        } 

        public void WriteToFile()
        {
            CheckStringLength();
            using (StreamWriter stream = new StreamWriter(path))
            {
                for (int i = 0; i < stringAmount; i++)
                {
                    stream.Write(GenerateString());
                }
            }
        }

        private string GenerateString()
        {
            Random random = new Random();
            StringBuilder builder = new StringBuilder();

            int stringLength = random.Next(MIN_STRING_LENGTH, MAX_STRING_LENGTH);

            for (int i = 0; i < stringLength - 1; i++)
            {
                char symbol = (char)random.Next(97, 123);
                builder.Append(symbol);
            }
            builder.Append('\n');
            return builder.ToString();
        }
    }
}
