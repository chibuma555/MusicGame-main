using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    private Text text;
    private float time;
    public float fadetime;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        fadetime = text.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        fadetime += 0.01f;
        text.color = new Color(1,1,1,fadetime); 
    }
}
