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
            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (i + 1 < list.Count)
                    {
                        if (list[i] > list[i + 1])
                        {
                            // Swap values at index i and i + 1
                            int holder = list[i + 1];
                            list[i + 1] = list[i];
                            list[i] = holder;
                            swap = true;
                            // Can be used for better visualisation
                            //PrintList(list);
                        }
                    }
                }
            } while (swap);

            return list;
        }
    }
}
