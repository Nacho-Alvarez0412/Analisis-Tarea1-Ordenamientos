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
