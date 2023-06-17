using System;
using System.Collections.Generic;
namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args) {
            IDictionary<int, string> words = new Dictionary<int, string> {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };
            string result = "";
            for (int i = 1; i <= 100; i++) {
                foreach (var kvp in words)
                    if (i % kvp.Key == 0) result += kvp.Value;
                Console.WriteLine(result.Length != 0 ? result : i.ToString());
                result = "";
            }
        }
    }
}
