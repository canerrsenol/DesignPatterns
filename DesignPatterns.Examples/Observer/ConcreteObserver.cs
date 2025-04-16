using System;

namespace DesignPatterns.Examples.Observer
{
    public class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} received message: {message}");
        }
    }
} 