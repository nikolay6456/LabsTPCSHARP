using System;
using System.Text.RegularExpressions;

namespace LabTPFirst
{
    public class Task
    {
        public void TabulateFunction(int start, int end, int step)
        {
            for (var x = start; x <= end; x += step)
            {
                var function = Math.Pow(10, -x) / Math.Exp(x) * Math.Sin(x);
                Console.WriteLine("x = {0} y = {1}", x, function);
            }
        }

        public double MathSys(double x)
        {
            double y;
            if (x < -1)
                y = Math.Log(3 * Math.PI * Math.Pow(x, 5));
            else if (x >= -1 && x < 0)
                y = Math.Abs(Math.Pow(x, 4));
            else
                y = Math.Tan(Math.Pow(x, 2));
            return y;
        }

        public MatchCollection GetMatchesWord(string text, string word)
        {
            if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(text)) return null;
            var regex = new Regex(@"\w*" + word, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            return regex.Matches(text);
        }

        public void ShowMatchesWord()
        {
            Console.WriteLine("Enter word");
            var word = Console.ReadLine();
            Console.WriteLine("Enter text");
            var text = Console.ReadLine();
            var matchCollection = GetMatchesWord(text, word);
            if (matchCollection != null && matchCollection.Count > 0)
            {
                Console.WriteLine("Matches words");
                foreach (Match match in matchCollection) Console.Write(match.Value + " ");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}