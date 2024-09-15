/** ゲーム全体の流れを管理するためのスクリプト **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text numberText;
    [SerializeField] private Text hitblowText;
    [SerializeField] private NumberGenerator numberGenerator;
    [SerializeField] private GameObject ClearPanel;
    [SerializeField] private ShowNumber showNumber;
    public Text NumberText => numberText;
    void Init()
    {
        numberText.text = "";
        hitblowText.text = "";
        numberGenerator.CreateNumber();
    }

    void Start()
    {
        Init();
    }

    void Update()
    {
        //Debug.Log(numberText.text);
        if(numberGenerator.NumberStr == numberText.text) GameClear();
        if(numberText.text.Length == 4)
        {
            showNumber.ShowNumberText(numberText);
            HitBlow();
        }
    }

    public void GameClear()
    {    
        ClearPanel.SetActive(true);
        numberText.text = "";
    }

    public void RestNumberText()
    {
        numberText.text = "";
    }

    public void HitBlow()
    {
        string playerInput = numberText.text;  // プレイヤーが入力した4桁の数字
        string correctAnswer = numberGenerator.NumberStr;  // 正解の4桁の数字

        // Hit、Blowの判定
        (int hits, int blows) = JudgeHitAndBlow(playerInput, correctAnswer);

        // 判定結果を表示
        hitblowText.text = $"Hit: {hits}, Blow: {blows}";

        // 入力フィールドをクリア
        numberText.text = "";

    }

     // Hit and Blowの判定ロジック
    (int hits, int blows) JudgeHitAndBlow(string playerInput, string correctAnswer)
    {
        int hits = 0;
        int blows = 0;

        // ヒットの判定
        for (int i = 0; i < playerInput.Length; i++)
        {
            if (playerInput[i] == correctAnswer[i])
            {
                hits++;
            }
        }

        // ブローの判定
        for (int i = 0; i < playerInput.Length; i++)
        {
            if (playerInput[i] != correctAnswer[i] && correctAnswer.Contains(playerInput[i].ToString()))
            {
                blows++;
            }
        }

        return (hits, blows);
    }
}
