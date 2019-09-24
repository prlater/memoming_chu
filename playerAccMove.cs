using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAccMove : MonoBehaviour
{
    public float accSpeed = 0.5f;
    public float acceleration = 0.2f;

    private float accCurrentHoriSpeed;
    private float accTargetHoriSpeed;
    private float accCurrentVerSpeed;
    private float accTargetVerSpeed;


    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float hori_raw = Input.GetAxisRaw("Horizontal");
        float ver_raw = Input.GetAxisRaw("Vertical");

        accTargetHoriSpeed = hori_raw * accSpeed;
        accCurrentHoriSpeed = IncrementTowards(accCurrentHoriSpeed, accTargetHoriSpeed, acceleration);

        accTargetVerSpeed = ver_raw * accSpeed;
        accCurrentVerSpeed = IncrementTowards(accCurrentVerSpeed, accTargetVerSpeed, acceleration);

        transform.Translate(accCurrentHoriSpeed, 0, accCurrentVerSpeed);
    }

    private float IncrementTowards(float n, float target, float a)
    {
        if(n == target)
        {
            return n;
        }
        else
        {
            float dir = Mathf.Sign(target - n);
            n += a * Time.deltaTime * dir;
            return (dir == Mathf.Sign(target - n)) ? n : target;
        }
    }
}
