using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public GameObject enableobj;
    public GameObject disableobj;
    public GameObject imagegems;
    public TMP_Text Textgems;
    public GameObject imagecoins;
    public TMP_Text Textcoins;
    
    public void enable()
    {
        enableobj.SetActive(true);
        disableobj.SetActive(false);
        imagegems.GetComponent<Image>().enabled=false;
        imagecoins.GetComponent<Image>().enabled=true;
        Textgems.color= new Color32(36, 179, 255, 255);
        Textcoins.color= new Color32(7, 41, 116, 255);
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
