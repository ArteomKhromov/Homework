namespace task_DEV_4
{
    abstract class Figure
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Figure(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public abstract  void CheckForExistance();

        public virtual string GetFullInfo()
        {
            return $"{Name}, {Color}";
        }
    }
}
