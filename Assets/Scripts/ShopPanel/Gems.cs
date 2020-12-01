using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Gems : MonoBehaviour
{
    public GameObject enableobj;
    public GameObject disableobj;
    // Start is called before the first frame update
    public GameObject imagegems;
    public TMP_Text textgems;
    public GameObject imagecoins;
    public TMP_Text textcoins; 

    public void enable()
    {
        enableobj.SetActive(true);
        disableobj.SetActive(false);
        imagegems.GetComponent<Image>().enabled=true;
        imagecoins.GetComponent<Image>().enabled=false;
        textgems.color= new Color32(7, 41, 116, 255);
        textcoins.color= new Color32(36, 179, 255, 255);
    }

    void Start()
    {
        imagegems.GetComponent<Image>().enabled=true;
        imagecoins.GetComponent<Image>().enabled=false;
        textcoins.color= new Color32(35, 176, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
