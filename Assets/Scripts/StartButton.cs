using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField] private GameObject TitleView;
    [SerializeField] private GameObject GameView;
    [SerializeField] private GameManager gameManager;

    public void OnButtonClick()
    {
        TitleView.SetActive(false);
        GameView.SetActive(true);
        gameManager.Init();
    }
}
