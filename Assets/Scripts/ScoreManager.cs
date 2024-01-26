using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //スコア関連
    [SerializeField] Text scoreText;
    public int score;

    //コンボ関連
    [SerializeField] Text comboText;
    private int combo;

    //リザルト画面にスコアを渡す
    public int GetScore()
    {
        //Debug.Log(score);
        return score;
    }

    // スコア処理
    public void AddScore(int value, bool push)
    {
        comboText.enabled = true;
        if (push == true)
        {
            score += value;
        }
        else if (push == false)
        {

        }
        scoreText.text = "SCORE" + score;
    }

    // コンボ処理
    public void AddCombo(int count = 0, bool cr = true)
    {
        comboText.enabled = true;
        combo += count;
        comboText.text = "" + combo;
        if (combo > 1 && combo % 10 == 0)
        {
            score += 1000;
        }
    }

    // リセット処理(コンボ）
    public void ComboReset()
    {
        combo = 0;
        comboText.enabled = false;
    }
}