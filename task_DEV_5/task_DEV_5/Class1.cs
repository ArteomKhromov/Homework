namespace task_DEV_5
{
    class Class1
    {
        public char simbol;
        public int num;

        public char WriteText()
        {
            if (num < 0 || num >= 26)
            {  }
            return "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[num];
        }
    }
}
