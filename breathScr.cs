using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breathScr : MonoBehaviour
{
    Vector3 startPos;

    public float amplitude = 0.1f;
    public float period = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        startPos = transform.position;

        float theta = Time.timeSinceLevelLoad / period;
        float distance = amplitude * Mathf.Sin(theta);

        transform.position = startPos + Vector3.up * distance;
    }

    private void FixedUpdate()
    {
        
    }
}
