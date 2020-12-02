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
    // Start is called before the first frame update
    

    private void OnEnable()
    {
        StartCoroutine(upperpanelcoroutine());
        StartCoroutine(eventbutton());
        StartCoroutine(chatbutton());
        StartCoroutine(shopsocialcoroutine());
        StartCoroutine(ranksetting());
        StartCoroutine(Delay(btn));
        
    }

    IEnumerator upperpanelcoroutine()
    {
        upperpanel.anchoredPosition=new Vector2(0,237);
        
        while (upperpanel.anchoredPosition.y>1 )
        {
            //yield return new WaitForSeconds(0.001f);
            upperpanel.anchoredPosition=new Vector2(0,upperpanel.anchoredPosition.y-1);
            
            //print(upperpanel.anchoredPosition.y);
            yield return null;
        }
    }

    IEnumerator shopsocialcoroutine()
    {
        shopsocial.anchoredPosition=new Vector2(-261,1);
        while (shopsocial.anchoredPosition.x<1)
        {
            //yield return new WaitForSeconds(0.001f);
           
            shopsocial.anchoredPosition=new Vector2(shopsocial.anchoredPosition.x+1,1);
            //print(upperpanel.anchoredPosition.y);
            
        }
        yield return null;
    }
    IEnumerator eventbutton()
    {
        eventb.anchoredPosition=new Vector2(-251,-1);
        while (eventb.anchoredPosition.x<0.1f)
        {
           
            print(eventb.anchoredPosition.x);
            //yield return new WaitForSeconds(0.001f);
           
            eventb.anchoredPosition=new Vector2(eventb.anchoredPosition.x+0.1f,-1);
            //print(upperpanel.anchoredPosition.y);
        }
        yield return null;
    }
    IEnumerator chatbutton()
    {
        yield return null;
    }
    IEnumerator ranksetting()
    {
        yield return null;
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
