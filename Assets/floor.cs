using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    public GameObject FloorPrefab;// 作りたいプレファブを格納するための変数
    GameObject Sunadokei;
    public GameObject Red;
    bool RedFlg;

    // Start is called before the first frame update
    void Start()
    {
        Sunadokei = GameObject.Find("playerempty"); 
    }

    // Update is called once per frame
    void Update()
    {


        RedFlg = Sunadokei.GetComponent<player>().GetRedFlg();

        if (RedFlg == true)
        {
            this.transform.Translate(0.0f, 0.0f, -0.01f);
        }
        if (transform.position.z < -1.0f)
        {
            GameObject Floor = Instantiate(FloorPrefab) as GameObject;
            // ランダムな場所に配置する
            Floor.transform.position = new Vector3(0.5f, -0.1f, 5);

            //消す
            Destroy(gameObject);
        }
    }

}
