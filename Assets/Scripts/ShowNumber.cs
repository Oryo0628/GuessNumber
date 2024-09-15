using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNumber : MonoBehaviour
{
    [SerializeField] private GameObject numberTextPrefab;

    public void ShowNumberText(Text number)
    {
        numberTextPrefab.GetComponent<Text>().text = number.text;
        Instantiate(numberTextPrefab, transform);
        
    }
}
