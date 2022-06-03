using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
  
    class Program:Sorting
    {
        static void Main(string[] args)
        {
          
            int[] table = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Table[" + i + "]=");
                table[i] = int.Parse(Console.ReadLine());
            }
            
            int l = table.Length;
            Print(table);
            new Sorting().HeapSort(table);
            Console.WriteLine("\n");
            Print(table);
            Console.ReadKey();
        }
    }
}
