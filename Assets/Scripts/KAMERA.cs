using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KAMERA : MonoBehaviour
{

    public float rot_mult = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            //Debug.Log(Input.GetAxis("Mouse X").ToString());
            transform.Rotate(new Vector3(0f, Input.GetAxis("Mouse X"),0f) * rot_mult);
        }
    }
}
