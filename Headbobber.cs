using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headbobber : MonoBehaviour
{
    private float timer = 0.0f;
    public float bobbingSpeed = 0.18f;
    public float bobbingAmount = 0.2f;
    public float midpoint = 0.25f;

    public float amplitude = 0.25f;
    public float period = 0.125f;

    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float waveslice = 0.0f;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        startPos = transform.position;


        if (Mathf.Abs(horizontal)==0&&Mathf.Abs(vertical)==0)//아무 움직임이 없을떄
        {
            //숨쉬기버전 1

            Debug.Log("breath");
            
            float theta = Time.timeSinceLevelLoad / period;
            float distance = amplitude * Mathf.Sin(theta);
            transform.position = startPos + Vector3.up * distance;

            Debug.Log("현재위치: "+ startPos);


            timer = 0.0f;
        }
        else //키입력을 받을 때
        {
            waveslice = Mathf.Sin(timer);
            Debug.Log(Mathf.Sin(timer));
            timer = timer + bobbingSpeed;
            if(timer > Mathf.PI * 2)
            {
                timer = timer - (Mathf.PI * 2);
            }
        }

        Vector3 v3T = transform.localPosition;
        if (waveslice != 0)
        {
            float translateChange = waveslice * bobbingAmount;
            float totalAxes = Mathf.Abs(horizontal) + Mathf.Abs(vertical);
            totalAxes = Mathf.Clamp(totalAxes, 0.0f, 1.0f);
            v3T.y = midpoint + translateChange;
        }
        else
        {
            //v3T.y = midpoint;
        }
        transform.localPosition = v3T;
    }

}
