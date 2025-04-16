namespace DesignPatterns.Examples.Builder
{
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }

        public override string ToString()
        {
            return $"Product: {Part1}, {Part2}, {Part3}";
        }
    }
} 