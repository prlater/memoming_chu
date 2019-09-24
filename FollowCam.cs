using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform player;
    public Transform Cam;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Follow").GetComponent<Transform>();
        Cam = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Cam.position = new Vector3 (player.position.x, 3,player.position.z -2);
    }
}
