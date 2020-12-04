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
        uniScript.OnActive(startButton); 
    }
}
