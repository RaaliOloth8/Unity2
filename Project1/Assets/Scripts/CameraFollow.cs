using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + new Vector3(0, 2, -2);
        transform.LookAt(target.position + new Vector3(0, 1, 0));
    }
}
