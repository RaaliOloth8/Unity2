using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAnim : MonoBehaviour
{
    Rigidbody body;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
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

        float yAngle = Mathf.Atan2(direction.x, direction.z) * 180 / Mathf.PI;
        Vector3 targetAngle = new Vector3(0, yAngle, 0);

        direction *= speed;
        direction.y = body.velocity.y;

        body.velocity = direction;
        body.rotation = Quaternion.Lerp(body.rotation, Quaternion.Euler(targetAngle), Time.fixedDeltaTime * 20);

        animator.SetFloat("Speed", speed);
    }
}
