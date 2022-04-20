using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PlayerStickToPlatformTrigger : MonoBehaviour
{
    public delegate void CollsionTriggerDeleg(Collider collider);
    private CollsionTriggerDeleg enter;
    private CollsionTriggerDeleg exit;

    private void Awake()
    {
        unregister();
    }

    public bool registerDelegates(CollsionTriggerDeleg new_enter, CollsionTriggerDeleg new_exit)
    {
        if(new_enter != null && new_exit != null)
        {
            enter = new_enter;
            exit = new_exit;

            return true;
        }
        else
        {
            return false;
        }
    }

    public void unregister()
    {
        enter = null;
        exit = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(enter != null)
        {
            enter(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit != null)
        {
            exit(other);
        }
    }
}
