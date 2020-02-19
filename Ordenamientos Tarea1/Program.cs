using System;
using System.Collections;
using Ordenamientos_Tarea1.Properties;

namespace Ordenamientos_Tarea1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                int arrayLength = i*100;
                int[] list1 = ListManager.listGenerator(arrayLength);
                long execTime = ListManager.bubbleSort(list1);
                Console.WriteLine("With an array of "+arrayLength+" numbers, the execution time for bubble sort was: "+execTime+ " miliseconds");
            }

            for (int i = 1; i < 101; i++)
            {
                int arrayLength = i * 15000;
                int[] list2 = ListManager.listGenerator(arrayLength);
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                ListManager.quickSort(list2, 0, list2.Length - 1);
                watch.Stop();
                long execTime = watch.ElapsedMilliseconds;
                Console.WriteLine("With an array of " + arrayLength +
                                  " numbers, the execution time for quicksort was: " + execTime + " miliseconds");
            }
        }
    }
}