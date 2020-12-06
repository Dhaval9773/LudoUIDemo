using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currencybydefault : MonoBehaviour
{
    // Start is called before the first frame update
    public Universal uniScript;

    public GameObject startButton;
    
    public void bydefault()
    {
        print("gems bydefault");
        uniScript.OnActive(startButton); 
    }
}
