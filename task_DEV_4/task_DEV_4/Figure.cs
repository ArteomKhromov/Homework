namespace task_DEV_4
{
    abstract class Figure
    {       
        public string Color { get; set; }
        public string Name { get; set; }        

        public Figure(string color, string name)
        {
            Name = name;
            Color = color;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public abstract void CheckForExistance();

        public virtual string GetFullInfo()
        {
            return $"{Color}, {Name}";
        }
    }
}
