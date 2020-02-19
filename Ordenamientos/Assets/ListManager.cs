using System;
using System.Collections;

public static class ListManager
{
    public static int[] listGenerator(int size)
    {
        int[] list = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            list[i] = random.Next(0, 100000);
        }
        return list;
    }

    public static string ToString(int[] list)
    {
        string printedList = "";

        foreach (int element in list)
        {
            printedList = printedList + element + ", ";
        }
        return printedList;
    }
        
    public static void quickSort(int[] vector, int primero, int ultimo)
    {
        int i, j, central;
        double pivote;
        central = (primero + ultimo) / 2;
        pivote = vector[central];
        i = primero;
        j = ultimo;
        do
        {
            while (vector[i] < pivote) i++;
            while (vector[j] > pivote) j--;
            if (i <= j)
            {
                int temp;
                temp = vector[i];
                vector[i] = vector[j];
                vector[j] = temp;
                i++;
                j--;
            }
        } while (i <= j);

        if (primero < j)
        {
            quickSort(vector, primero, j);
        }
        if (i < ultimo)
        {
            quickSort(vector, i, ultimo);
        }
    }
        
    public static long bubbleSort(int[] array)
    {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        int length = array.Length;

        int temp = array[0];

        for (int i = 0; i < length; i++)
        {
            for (int j = i+1; j < length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];

                    array[i] = array[j];

                    array[j] = temp;
                }
            }
        }
        watch.Stop();
        return watch.ElapsedMilliseconds;
    }
}