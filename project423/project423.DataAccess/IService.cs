Visual Studio

using System;

namespace project423
{
    public class Service
    {
        public void PerformOperation(int a, int b)
        {
            int total = a + b;
            Console.WriteLine("Total is {0}", total);
        }
    }
}

using project423.DTO;

namespace project423.Service
{
    public interface IService
    {
        void PerformOperation(Input input);
    }
}