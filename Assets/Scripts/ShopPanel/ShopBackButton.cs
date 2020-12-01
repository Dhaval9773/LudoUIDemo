using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBackButton : MonoBehaviour
{
    public List<GameObject> Disable;
    public List<GameObject> Enable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void goToMainManu()
    {
        foreach (GameObject obj in Disable)
        {
            obj.SetActive(false);
        }
        foreach (GameObject obj in Enable)
        {
            obj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
