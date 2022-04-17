using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    private Rigidbody rb;
    public float movement_speed = 5f;
    public float jumping_speed = 14000f;
    public Ground_Check luca;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && luca.IsTouch_State() == true)
        {
            //transform.Translate(new Vector3(0.0f, 1.0f, 0.0f) * Time.deltaTime * jumping_speed);
            rb.AddForce(new Vector3(0.0f, 1.0f, 0.0f) * jumping_speed);
        }
    }
}