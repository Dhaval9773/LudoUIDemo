using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public List<GameObject> DisabledPanels;
    public GameObject MainMenuPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        MainMenuPanel.SetActive(true);
        
        foreach (GameObject obj in DisabledPanels)
        {
            obj.SetActive(false);
        }
    }
}
