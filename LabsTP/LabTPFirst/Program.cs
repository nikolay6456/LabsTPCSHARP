using System;

namespace LabTPFirst
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var task = new Task();
            Console.WriteLine     ("____TASK 1____");
            task.TabulateFunction ( -10,   30,   3 );
            Console.WriteLine     ("____TASK 2____");
            Console.WriteLine     (task.MathSys(-2));
            Console.WriteLine     ("____TASK 3____");
            task.ShowMatchesWord  (                );
        }
    }
}