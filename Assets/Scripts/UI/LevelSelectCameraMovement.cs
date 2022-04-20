using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectCameraMovement : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 p = target.position;
        p.y = transform.position.y;
        transform.position = p;
    }
}
