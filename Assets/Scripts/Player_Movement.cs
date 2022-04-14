using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float movement_speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0.0f,0.0f,1.0f) * Time.deltaTime * movement_speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0.0f, 0.0f, -1.0f) * Time.deltaTime * movement_speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1.0f, 0.0f, 0.0f) * Time.deltaTime * movement_speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1.0f, 0.0f, 0.0f) * Time.deltaTime * movement_speed);
        }
    }
}
