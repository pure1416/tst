using UnityEngine;

public class player : MonoBehaviour
{
    GameObject timercnt;

    public float speed = 20; // 動く速さ
    public bool  red = true;

    private Rigidbody rb; // Rididbody
    public Vector3 eulerAngles;
    public int RotStartCnt;
    public bool RotStartFlg;
    public GameObject TimerScri;
    public GameObject RedStorm;
    public GameObject BlueStorm;


    void Start()
    {
        // Rigidbody を取得
        rb = GetComponent<Rigidbody>();
        timercnt = GameObject.Find("timer");   // 時間計測用GameObjectの取得
        RotStartFlg = false;

    }

    void Update()
    {
        //// カーソルキーの入力を取得
        //var moveHorizontal = Input.GetAxis("Horizontal");
        //var moveVertical = Input.GetAxis("Vertical");

        //// カーソルキーの入力に合わせて移動方向を設定
        //var movement = new Vector3(moveHorizontal, 0, moveVertical);

        //// Ridigbody に力を与えて玉を動かす
        //rb.AddForce(movement * speed);

        //if (Input.GetAxis("Horizontal"))
        //{
        //    this.gameObject.transform.Translate(0.05f, 0, 0);
        //}

        //if (Input.GetAxis("Vertical"))
        //{
        //    this.gameObject.transform.Translate(0.05f, 0, 0);
        //}
        // transformを取得
        Transform myTransform = this.transform;

        // ローカル座標を基準に、座標を取得
        Vector3 localPos = myTransform.localPosition;
        float x = localPos.x;    // ローカル座標を基準にした、x座標が入っている変数
        float y = localPos.y;    // ローカル座標を基準にした、y座標が入っている変数
        float z = localPos.z;    // ローカル座標を基準にした、z座標が入っている変数

        if (x > 5)
        {
            x = 5;
        }
        //タイマー取得
        RotStartCnt = TimerScri.GetComponent<timer>().GetTimer();



        if (red == true)
        {
            //赤砂の中
            if (x > -0.5f && x < 1.5f)
            {
                if (RotStartCnt < 5)
                {
                    this.transform.Translate(0.0f, 0.0f, -0.01f);
                }
                //左に移動
                if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                    this.transform.Translate(0.005f, 0.0f, 0.0f);
                }

                // 右に移動
                if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                {
                    this.transform.Translate(-0.005f, 0.0f, 0.0f);
                }
                // 前に移動
                if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
                {
                    this.transform.Translate(0.0f, 0.0f, -0.005f);
                }
                // 後ろに移動
                if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
                {
                    this.transform.Translate(0.0f, 0.0f, 0.005f);
                }
            }
            //普通砂
            else
            {
                if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                    this.transform.Translate(0.01f, 0.0f, 0.0f);
                }
                // 右に移動

                if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                {
                    this.transform.Translate(-0.01f, 0.0f, 0.0f);
                }

                // 前に移動
                if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
                {
                    this.transform.Translate(0.0f, 0.0f, -0.01f);
                }
                // 後ろに移動
                if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
                {
                    this.transform.Translate(0.0f, 0.0f, 0.01f);
                }
            }
        }
        else
        {

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                this.transform.Translate(0.01f, 0.0f, 0.0f);
            }
            // 右に移動

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                this.transform.Translate(-0.01f, 0.0f, 0.0f);
            }

            // 前に移動
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(0.0f, 0.0f, -0.01f);
            }
            // 後ろに移動
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                this.transform.Translate(0.0f, 0.0f, 0.01f);
            }

        }

        //回転
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RotStartFlg = true;
            if (red == true)
            {
                //float angle = Mathf.LerpAngle(0, 180, Time.time);
                //transform.eulerAngles = new Vector3(angle, 0, 0);
                red = false;
            }
            else
            {
                //float angle = Mathf.LerpAngle(180, 0, Time.time);
                //transform.eulerAngles = new Vector3(angle, 0, 0);
                red = true;

            }
            //transform.localEulerAngles.x
        }
        if (RotStartFlg == true)
        {

        }

        if (RotStartCnt <= 0)
        {
            RotStartFlg = false;
        }

        if (red == true)
        {
            BlueStorm.SetActive(false);
            RedStorm.SetActive(true);
        }
        else
        {
            BlueStorm.SetActive(true);
            RedStorm.SetActive(false);
        }


    }

    //取得用関数
    public bool GetPlayerRotFlg()
    {
        return RotStartFlg;
    }


    //取得用関数
    public bool GetRedFlg()
    {
        return red;
    }
}