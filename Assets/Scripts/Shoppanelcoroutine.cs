﻿          using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoppanelcoroutine : MonoBehaviour
{
    public RectTransform rewardchest;
    public RectTransform shopupperpanel;
    public RectTransform currencyGameplayDealsPanel;
    public RectTransform firstrechargepanel;
    public RectTransform gemsPanel;
    public RectTransform coinsPanel;
    public Image Imagecolour;
    public float i = 0;
    public bool abc=true;
    
    private void OnEnable()
    {
        
        StartCoroutine(firstrechargepanelcoroutine());
        StartCoroutine(Shopupperpanelcoroutine());
        StartCoroutine(gemscoinscoroutine());
    }
    IEnumerator gemscoinscoroutine()    
    {
        gemsPanel.anchoredPosition=new Vector2(-600,1.52f);
        coinsPanel.anchoredPosition=new Vector2(600,1.52f);
        while (gemsPanel.anchoredPosition.x<-1.8 &&     coinsPanel.anchoredPosition.x>2.9)
        {
            gemsPanel.anchoredPosition=new Vector2(gemsPanel.anchoredPosition.x+5,1.52f);
            coinsPanel.anchoredPosition=new Vector2(coinsPanel.anchoredPosition.x-5,1.52f);
            yield return null;
        }
        
    }
    
    IEnumerator Shopupperpanelcoroutine()
    {
        shopupperpanel.anchoredPosition=new Vector2(0,237);
        currencyGameplayDealsPanel.anchoredPosition=new Vector2(-3,-237);
        while (shopupperpanel.anchoredPosition.y>-0.5f && currencyGameplayDealsPanel.anchoredPosition.y<0)
        {
            shopupperpanel.anchoredPosition=new Vector2(0,shopupperpanel.anchoredPosition.y-1);
            Debug.Log(shopupperpanel.anchoredPosition.y);
            currencyGameplayDealsPanel.anchoredPosition=new Vector2(-3,currencyGameplayDealsPanel.anchoredPosition.y+1);
            Debug.Log(currencyGameplayDealsPanel.anchoredPosition.y);
            yield return null;
        }
    }
    IEnumerator firstrechargepanelcoroutine()
    {
        firstrechargepanel.transform.localScale=new Vector2(.1f,.1f);
        rewardchest.transform.localScale = new Vector2(.1f, .1f);
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
        
        while (rewardchest.transform.localScale.x < 1.2 && rewardchest.transform.localScale.y < 1.2)
        {
            yield return new WaitForSeconds(.01f);
            rewardchest.transform.localScale = new Vector2(rewardchest.transform.localScale.x + .1f, rewardchest.transform.localScale.y + .1f);
            //print("scale");
        }

        while (rewardchest.transform.localScale.x > 1 && rewardchest.transform.localScale.y > 1)
        {
            yield return new WaitForSeconds(.01f);
            rewardchest.transform.localScale = new Vector2(rewardchest.transform.localScale.x - .01f, rewardchest.transform.localScale.y - .01f);
            //print("scale");
        }
    }

   
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
        changecolor();

    }
}
