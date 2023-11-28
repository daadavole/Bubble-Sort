using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = new List<int> { 2, 8, 5, 3, 9, 4, 1}; 
            Console.WriteLine("Starting list: ");
            PrintList(list);
            Console.WriteLine("Sorted list: ");
            PrintList(BubbleSort(list));

            Console.ReadKey();
        }
        static void PrintList<T>(List<T> list) // Use of generic for reusability (not particularly needed but whatever)
        {
            foreach (T item in list) 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static List<int> BubbleSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        // Swap values at index i and i + 1
                        int holder = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = holder;
                        PrintList(list);
                    }
                }
            }
            return list;
        }
    }
}
