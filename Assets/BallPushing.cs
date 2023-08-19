using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPushing : MonoBehaviour
{
    public Vector3 pushDirection;
    public int distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            transform.position += pushDirection*distance;
        }
    }
}
