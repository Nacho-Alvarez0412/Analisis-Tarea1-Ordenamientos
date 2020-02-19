using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 101; i++)
        {
            int arrayLength = i*100;
            int[] list1 = ListManager.listGenerator(arrayLength);
            long execTime = ListManager.bubbleSort(list1);
            print("With an array of "+arrayLength+" numbers, the execution time for bubble sort was: "+execTime+ " miliseconds");
        }

        for (int i = 1; i < 101; i++)
        {
            int arrayLength = i * 1500;
            int[] list2 = ListManager.listGenerator(arrayLength);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            ListManager.quickSort(list2, 0, list2.Length - 1);
            watch.Stop();
            long execTime = watch.ElapsedMilliseconds;
            print("With an array of " + arrayLength +
                              " numbers, the execution time for quicksort was: " + execTime + " miliseconds");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
