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
   
    public GameObject Panel;
    public List<GameObject> DisabledPanels;

    public void Start()
    {
        OnActive(DeactiveList[0]);
    }

    public void OpenPanel()
    {
        foreach(GameObject obj  in DisabledPanels)
        {
            obj.SetActive(false);
        }
        Panel.SetActive(true);
    }
    
    public void onClick(GameObject obj)
    {
        Debug.Log("Event is clicked");
        print(obj.gameObject.name);
    }
    
    public void OnActive(GameObject obj)
    {
        //Active button
        print(obj.name);
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
    
    // public void OnDeActive(GameObject obj)
    // {
    //     /*if (obj.transform.GetChild(0).gameObject.activeSelf)
    //     {*/
    //        
    //     //}
    // }
    
    public void OnActiveImage(GameObject obj)
    {
        obj.transform.GetChild(2).GetComponent<Image>().color = ActiveColor;
    }
    public void OnDeActiveImage(GameObject obj)
    {
        if (obj.transform.GetChild(0).gameObject.activeSelf)
        {
            foreach (GameObject obj1 in DeactiveList)
            {
                if (obj != obj1)
                {
                    obj1.transform.GetChild(2).GetComponent<Image>().color = DeactiveColor;
                }
            }
        }
    }
}

