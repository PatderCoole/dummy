using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMovement : MonoBehaviour
{

    public Transform start;
    public Transform goal;
    Vector3 MovementVector = new Vector3(0, 0, 0);
    public float movementSpeed = 0.1f;
    bool reached = false;
    bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position != goal.position && reached == false)
        {
            MovementVector = new Vector3(0f, 0f, -1f);
            moving = true;
        }

        if (transform.position == goal.position)
        {
            reached = true;
        }

        if (transform.position != start.position && reached == true)
        {
            MovementVector = new Vector3(0f, 0f, 1f);
            moving = true;
        }

        if (transform.position == start.position)
        {
            reached = false;
        }

        if (moving == true)
        {
            transform.Translate(MovementVector.normalized * movementSpeed);
        }
    }

}
