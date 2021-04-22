using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encode("hello world", 3));
            Console.WriteLine(Decoder(Encode("hello world",3),3));
            
        }

        public static string Encode(string str, int rails)
        {
            string[] result = new string[rails];
            int index = 0;
            int direction = 1;
            int Counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result[index] += str[i];
                index += direction;
                Counter++;
                if (Counter == rails - 1)
                {
                    direction *= -1;
                    Counter = 0;
                }
            }
            return result.Aggregate("", (x, y) => x + y);
        }
        public static string Decoder(string str, int rails)
        {
            string[] trackLen = new string[rails];
            int indexTrack = 0;
            int direction = 1;
            int Counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                trackLen[indexTrack] += str[i];
                indexTrack += direction;
                Counter++;
                if (Counter == rails - 1)
                {
                    direction *= -1;
                    Counter = 0;
                }
            }
            int[] Len = trackLen.Select(s => s.Length).ToArray();
            List<string> list = new List<string>();
            int cur = 0;
            foreach (var i in Enumerable.Range(0, rails))
            {
                var k = str.Substring(cur, Len[i]);
                list.Add(k);
                cur += Len[i];
            }
            string result = string.Empty;
            int index = 0;
            direction = 1;
            Counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result += char.ToString(list[index].First());
                list[index] = list[index].Remove(0, 1);
                index += direction;
                Counter++;
                if (Counter == rails - 1)
                {
                    direction *= -1;
                    Counter = 0;
                }
            }
            return result;
        }
    }
}
