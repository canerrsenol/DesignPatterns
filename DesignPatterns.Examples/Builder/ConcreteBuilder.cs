namespace DesignPatterns.Examples.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPart1()
        {
            _product.Part1 = "Part 1";
        }

        public void BuildPart2()
        {
            _product.Part2 = "Part 2";
        }

        public void BuildPart3()
        {
            _product.Part3 = "Part 3";
        }

        public Product GetResult()
        {
            return _product;
        }
    }
} 