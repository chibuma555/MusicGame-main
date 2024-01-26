using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartResultScene : MonoBehaviour
{
    //終了時に消すオブジェクトの定義
    GameObject judgeText_1;
    GameObject judgeText_2;
    GameObject judgeText_3;
    GameObject judgeText_4;
    GameObject scoreText;
    GameObject comboText;

    //ゲーム終了関連
    float totalTime = 58;
    int retime;
    bool is_gameEnd = false;

    //　最終スコアのオブジェクト定義
    public Text resultText;
    public Text resultrank;
    public ScoreManager scoremanajer;

    //最終スコア数値
    int totalscore;

    //リザルトGUI関連
    GameObject result;


    // Start is called before the first frame update
    void Start()
    {
        // リザルトGUI関連
        result = GameObject.Find("ResultStage");
        result.SetActive(false);
        
        
        //テキスト関連
        judgeText_1 = GameObject.Find("Judgetext(1)");
        judgeText_2 = GameObject.Find("Judgetext(2)");
        judgeText_3 = GameObject.Find("Judgetext(3)");
        judgeText_4 = GameObject.Find("Judgetext(4)");
        judgeText_1.SetActive(true);
        judgeText_2.SetActive(true);
        judgeText_3.SetActive(true);
        judgeText_4.SetActive(true);

        // スコア関連
        scoreText = GameObject.Find("Score");
        scoreText.SetActive(true);
        comboText = GameObject.Find("Combo");
        comboText.SetActive(true);
        scoremanajer = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        retime = (int)totalTime;
        GameEnd();
        Debug.Log(retime);
    }

    void GameEnd()
    {
        if(retime == 0)
        {
            //リザルト画面を表示
            is_gameEnd = true;
            result.SetActive(true);

            //各種機能の停止
            judgeText_1.SetActive(false);
            judgeText_2.SetActive(false);
            judgeText_3.SetActive(false);
            judgeText_4.SetActive(false);
            scoreText.SetActive(false);
            comboText.SetActive(false);
            

            //Getscoreを代入
            totalscore = scoremanajer.GetScore();

            //テキストの表示
            resultText.text = totalscore.ToString();

            //スコアによってランク(Sランク~Dランク)
            if (totalscore < 3000)
            {
                resultrank.text = "D";
            }
            else if (totalscore > 3000 && totalscore < 10000)
            {
                resultrank.text = "C";
            }
            else if (totalscore > 10000 && totalscore < 40000)
            {
                resultrank.text = "B";
            }
            else if (totalscore > 40000 && totalscore < 50000)
            {
                resultrank.text = "A";
            }
            else if (totalscore > 50000)
            {
                resultrank.text = "S";
            }
        }
    }

}
