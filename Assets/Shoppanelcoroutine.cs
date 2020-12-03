using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoppanelcoroutine : MonoBehaviour
{
    public RectTransform rewardchest;
    public RectTransform shopupperpanel;
    public RectTransform currencyGameplayDealsPanel;
    public RectTransform firstrechargepanel;
    public RectTransform gemsCoinsPanel;
    
    private void OnEnable()
    {
        StartCoroutine(RewardChestcoroutine());
    }

    IEnumerator RewardChestcoroutine()
    {
        rewardchest.transform.localScale=new Vector2(.1f,.1f);
        while (rewardchest.transform.localScale.x<1.2 && rewardchest.transform.localScale.y<1.2)
        {
            yield return new WaitForSeconds(.01f);
            rewardchest.transform.localScale=new Vector2(rewardchest.transform.localScale.x+.1f,rewardchest.transform.localScale.y+.1f);
            //print("scale");
        }
         
        while (rewardchest.transform.localScale.x>1 && rewardchest.transform.localScale.y>1)
        {
            yield return new WaitForSeconds(.01f);
            rewardchest.transform.localScale=new Vector2(rewardchest.transform.localScale.x-.01f,rewardchest.transform.localScale.y-.01f);
            //print("scale");
        }
    }
}
