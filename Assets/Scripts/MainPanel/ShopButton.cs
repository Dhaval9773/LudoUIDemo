using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    public List<GameObject> Disable;
    public List<GameObject> Enable;

    public Universal uniScript;

    public List<GameObject> startButton;

    public void Start()
    {
        
    }

    public void goToShopPanel()
    {
        print("gotoshop");
        foreach (GameObject obj in Disable)
        {
            obj.SetActive(false);
        }
        foreach (GameObject obj in Enable)
        {
            obj.SetActive(true);
        }
        print("bydefault");
        foreach (GameObject obj in startButton)
        {
            uniScript.OnActive(obj);
        }
        
    }
    

   
}
