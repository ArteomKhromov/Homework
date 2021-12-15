namespace task_DEV_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstTextSorter firstTextSorter = new FirstTextSorter(@"D:\Text.txt", @"D:\Text.txt");
            //firstTextSorter.ReadText();
            //firstTextSorter.SortText();
            //firstTextSorter.WriteText();

            SecondSorterText secondSorterText = new SecondSorterText(@"D:\Text.txt", @"D:\Text.txt");
            secondSorterText.ReadText();
            secondSorterText.WriteText();             
        }
    }
}
