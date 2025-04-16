namespace DesignPatterns.Examples.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildPart1();
            _builder.BuildPart2();
            _builder.BuildPart3();
        }
    }
} 