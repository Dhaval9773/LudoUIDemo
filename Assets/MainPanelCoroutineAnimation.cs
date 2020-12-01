using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanelCoroutineAnimation : MonoBehaviour
{
    public RectTransform upperpanel;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(demo());

    }

    /*IEnumerator demo()
    {
        /*print("Before Yield");
        
        
        yield return new WaitForSeconds(2);
        print("After 2 second");
        
        yield return new WaitForSeconds(8);
        print("After 8 second");#1#
    }*/

    private void OnEnable()
    {
        upperpanel.anchoredPosition=new Vector2(0,242);
        print(upperpanel.anchoredPosition.y);
    }

    // Update is called once per frame
    void Update()
    {
        if ( upperpanel.anchoredPosition.y==-1)
        {
             print(upperpanel.anchoredPosition.y);
        }
        else
        {
            upperpanel.anchoredPosition=new Vector2(0,upperpanel.anchoredPosition.y-1);
        }
        print(upperpanel.anchoredPosition.y);
    }
}
