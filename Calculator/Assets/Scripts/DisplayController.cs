using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    [SerializeField]
    private TMPro.TMP_Text displayText;
    public Calculator calculator;

    void Start()
    {
        displayText =  GetComponentInChildren<TMPro.TMP_Text>();
    }
    public void ClearDisplay()
    {
        displayText.text = "";
    }
    public void UpdateDisplayText(string newText)
    {
        Debug.Log("appending..." + newText);
        if(displayText == null)
        {
            GameObject.Find("DisplayPanel").GetComponent<TMPro.TMP_Text>();
        }
        displayText.text += newText;
    }
    public void DisplayAnswer()
    {
       string answer = calculator.Calculate(displayText.text);
       displayText.text = answer; 
    }
}
