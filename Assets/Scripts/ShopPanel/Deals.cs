using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Deals : MonoBehaviour
{
    public List<GameObject> disableimages;
    public List<TMP_Text> changecolour;
    

    public void Enabledisable()
    {
        foreach (GameObject obj in disableimages)
        {
            obj.SetActive(false);
        }
        foreach (TMP_Text obj in changecolour)
        {
            obj.color= new Color32(36, 179, 255, 255);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
