namespace DesignPatterns.Examples.Builder
{
    public interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();
        Product GetResult();
    }
} 