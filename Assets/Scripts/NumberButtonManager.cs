using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberButtonManager : MonoBehaviour
{
    
    [SerializeField] private GameManager gameManager;
    private string number;
    private Text buttonText;

    void Start()
    {
        buttonText = GetComponentInChildren<Text>();
        
    }

    public void OnClickButton()
    {
        number = buttonText.text;
        gameManager.NumberText.text += number;
    }

    public string GetNumber()
    {
        return number;
    }
}
