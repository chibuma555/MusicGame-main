using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotuController : MonoBehaviour
{

    // 速度関連(ノーツ)
    Rigidbody rb;
    private float velocityX = 0f;
    private float velocityY = 0f;
    private float velocityZ = -13f;

    // x座標関連(ノーツ)
    float xpos_1 = -3.9f;
    float xpos_2 = -1.25f;
    float xpos_3 = 1.31f;
    float xpos_4 = 3.9f;

    // 判定ライン関連(ノーツ,判定オブジェクト)
    [SerializeField] float BadPosition;
    [SerializeField] float GoodPosition;
    [SerializeField] float GreatPosition;
    [SerializeField] float ParfectPosition;
    public GameObject judgeArea;

    // テキスト関連(スコア含む)
    public Text judgeText_1;
    private Text judgeText_2;
    private Text judgeText_3;
    private Text judgeText_4;
    private ScoreManager sm;

    // BGM関連
    AudioSource sound;
    public AudioClip Clip;

    // アニメーション,エフェクト関連
    [SerializeField] GameObject m_crashEffectPrefab = default;
    [SerializeField] Animator textAnime_1;
    [SerializeField] Animator textAnime_2;
    [SerializeField] Animator textAnime_3;
    [SerializeField] Animator textAnime_4;

    bool a = false;




    // Start is called before the first frame update
    void Start()
    {
        // 各種オブジェクトの取得
        rb = GetComponent<Rigidbody>();
        judgeArea = GameObject.Find("JudgeArea");

        judgeText_1 = GameObject.Find("Judgetext(1)").GetComponent<Text>();
        judgeText_2 = GameObject.Find("Judgetext(2)").GetComponent<Text>();
        judgeText_3 = GameObject.Find("Judgetext(3)").GetComponent<Text>();
        judgeText_4 = GameObject.Find("Judgetext(4)").GetComponent<Text>();

        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        sound = GetComponent<AudioSource>();
        // アニメーション
        textAnime_1 = GameObject.Find("Judgetext(1)").GetComponent<Animator>();
        textAnime_2 = GameObject.Find("Judgetext(2)").GetComponent<Animator>();
        textAnime_3 = GameObject.Find("Judgetext(3)").GetComponent<Animator>();
        textAnime_4 = GameObject.Find("Judgetext(4)").GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ノーツに一定の速度を付与
        rb.velocity = new Vector3(velocityX, velocityY, velocityZ);
    }

    void Update()
    {
        // ノーツと判定エリアの距離
        float offsetZ = judgeArea.transform.position.z - this.transform.position.z;

        // 各キーの処理
        if (this.gameObject.transform.position.x == xpos_1)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (offsetZ > ParfectPosition)
                {
                    judgeText_1.text = "Parfect";
                    judgeText_1.color = new Color(1.0f,0.1f,0,1.0f);
                    textAnime_1.SetBool("is_drow", true);
                    sm.AddScore(700, true);
                    sm.AddCombo(count:1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GreatPosition)
                {
                    
                    judgeText_1.text = "Great";
                    judgeText_1.color = new Color(1.0f, 0.5f, 0, 1.0f);
                    textAnime_1.SetBool("is_drow", true);
                    sm.AddScore(500, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();

                }
                else if (offsetZ > GoodPosition)
                {
                    
                    judgeText_1.text = "Good";
                    judgeText_1.color = new Color(1.0f, 0.9f, 0, 1.0f);
                    textAnime_1.SetBool("is_drow", true);
                    sm.AddScore(100, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();

                }
                else if (offsetZ > BadPosition)
                {
                    
                    judgeText_1.text = "Bad";
                    judgeText_1.color = new Color(0, 0.8f, 1.0f, 1.0f);
                    textAnime_1.SetBool("is_drow", true);
                    sm.ComboReset();
                    sound.PlayOneShot(Clip);
                    Explode();

                }
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                textAnime_1.SetBool("is_drow", false);
            }
            
        }

        if (this.gameObject.transform.position.x == xpos_2)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (offsetZ > ParfectPosition)
                {
                    judgeText_2.text = "Parfect";
                    judgeText_2.color = new Color(1.0f, 0.1f, 0, 1.0f);
                    textAnime_2.SetBool("is_drow", true);
                    sm.AddScore(700, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GreatPosition)
                {
                    judgeText_2.text = "Great";
                    judgeText_2.color = new Color(1.0f, 0.5f, 0, 1.0f);
                    textAnime_2.SetBool("is_drow", true);
                    sm.AddScore(500, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GoodPosition)
                {
                    judgeText_2.text = "Good";
                    judgeText_2.color = new Color(1.0f, 0.9f, 0, 1.0f);
                    textAnime_2.SetBool("is_drow", true);
                    sm.AddScore(100, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > BadPosition)
                {
                    judgeText_2.text = "Bad";
                    judgeText_2.color = new Color(0, 0.8f, 1.0f, 1.0f);
                    textAnime_2.SetBool("is_drow", true);
                    sm.ComboReset();
                    sound.PlayOneShot(Clip);
                    Explode();
                }
            }
            else if (Input.GetKeyUp(KeyCode.F))
            {
                textAnime_2.SetBool("is_drow", false);
            }
        }

        if (this.transform.position.x == xpos_3)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (offsetZ > ParfectPosition)
                {
                    judgeText_3.text = "Parfect";
                    judgeText_3.color = new Color(1.0f, 0.1f, 0, 1.0f);
                    textAnime_3.SetBool("is_drow", true);
                    sm.AddScore(700, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GreatPosition)
                {
                    judgeText_3.text = "Great";
                    judgeText_3.color = new Color(1.0f, 0.5f, 0, 1.0f);
                    textAnime_3.SetBool("is_drow", true);
                    sm.AddScore(500, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GoodPosition)
                {
                    judgeText_3.text = "Good";
                    judgeText_3.color = new Color(1.0f, 0.9f, 0, 1.0f);
                    textAnime_3.SetBool("is_drow", true);
                    sm.AddScore(100, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > BadPosition)
                {
                    judgeText_3.text = "Bad";
                    judgeText_3.color = new Color(0, 0.8f, 1.0f, 1.0f);
                    textAnime_3.SetBool("is_drow", true);
                    sm.ComboReset();
                    sound.PlayOneShot(Clip);
                    Explode();
                }
            }
            else if (Input.GetKeyUp(KeyCode.J))
            {
                textAnime_3.SetBool("is_drow", false);
            }
        }

        if (this.transform.position.x == xpos_4)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                if (offsetZ > ParfectPosition)
                {
                    judgeText_4.text = "Parfect";
                    judgeText_4.color = new Color(1.0f, 0.1f, 0, 1.0f);
                    textAnime_4.SetBool("is_drow", true);
                    sm.AddScore(700, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GreatPosition)
                {
                    judgeText_4.text = "Great";
                    judgeText_4.color = new Color(1.0f, 0.5f, 0, 1.0f);
                    textAnime_4.SetBool("is_drow", true);
                    sm.AddScore(500, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > GoodPosition)
                {
                    judgeText_4.text = "Good";
                    judgeText_4.color = new Color(1.0f, 0.9f, 0, 1.0f);
                    textAnime_4.SetBool("is_drow", true);
                    sm.AddScore(100, true);
                    sm.AddCombo(count: 1);
                    sound.PlayOneShot(Clip);
                    Explode();
                }
                else if (offsetZ > BadPosition)
                {
                    judgeText_4.text = "Bad";
                    judgeText_4.color = new Color(0, 0.8f, 1.0f, 1.0f);
                    textAnime_4.SetBool("is_drow", true);
                    sm.ComboReset();
                    sound.PlayOneShot(Clip);
                    Explode();
                }
            }
            else if (Input.GetKeyUp(KeyCode.K))
            {
                textAnime_4.SetBool("is_drow", false);
            }
        }
    }

    // ノーツエフェクト
    void Explode()
    {
       Instantiate(m_crashEffectPrefab, this.transform.position, Quaternion.identity);
       Destroy(this.gameObject);
    }


    //衝突判定(miss時のみ)
    void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.tag == "badArea")
         {
            if (this.transform.position.x == xpos_1)
            {
                judgeText_1.text = "Miss";
                judgeText_1.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                textAnime_1.SetBool("is_drow", true);
                sm.ComboReset();
                Destroy(this.gameObject);
            }

            if (this.transform.position.x == xpos_2)
            {
                judgeText_2.text = "Miss";
                judgeText_2.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                textAnime_2.SetBool("is_drow", true);
                sm.ComboReset();
            }

            if (this.transform.position.x == xpos_3)
            {
                judgeText_3.text = "Miss";
                judgeText_3.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                textAnime_3.SetBool("is_drow", true);
                sm.ComboReset();
            }

            if (this.transform.position.x == xpos_4)
            {
                judgeText_4.text = "Miss";
                judgeText_4.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                textAnime_4.SetBool("is_drow", true);
                sm.ComboReset();
            }
            Invoke("Destroyer", 0.1f);
         }
        
    }
    void Destroyer()
    {
        Destroy(this.gameObject);
        textAnime_1.SetBool("is_drow", false);
        textAnime_2.SetBool("is_drow", false);
        textAnime_3.SetBool("is_drow", false);
        textAnime_4.SetBool("is_drow", false);
    }
}
    
     