﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoppanelcoroutine : MonoBehaviour
{
    public RectTransform rewardchest;
    public RectTransform shopupperpanel;
    public RectTransform currencyGameplayDealsPanel;
    public RectTransform firstrechargepanel;
    public RectTransform gemsPanel;
    public RectTransform coinsPanel;
    
    private void OnEnable()
    {
        StartCoroutine(RewardChestcoroutine());
        StartCoroutine(firstrechargepanelcoroutine());
        StartCoroutine(Shopupperpanelcoroutine());
    }
    IEnumerator gemscoinscoroutine()
    {
        gemsPanel.anchoredPosition=new Vector2(-261,1);
        coinsPanel.anchoredPosition=new Vector2(-261,1);
        while (gemsPanel.anchoredPosition.x<1 &&     gemsPanel.anchoredPosition.x<1)
        {
            //yield return new WaitForSeconds(0.001f);
            //print(shopsocial.anchoredPosition.x);
            gemsPanel.anchoredPosition=new Vector2(gemsPanel.anchoredPosition.x+1,1);
            gemsPanel.anchoredPosition=new Vector2(gemsPanel.anchoredPosition.x+1,1);
            //print(upperpanel.anchoredPosition.y);
            yield return null;
        }
        
    }
    
    IEnumerator Shopupperpanelcoroutine()
    {
        shopupperpanel.anchoredPosition=new Vector2(0,237);
        
        while (shopupperpanel.anchoredPosition.y>1 )
        {
            //yield return new WaitForSeconds(0.001f);
            shopupperpanel.anchoredPosition=new Vector2(0,shopupperpanel.anchoredPosition.y-1);
            
            //print(upperpanel.anchoredPosition.y);
            yield return null;
        }
    }
    IEnumerator firstrechargepanelcoroutine()
    {
        firstrechargepanel.transform.localScale=new Vector2(.1f,.1f);
        while (firstrechargepanel.transform.localScale.x<1.2 && firstrechargepanel.transform.localScale.y<1.2)
        {
            yield return new WaitForSeconds(.01f);
            firstrechargepanel.transform.localScale=new Vector2(firstrechargepanel.transform.localScale.x+.1f,firstrechargepanel.transform.localScale.y+.1f);
            //print("scale");
        }
         
        while (firstrechargepanel.transform.localScale.x>1 && firstrechargepanel.transform.localScale.y>1)
        {
            yield return new WaitForSeconds(.01f);
            firstrechargepanel.transform.localScale=new Vector2(firstrechargepanel.transform.localScale.x-.01f,firstrechargepanel.transform.localScale.y-.01f);
            //print("scale");
        }
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
