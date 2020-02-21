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
        //CreateCircle(new Vector2(200,200));
        
    }
    
    void OnGUI()
    {
        
        // MAP LEYEND
        CreateCircle(new Vector2(35,5),"UI/Skin/UISprite.psd");
        GUI.Label(new Rect(70, 517, 150, 40), "QuickSort");
        
        CreateCircle(new Vector2(130,5),"UI/Skin/Knob.psd");
        GUI.Label(new Rect(165, 517, 150, 40), "BubbleSort");
        
        // X AXIS
        GUI.Label(new Rect(35, 480, 150, 40), "Elements");
        GUI.Label(new Rect(100, 480, 150, 40), "500");
        GUI.Label(new Rect(150, 480, 150, 40), "1000");
        GUI.Label(new Rect(210, 480, 150, 40), "1500");
        GUI.Label(new Rect(270, 480, 150, 40), "2000");
        GUI.Label(new Rect(340, 480, 150, 40), "2500");
        GUI.Label(new Rect(400, 480, 150, 40), "3000");
        GUI.Label(new Rect(460, 480, 150, 40), "3500");
        GUI.Label(new Rect(520, 480, 150, 40), "4000");
        GUI.Label(new Rect(580, 480, 150, 40), "4500");
        GUI.Label(new Rect(640, 480, 150, 40), "5000");
        GUI.Label(new Rect(700, 480, 150, 40), "5500");
        GUI.Label(new Rect(760, 480, 150, 40), "6000");
        GUI.Label(new Rect(820, 480, 150, 40), "6500");
        GUI.Label(new Rect(870, 480, 150, 40), "7000");
        GUI.Label(new Rect(930, 480, 150, 40), "7500");
        
        
        // Y AXIS
        GUI.Label(new Rect(40, 10, 150, 40), "Miliseconds");
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
        float xSize = 60f;
        float minXSize = 85;
        float minYSize = 90;

        for (int i = 0; i < valueList.Count; i++)
        {
            float xPosition = (i * xSize)+minXSize;
            float yPosition = ((valueList[i] / yMaximum) * graphHeight)+minYSize;
            CreateCircle(new Vector2(xPosition,yPosition),path);
        }
    }
    
}
