using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackGroundBGM : MonoBehaviour
{
    //public bool DontDestroyEnabled = true;
    GameObject bgm;

    // Use this for initialization
    void Start()
    {
        //Sceneを遷移してもオブジェクトが消えないようにする
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}