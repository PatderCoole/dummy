using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class The_Death_Situation : MonoBehaviour
{

    public AudioSource bruh;
    public float respawn_hight = -10;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        respawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < respawn_hight)
        {
            kill();
        }
    }

    public void respawn()
    {
        transform.position = spawn.position;
    }

    public void kill()
    {
        bruh.time = 0.5f;
        bruh.Play();
        respawn();
    }
}
