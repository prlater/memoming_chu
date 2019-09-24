using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour//플레이어 등속이동
{
    public Transform player_transform;

        public KeyCode UP;
        public KeyCode DOWN;
        public KeyCode LEFT;
        public KeyCode RIGHT;

    

    // Start is called before the first frame update
    void Start()
    {
        player_transform = GameObject.Find("Cube").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 playerMove=Vector3.zero;
    
        if(Input.GetKeyDown(UP))
        {
            playerMove.z += 1.0f;
            player_transform.Translate(playerMove);                
        }
        if (Input.GetKeyDown(DOWN))
        {
            playerMove.z -= 1.0f;
            player_transform.Translate(playerMove);

        }
        if(Input.GetKeyDown(RIGHT))
        {
            playerMove.x += 1.0f;
            player_transform.Translate(playerMove);
        }
        if (Input.GetKeyDown(LEFT))
        {
            playerMove.x -= 1.0f;
            player_transform.Translate(playerMove);
        }

    }
}
