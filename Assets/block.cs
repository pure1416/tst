using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    private Rigidbody rb; // Rididbody

    GameObject Sunadokei;
    public GameObject Red;
    bool RedFlg;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Sunadokei = GameObject.Find("playerempty");

    }

    // Update is called once per frame
    void Update()
    {

        RedFlg = Sunadokei.GetComponent<player>().GetRedFlg();

        if (Sunadokei.GetComponent<player>().GetPlayerRotFlg() == true)
        {
            if (RedFlg == false)
            {
                rb.isKinematic = false;
            }
        }
        else
        {
            rb.isKinematic = true;
        }



        Debug.Log(Sunadokei.GetComponent<player>().GetPlayerRotFlg());
        Debug.Log("リジッド" +rb.isKinematic);

    }
}
