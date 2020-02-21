using System;
using System.Collections.Generic;
using UnityEngine;

public class SortingScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        this.makeLists();
        
    }
    

    public void makeLists()
    {
        List<long> bubbleTimes;
        bubbleTimes = new List<long>();
        
        List<long> quickSortTimes;
        quickSortTimes = new List<long>();
        
        for (int i = 1; i < 16; i++)
        {
            int arrayLength = i*500;
            
            int[] list1 = ListManager.listGenerator(arrayLength);
            long execTime = ListManager.bubbleSort(list1);
            print("With an array of "+arrayLength+" numbers, the execution time for bubble sort was: "+execTime+ " miliseconds");
            bubbleTimes.Add(execTime);
            
        }
        
        WindowGraph.ShowGraph(bubbleTimes,"UI/Skin/Knob.psd");

        for (int i = 1; i < 16; i++)
        {
            int arrayLength = i * 500;
            int[] list2 = ListManager.listGenerator(arrayLength);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            ListManager.quickSort(list2, 0, list2.Length - 1);
            watch.Stop();
            long execTime = watch.ElapsedMilliseconds;
            print("With an array of " + arrayLength +
                  " numbers, the execution time for quicksort was: " + execTime + " miliseconds");
            //WindowGraph.CreateCircle(new Vector2(arrayLength,execTime));
            quickSortTimes.Add(execTime);
        }
        
        WindowGraph.ShowGraph(quickSortTimes,"UI/Skin/UISprite.psd");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
