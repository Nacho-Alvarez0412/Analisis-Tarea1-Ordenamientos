using System;
using System.Collections;
using Ordenamientos_Tarea1.Properties;

namespace Ordenamientos_Tarea1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] list1 = ListManager.listGenerator(4);
            Console.WriteLine(ListManager.ToString(list1));
            ListManager.bubbleSort(list1);
            Console.WriteLine(ListManager.ToString(list1));
        }
    }
}