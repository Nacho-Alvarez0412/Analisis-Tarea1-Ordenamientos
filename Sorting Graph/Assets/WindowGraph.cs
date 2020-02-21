using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class WindowGraph : MonoBehaviour
{
    [SerializeField] private static Sprite circleSprite;
    private static RectTransform graphContainer;
    
    private void Awake()
    {
        graphContainer = transform.Find("GraphContainer").GetComponent<RectTransform>();
        
    }
    
    void OnGUI()
    {
        
        // MAP LEYEND
        GUI.Label(new Rect(70, 507, 150, 40), "QuickSort");
        
        GUI.Label(new Rect(160, 507, 150, 40), "BubbleSort");
        
        // X AXIS
        GUI.Label(new Rect(25, 480, 150, 40), "Elements");
        GUI.Label(new Rect(90, 480, 150, 40), "500");
        GUI.Label(new Rect(140, 480, 150, 40), "1000");
        GUI.Label(new Rect(200, 480, 150, 40), "1500");
        GUI.Label(new Rect(260, 480, 150, 40), "2000");
        GUI.Label(new Rect(330, 480, 150, 40), "2500");
        GUI.Label(new Rect(390, 480, 150, 40), "3000");
        GUI.Label(new Rect(450, 480, 150, 40), "3500");
        GUI.Label(new Rect(510, 480, 150, 40), "4000");
        GUI.Label(new Rect(570, 480, 150, 40), "4500");
        GUI.Label(new Rect(630, 480, 150, 40), "5000");
        GUI.Label(new Rect(690, 480, 150, 40), "5500");
        GUI.Label(new Rect(750, 480, 150, 40), "6000");
        GUI.Label(new Rect(810, 480, 150, 40), "6500");
        GUI.Label(new Rect(860, 480, 150, 40), "7000");
        GUI.Label(new Rect(920, 480, 150, 40), "7500");
        
        
        // Y AXIS
        GUI.Label(new Rect(20, 10, 150, 40), "Miliseconds");
        GUI.Label(new Rect(40, 430, 150, 40), "5");
        GUI.Label(new Rect(40, 400, 150, 40), "10");
        GUI.Label(new Rect(40, 370, 150, 40), "20");
        GUI.Label(new Rect(40, 340, 150, 40), "60");
        GUI.Label(new Rect(40, 310, 150, 40), "80");
        GUI.Label(new Rect(40, 280, 150, 40), "100");
        GUI.Label(new Rect(40, 250, 150, 40), "120");
        GUI.Label(new Rect(40, 220, 150, 40), "140");
        GUI.Label(new Rect(40, 190, 150, 40), "160");
        GUI.Label(new Rect(40, 160, 150, 40), "180");
        GUI.Label(new Rect(40, 130, 150, 40), "200");
        GUI.Label(new Rect(40, 100, 150, 40), "220");
        GUI.Label(new Rect(40, 70, 150, 40), "240");
        GUI.Label(new Rect(40, 40, 150, 40), "280");
    }

    public static void CreateCircle(Vector2 anchoredPosition,String path)
    {
        GameObject gameObject = new GameObject("circle",typeof(Image));
        gameObject.transform.SetParent(graphContainer,false);
        gameObject.GetComponent<Image>().sprite = circleSprite;
        gameObject.GetComponent<Image>().sprite = AssetDatabase.GetBuiltinExtraResource<Sprite>(path);
        
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11,11);
        rectTransform.anchorMin = new Vector2(0,0);
        rectTransform.anchorMax = new Vector2(0,0);
    }

    public static void ShowGraph(List<long> valueList,String path)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float yMaximum = 350f;
        float xSize = 75f;
        float minXSize = 90;
        float minYSize = 90;

        for (int i = 0; i < valueList.Count; i++)
        {
            float xPosition = (i * xSize)+minXSize;
            float yPosition = ((valueList[i] / yMaximum) * graphHeight)+minYSize;
            CreateCircle(new Vector2(xPosition,yPosition),path);
        }
    }
    
}
