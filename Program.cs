using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); 
            Console.WriteLine("Starting list: ");
            PrintList(list);
            Console.WriteLine("Sorting sequence: ");



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
        static void BubbleSort(List<int> list)
        {
            bool swap = false;
            for (int i = 0; i < list.Count; i++)
            {

            }
        }
    }
}
