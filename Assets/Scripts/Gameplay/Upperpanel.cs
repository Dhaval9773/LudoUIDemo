using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Upperpanel : MonoBehaviour
{
    public List<GameObject> disable;
    public GameObject enable;
    public List<TMP_Text> changecolour;
    public List<Image> buttonimage;
    public Image image;
    public TMP_Text color;
    public Color32 ActiveColor;
    public Color32 DeactiveColor;

    public void Enabledisable()
    {

        image.color = ActiveColor; 
        enable.SetActive(true);
        
        color.color = ActiveColor;
        foreach (Image obj in buttonimage)
        {
            obj.color=DeactiveColor;
        }
        foreach (GameObject obj in disable)
        {
            obj.SetActive(false);
        }
        foreach (TMP_Text obj in changecolour)
        {
            obj.color = DeactiveColor;
        }
        Debug.Log("Enable",this);
    }
    
    void Start()
    {
        enable.SetActive(true);
        image.color = ActiveColor; 
        color.color = ActiveColor;
        foreach (Image obj in buttonimage)
        {
            obj.color=DeactiveColor;
        }
        foreach (GameObject obj in disable  )
        {
            obj.SetActive(false);
        }
        foreach (TMP_Text obj in changecolour)
        {
            obj.color = DeactiveColor;
        }
        Debug.Log("Start",this);
    }
}
