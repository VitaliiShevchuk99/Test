using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }

        public string Encode(string input, int rails)
        {
            var result = new string[rails];
            var trackIdx = 0;
            var direction = 1;
            var directionCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result[trackIdx] += input[i];
                trackIdx += direction;
                directionCount++;
                if (directionCount == rails - 1)
                {
                    direction *= -1;
                    directionCount = 0;
                }
            }
            return result.Aggregate("", (x, y) => x + y);
        }
        public static string Decoder(string str, int rails)
        {
            return "text";
        }
    }
}
