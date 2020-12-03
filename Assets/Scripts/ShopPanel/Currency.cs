using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public List<GameObject> disable;
    public GameObject enable;
    public List<TMP_Text> changecolour;
    public GameObject currencyimage;
    public TMP_Text currencycolor;
    public Color32 ActiveColor;
    public Color32 DeactiveColor;

    public void Enabledisable()
    {
        print(this.gameObject);
        enable.SetActive(true);
        currencyimage.SetActive(true);
        currencycolor.color = ActiveColor;
        foreach (GameObject obj in disable)
        {
            obj.SetActive(false);
        }
        foreach (TMP_Text obj in changecolour)
        {
            obj.color = DeactiveColor;
        }
    }

    private void Start()
    {
        print(this.gameObject);
        enable.SetActive(true);
        currencyimage.SetActive(true);
        currencycolor.color = ActiveColor;
        foreach (GameObject obj in disable  )
        {
            obj.SetActive(false);
        }
        foreach (TMP_Text obj in changecolour)
        {
            obj.color = DeactiveColor;
        }
    }

   
}
