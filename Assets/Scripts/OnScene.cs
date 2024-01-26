using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnScene : MonoBehaviour
{

    public void OnRetry()
    {
        //SceneManager.LoadScene("SampleScene");
        FadeManager.Instance.LoadScene("SampleScene", 0.3f);
    }

    public void OnSelect()
    {
        //SceneManager.LoadScene("SelectGames");
        FadeManager.Instance.LoadScene("SelectGames", 0.3f);
    }

    
}
