using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public string value;
   public DisplayController displayController;
   public 
    void Start()
    {
        displayController = GameObject.Find("DisplayPanel").GetComponent<DisplayController>();
        
    }

    // Update is called once per frame
    void Update()
    {if()
        {

        }
    }
}
