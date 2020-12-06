using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Universal : MonoBehaviour
{
    public List<GameObject> DeactiveList;
   
    public Color ActiveColor;
    public Color DeactiveColor;
   
    //public GameObject Panel;
    public List<GameObject> DisabledPanels;

    public void Start()
    {
        
    }

    public void OpenPanel(GameObject obj)
    {
        //Activepanel
        obj.SetActive(true);
       
        //Deactivepanel
        foreach (GameObject obj1 in DisabledPanels)
        {
            if (obj != obj1)
            {
                obj1.SetActive(false);
            }
        }
    }
    
    public void onClick(GameObject obj)
    {
        Debug.Log("Event is clicked");
        print(obj.gameObject.name);
    }
    
    public void OnActive(GameObject obj)
    {
        print(obj);
        //Active button
        obj.transform.GetChild(0).gameObject.SetActive(true);
        obj.transform.GetChild(1).GetComponent<TMP_Text>().color = ActiveColor;
        obj.transform.GetChild(2).gameObject.SetActive(true);
        //Deactive button
        foreach (GameObject obj1 in DeactiveList)
        {
            if (obj != obj1)
            {
                obj1.transform.GetChild(0).gameObject.SetActive(false);
                obj1.transform.GetChild(1).GetComponent<TMP_Text>().color = DeactiveColor;
                obj1.transform.GetChild(2).gameObject.SetActive(false);   
            }
        }
    }
    public void OnActiveImage(GameObject obj)
    {
        //Activeimage
        obj.transform.GetChild(2).GetComponent<Image>().color = ActiveColor;

        //Deactiveimage
        foreach (GameObject obj1 in DeactiveList)
        {
            if (obj != obj1)
            {
                obj1.transform.GetChild(2).gameObject.SetActive(true);
                obj1.transform.GetChild(2).GetComponent<Image>().color = DeactiveColor;
            }
        }
    }
    
}

