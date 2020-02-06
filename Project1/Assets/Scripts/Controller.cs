using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0,0,0);
        float speed = 0;

        if(Input.GetKey(KeyCode.W))
        {
            direction.z = 1;
            speed = 10;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -1;
            speed = 10;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.z = -1;
            speed = 10;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 1;
            speed = 10;
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20;
        }

        direction *= speed;
        direction.y = body.velocity.y;

        body.velocity = direction;
    }
}
