using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static List<int> PositiveNumbers(List<int> list)
        {
            if (list != null)
            {
                for (int i = 0; i < list.Count;)
                {
                    if (list[i] < 0)
                        list.RemoveAt(i);
                    else
                        i++;
                }
            }
            return list;
        }

        static List<int> InsertNumber(List<int> list, int number)
        {
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > 0)
                    {
                        list.Insert(i + 1, number);
                        break;
                    }
                }
            }
            return list;
        }

        static List<int> EvenNumbers(List<int> list)
        {
            if (list != null)
            {
                for (int i = 0; i < list.Count;)
                {
                    if (list[i] % 2 == 0)
                        list.RemoveAt(i);
                    else
                        i++;
                }
            }
            return list;
        }

        static List<int> StringNumbers(List<string> list)
        {
            List<int> numbers = new List<int>();

            if (list != null)
            {
                foreach (string word in list)
                {
                    if (int.TryParse(word, out int num))
                        numbers.Add(num);
                }
            }

            return numbers;
        }

        static void Main()
        {
            List<int> numbers1 = PositiveNumbers(new List<int> { -4, -3, 1, -10 });
            Console.WriteLine(string.Join(", ", numbers1));

            List<int> numbers2 = InsertNumber(new List<int> { -4, -7, 1, -10 }, 5);
            Console.WriteLine(string.Join(", ", numbers2));

            List<int> numbers3 = EvenNumbers(new List<int> { 4, 2, 8, 3 });
            Console.WriteLine(string.Join(", ", numbers3));

            List<int> numbers4 = StringNumbers(new List<string> { "привет", "ky", "12", "18" });
            Console.WriteLine(string.Join(", ", numbers4));

            Console.ReadKey();
        }
    }
}
