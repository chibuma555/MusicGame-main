using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotuGenerator : MonoBehaviour
{

    //オブジェクトを定義
    public GameObject NotuPrefab;
    //リストを定義
    List<GameObject> ListValue = new List<GameObject>();

    float xpos_1 = -3.9f;
    float xpos_2 = -1.25f;
    float xpos_3 = 1.31f;
    float xpos_4 = 3.9f;

    float ypos = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        for (int i =0; i <= 70; i++)
        {
            GameObject notu = Instantiate(NotuPrefab);
            ListValue.Add(notu);
        }
       
        ListValue[0].transform.position = new Vector3(xpos_1, ypos, 5f);
        ListValue[1].transform.position = new Vector3(xpos_3, ypos, 10f);
        ListValue[2].transform.position = new Vector3(xpos_2, ypos, 15f);
        ListValue[3].transform.position = new Vector3(xpos_4, ypos, 17f);
        ListValue[4].transform.position = new Vector3(xpos_1, ypos, 30f);

        ListValue[5].transform.position = new Vector3(xpos_1, ypos, 40f);
        ListValue[6].transform.position = new Vector3(xpos_1, ypos, 50f);
        ListValue[7].transform.position = new Vector3(xpos_4, ypos, 60f);
        ListValue[8].transform.position = new Vector3(xpos_3, ypos, 70f);
     
        ListValue[9].transform.position = new Vector3(xpos_1, ypos, 80f);
        ListValue[10].transform.position = new Vector3(xpos_3, ypos, 90f);
        ListValue[11].transform.position = new Vector3(xpos_2, ypos, 100f);
        ListValue[12].transform.position = new Vector3(xpos_2, ypos, 110f);

        ListValue[13].transform.position = new Vector3(xpos_3, ypos, 130f);
        ListValue[14].transform.position = new Vector3(xpos_1, ypos, 130f);
   
        ListValue[15].transform.position = new Vector3(xpos_1, ypos, 140f);
        ListValue[16].transform.position = new Vector3(xpos_4, ypos, 150f);
        ListValue[17].transform.position = new Vector3(xpos_2, ypos, 160f);
        ListValue[18].transform.position = new Vector3(xpos_3, ypos, 170f);
        ListValue[19].transform.position = new Vector3(xpos_4, ypos, 180f);

        ListValue[20].transform.position = new Vector3(xpos_2, ypos, 200f);
        ListValue[21].transform.position = new Vector3(xpos_4, ypos, 210f);
        ListValue[22].transform.position = new Vector3(xpos_2, ypos, 220f);
        ListValue[23].transform.position = new Vector3(xpos_3, ypos, 220f);
  
        ListValue[24].transform.position = new Vector3(xpos_2, ypos, 250f);
        ListValue[25].transform.position = new Vector3(xpos_3, ypos, 260f);
        ListValue[26].transform.position = new Vector3(xpos_2, ypos, 280f);
        ListValue[27].transform.position = new Vector3(xpos_3, ypos, 280f);
        ListValue[28].transform.position = new Vector3(xpos_4, ypos, 300f);
        ListValue[29].transform.position = new Vector3(xpos_1, ypos, 310f);
        ListValue[30].transform.position = new Vector3(xpos_2, ypos, 320f);
       
        ListValue[31].transform.position = new Vector3(xpos_2, ypos, 330f);
        ListValue[32].transform.position = new Vector3(xpos_3, ypos, 340f);
       
        ListValue[33].transform.position = new Vector3(xpos_1, ypos, 350f);
        ListValue[34].transform.position = new Vector3(xpos_4, ypos, 360f);
        ListValue[35].transform.position = new Vector3(xpos_1, ypos, 370f);
        ListValue[36].transform.position = new Vector3(xpos_4, ypos, 380f);
        
        ListValue[37].transform.position = new Vector3(xpos_2, ypos, 390f);
        ListValue[38].transform.position = new Vector3(xpos_3, ypos, 400f);
        
        ListValue[39].transform.position = new Vector3(xpos_2, ypos, 400f);
        ListValue[40].transform.position = new Vector3(xpos_3, ypos, 410f);
        ListValue[41].transform.position = new Vector3(xpos_1, ypos, 420f);
        ListValue[42].transform.position = new Vector3(xpos_4, ypos, 420f);
        ListValue[43].transform.position = new Vector3(xpos_1, ypos, 430f);
        ListValue[44].transform.position = new Vector3(xpos_4, ypos, 440f);
        ListValue[45].transform.position = new Vector3(xpos_2, ypos, 450f);
        ListValue[46].transform.position = new Vector3(xpos_3, ypos, 450f);

        ListValue[47].transform.position = new Vector3(xpos_2, ypos, 470f);

        ListValue[48].transform.position = new Vector3(xpos_2, ypos, 480f);
        ListValue[49].transform.position = new Vector3(xpos_4, ypos, 500f);
        ListValue[50].transform.position = new Vector3(xpos_3, ypos, 510f);

        ListValue[51].transform.position = new Vector3(xpos_4, ypos, 510f);
        ListValue[52].transform.position = new Vector3(xpos_2, ypos, 520f);
        ListValue[53].transform.position = new Vector3(xpos_4, ypos, 520f);
        ListValue[54].transform.position = new Vector3(xpos_1, ypos, 530f);

        ListValue[55].transform.position = new Vector3(xpos_1, ypos, 540f);
        ListValue[56].transform.position = new Vector3(xpos_1, ypos, 560f);
        ListValue[57].transform.position = new Vector3(xpos_4, ypos, 570f);
        ListValue[58].transform.position = new Vector3(xpos_3, ypos, 570f);
  
        ListValue[59].transform.position = new Vector3(xpos_1, ypos, 580f);
        ListValue[60].transform.position = new Vector3(xpos_3, ypos, 590f);
        ListValue[61].transform.position = new Vector3(xpos_2, ypos, 595f);
        ListValue[62].transform.position = new Vector3(xpos_2, ypos, 600f);

        ListValue[63].transform.position = new Vector3(xpos_3, ypos, 610f);
        ListValue[64].transform.position = new Vector3(xpos_1, ypos, 615f);
        ListValue[65].transform.position = new Vector3(xpos_1, ypos, 620f);

        ListValue[66].transform.position = new Vector3(xpos_3, ypos, 630f);
        ListValue[67].transform.position = new Vector3(xpos_2, ypos, 630f);
        ListValue[68].transform.position = new Vector3(xpos_4, ypos, 640f);
        ListValue[69].transform.position = new Vector3(xpos_3, ypos, 645f);
        ListValue[70].transform.position = new Vector3(xpos_1, ypos, 650f);
    }

}
