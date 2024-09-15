using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;  

public class NumberGenerator : MonoBehaviour
{
    [SerializeField] private Text number1Text = null;
    [SerializeField] private Text number2Text = null;  
    [SerializeField] private Text number3Text = null;
    [SerializeField] private Text number4Text = null;
    private int number;
    private string numberStr;
    public string NumberStr => numberStr;
    private int[] randomDigits;

    public void CreateNumber()
    {
        System.Random random = new System.Random();
        // 0から9の数字リストを作成
        List<int> digits = Enumerable.Range(0, 10).ToList();
        // リストからランダムに４つ選ぶ
        randomDigits = digits.OrderBy(x => random.Next()).Take(4).ToArray();

        numberStr = string.Join("", randomDigits);
        Debug.Log(numberStr);

    }

    public void ShowAnswer()
    {
                // Textに反映
        number1Text.text = randomDigits[0].ToString();
        number2Text.text = randomDigits[1].ToString();
        number3Text.text = randomDigits[2].ToString();
        number4Text.text = randomDigits[3].ToString();

    }
/*
    public void OnClickNumberButton()
    {
        Debug.Log("４桁の数が生成されました");
        CreateNumber();
    }
*/

}
