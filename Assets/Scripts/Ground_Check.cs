using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Check : MonoBehaviour
{

    private bool Is_touching = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Is_touching = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Is_touching = false;
    }

    public bool IsTouch_State()
    {
        return Is_touching;
    }
}
