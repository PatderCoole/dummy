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

        bool moved = false;
        Vector3 MovementVector = new Vector3(0,0,0);

        if (Input.GetKey(KeyCode.W))
        {
            MovementVector += new Vector3(0.0f, 0.0f, 1.0f);
            moved = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovementVector += new Vector3(0.0f, 0.0f, -1.0f);
            moved = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovementVector += new Vector3(1.0f, 0.0f, 0.0f);
            moved = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovementVector += new Vector3(-1.0f, 0.0f, 0.0f);
            moved = true;
        }

        if (moved == true)
        {
            transform.Translate(MovementVector.normalized * Time.deltaTime * movement_speed);
        }

        if (Input.GetKeyDown(KeyCode.Space) && luca.IsTouch_State() == true)
        {
            rb.AddForce(new Vector3(0.0f, 1.0f, 0.0f) * jumping_speed);
        }



    }
}