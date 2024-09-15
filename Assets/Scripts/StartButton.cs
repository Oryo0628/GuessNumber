using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField] private GameObject TitleView;
    [SerializeField] private GameObject GameView;

    public void OnButtonClick()
    {
        TitleView.SetActive(false);
        GameView.SetActive(true);
    }
}
