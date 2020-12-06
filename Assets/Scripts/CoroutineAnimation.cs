using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineAnimation : MonoBehaviour
{
   
    public RectTransform upperpanel;
    public RectTransform shopsocial;
    public RectTransform eventb;
    public RectTransform chatb;
    public RectTransform ranksettingpanel;
    public List<GameObject> btn;
    public float speed;
    

    private void OnEnable()
    {
        StartCoroutine(eventshopsocial());
        StartCoroutine(upperpanelcoroutine());
        StartCoroutine(chatranksetting());
        StartCoroutine(Delay(btn));
    }

    IEnumerator eventshopsocial()
    {
        shopsocial.anchoredPosition=new Vector2(-261,1);
        eventb.anchoredPosition=new Vector2(-222,-1);
        while (eventb.anchoredPosition.x<0.7f)
        {
            eventb.anchoredPosition=new Vector2(eventb.anchoredPosition.x+4,-1);
            yield return null;
        }
        while (shopsocial.anchoredPosition.x<1)
        {
            shopsocial.anchoredPosition=new Vector2(shopsocial.anchoredPosition.x+4,1);
            yield return null;
        }
    }
    IEnumerator upperpanelcoroutine()
    {
        upperpanel.anchoredPosition=new Vector2(0,237);
        while (upperpanel.anchoredPosition.y>1 )
        {
            upperpanel.anchoredPosition=new Vector2(0,upperpanel.anchoredPosition.y-4);
            yield return null;
        }
    }
    IEnumerator chatranksetting()
    {
        chatb.anchoredPosition = new Vector2(282, 0.2f); 
        ranksettingpanel.anchoredPosition = new Vector2(262, 0);
        while (chatb.anchoredPosition.x > -0.2f)
        {
            chatb.anchoredPosition = new Vector2(chatb.anchoredPosition.x - 4, 0.2f);
            yield return null;
        }
        while (ranksettingpanel.anchoredPosition.x > -0.5f)
        {
            ranksettingpanel.anchoredPosition = new Vector2(ranksettingpanel.anchoredPosition.x - 4,0);
            yield return null;
        }
    }
    
    IEnumerator Delay(List<GameObject> obj)
    {
        int i = 0;
        while (i<5)
        {
            if (i==1 || i==2)
            {
                StartCoroutine(Scale(obj[i]));
                i++;
                yield return new WaitForSeconds(0.01f);
            }
            else
            {
                StartCoroutine(Scale(obj[i]));
                i++;
                yield return new WaitForSeconds(0.1f);
            }
            
        }
    }
    IEnumerator Scale(GameObject obj1)
    {
        obj1.transform.localScale=new Vector2(.1f,.1f);
        while (obj1.transform.localScale.x<1.2 && obj1.transform.localScale.y<1.2)
        {
            yield return new WaitForSeconds(.01f);
            obj1.transform.localScale=new Vector2(obj1.transform.localScale.x+.1f,obj1.transform.localScale.y+.1f);
            //print("scale");
        }
         
        while (obj1.transform.localScale.x>1 && obj1.transform.localScale.y>1)
        {
            yield return new WaitForSeconds(.01f);
            obj1.transform.localScale=new Vector2(obj1.transform.localScale.x-.01f,obj1.transform.localScale.y-.01f);
            //print("scale");
        }
        yield return null;
    }
    
}
