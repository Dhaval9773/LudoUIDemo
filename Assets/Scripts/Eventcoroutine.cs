using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventcoroutine : MonoBehaviour
{
    
    public List<GameObject> panels;

    private void OnEnable()
    {
        StartCoroutine(Delay(panels));
    }
    IEnumerator Delay(List<GameObject> obj)
    {
        
        foreach(GameObject ob in panels)
        {
            StartCoroutine(Scale(ob));
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator Scale(GameObject obj1)
    {
        obj1.transform.localScale = new Vector2(.1f, .1f);
        while (obj1.transform.localScale.x < 1.2 && obj1.transform.localScale.y < 1.2)
        {
            yield return new WaitForSeconds(.01f);
            obj1.transform.localScale = new Vector2(obj1.transform.localScale.x + .1f, obj1.transform.localScale.y + .1f);
            //print("scale");
        }

        while (obj1.transform.localScale.x > 1 && obj1.transform.localScale.y > 1)
        {
            yield return new WaitForSeconds(.01f);
            obj1.transform.localScale = new Vector2(obj1.transform.localScale.x - .01f, obj1.transform.localScale.y - .01f);
            //print("scale");
        }
        yield return null;
    }
}
