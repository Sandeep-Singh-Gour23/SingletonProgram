using System;

namespace SingletonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter obj = Counter.getInstance;
            obj.Increment();
            obj.Decrement();
            obj.Increment();
            obj.Increment();
            obj.Increment();
            obj.Increment();
            obj.CurrentCount();



        }
    }
}
