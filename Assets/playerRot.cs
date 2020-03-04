using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRot : MonoBehaviour
{
    public bool redrot = true; // 動く速さ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform sampleTransform = this.transform;

        Vector3 worldAngle = sampleTransform.eulerAngles;


        //回転
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (redrot == true)
            {
                worldAngle.x = 180.0f;
                worldAngle.y = 0.0f;
                worldAngle.z = 0.0f;
                sampleTransform.eulerAngles = worldAngle;
                //float angle = Mathf.LerpAngle(0, 180, Time.time);
                //transform.eulerAngles = new Vector3(angle, 0, 0);
                redrot = false;
            }
            else
            {
                worldAngle.x = 0.0f;
                worldAngle.y = 0.0f;
                worldAngle.z = 0.0f;
                sampleTransform.eulerAngles = worldAngle;
                //float angle = Mathf.LerpAngle(180, 0, Time.time);
                //transform.eulerAngles = new Vector3(angle, 0, 0);
                redrot = true;

            }
            //transform.localEulerAngles.x
        }
    }
}
