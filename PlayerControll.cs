using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

    Rigidbody rd;
    public float playerSpeed;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))//W키 : 앞으로 이동
        {
            rd.velocity += new Vector3(0, 0, playerSpeed);
            if(rd.velocity.z > playerSpeed)
            {
                rd.velocity = new Vector3(rd.velocity.x, rd.velocity.y, playerSpeed);
            }
        }

        if (Input.GetKey(KeyCode.S))//S키 : 뒤로 이동
        {
            rd.velocity -= new Vector3(0, 0, playerSpeed);
            if (rd.velocity.z < -playerSpeed)
            {
                rd.velocity = new Vector3(rd.velocity.x, rd.velocity.y, -playerSpeed);
            }
        }

        if (Input.GetKey(KeyCode.A))//A키 : 좌로 이동
        {
            rd.velocity -= new Vector3(playerSpeed, 0, 0);
            if (rd.velocity.x < -playerSpeed)
            {
                rd.velocity = new Vector3(-playerSpeed, rd.velocity.y, rd.velocity.z);
            }
        }

        if (Input.GetKey(KeyCode.D))//D키 : 우로 이동
        {
            rd.velocity += new Vector3(playerSpeed, 0, 0);
            if (rd.velocity.x > playerSpeed)
            {
                rd.velocity = new Vector3(playerSpeed, rd.velocity.y, rd.velocity.z);
            }
        }
    }
}
