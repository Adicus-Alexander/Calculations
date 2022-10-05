using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    private Text displayText;
    public Calculator calculator;

    void Start()
    {
        displayText = 
    GameObject.Find("DisplayPanel").GetComponent<Text>();
    }
    public void ClearDisplay()
    {
        displayText.text = "";
    }
    public void UpdateDisplayText(string newText)
    {
        if(displayText == null)
        {
            GameObject.Find("DisplayPanel").GetComponent<Text>();
        }
        displayText.text += newText;
    }
    public void DisplayAnswer()
    {
       string answer = calculator.Calculate(displayText.text);
       displayText.text = answer; 
    }
}
