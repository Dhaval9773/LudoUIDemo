using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Imagecolour;
    public float i = 0;
    private bool abc=true;

    public void changecolor()
    {
        Imagecolour.color=new Color(0,0,0,i);
        if (abc==true && i<1)
        {
            Imagecolour.color+=new Color(0,0,0,i);
            i+=0.01f;
            print(i);
        }
        else
        {
            Imagecolour.color+=new Color(0,0,0,i);
            i-=0.01f;
            print(i);
            abc = false;
        }
    }
    void Update()
    {
        //changecolor();

    }
}
