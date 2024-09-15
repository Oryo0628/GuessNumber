using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TitleButton : MonoBehaviour
{
    [SerializeField] private GameObject gameEndView;
    [SerializeField] private GameObject titleView;
    public void OnButtonClick()
    {
        gameEndView.SetActive(false);
        titleView.SetActive(true);
    }
}
