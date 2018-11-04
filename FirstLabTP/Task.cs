using System;

namespace FirstLabTP
{
    public class Task
    {
        private double ConculateFunction(int x)
        {
            var function = Math.Pow(10, -x) / Math.Exp(x) * Math.Sin(x);
            return function;
        }

        public void TabulateFunction(int start, int end, int step)
        {
            for (int x = start; x <= end; x += step)
            {
               Console.WriteLine("x = {0} y = {1}", x, ConculateFunction(x)); 
            }
        }
        
    }
}