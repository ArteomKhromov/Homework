﻿using System;
using System.IO;

namespace task_DEV_5
{
    class ArraSorter
    {
        private string path;

        public ArraSorter(string path)
        {
            this.path = path;
        }

        public void Sort()
        {
            string[] contents = File.ReadAllLines(path);
            Array.Sort(contents);
            File.WriteAllLines(path, contents);
        }
    }
}
