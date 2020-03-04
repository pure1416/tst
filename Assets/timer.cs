using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    GameObject time;
    string strNowTime;
    bool CntStartFlg;
    public GameObject gameobject;

    public float totalTime;
    int seconds;
    
    // Use this for initialization
    void Start()
    {
        time = GameObject.Find("timer");   // 時間計測用GameObjectの取得

    }

    // Update is called once per frame
    void Update()
    {
        CntStartFlg = gameobject.GetComponent<player>().GetPlayerRotFlg();
        if (CntStartFlg == true)
        {
            totalTime -= Time.deltaTime;
            seconds = (int)totalTime;
            strNowTime = seconds.ToString();   // TextMeshのGameObjectに代入するためにString型にする
            time.GetComponent<TextMesh>().text = strNowTime;
        }
        else
        {
            totalTime = 5;
            seconds = 5;
            time.GetComponent<TextMesh>().text = "";

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            totalTime = 5;
        }
    

    }

    //取得用関数
    public int GetTimer()
    {
        return seconds;
    }
}