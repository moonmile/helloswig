using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello swig world.");


            var hello = new Hello();

            hello.SetName("Tomoaki Masuda");
            var name = hello.GetName();
            Console.WriteLine($"name: {name}");

            hello.SetName("Jhon doe");
            name = hello.GetName();
            Console.WriteLine($"name: {name}");

            int x = 10;
            int y = 20;
            Console.WriteLine($"{x} + {y} = {hello.Add(x, y)}");
            Console.WriteLine($"{x} * {y} = {hello.Mul(x, y)}");

            Console.WriteLine("end");
        }
    }
}
