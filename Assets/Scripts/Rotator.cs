using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed = 1.0f;
    public axis _axis = axis.X;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(_axis)
        {
            case axis.X:
                {
                    transform.RotateAround(new Vector3(1, 0, 0), rotateSpeed * Time.deltaTime);
                }
                break;

            case axis.Y:
                {
                    transform.RotateAround(new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);
                }
                break;

            case axis.Z:
                {
                    transform.RotateAround(new Vector3(0, 0, 1), rotateSpeed * Time.deltaTime);
                }
                break;
            default:
                {
                    transform.RotateAround(new Vector3(1, 0, 0), rotateSpeed * Time.deltaTime);
                }
                break;

        }

        
    }

    public enum axis
    {
        X,
        Y,
        Z
    };
}
