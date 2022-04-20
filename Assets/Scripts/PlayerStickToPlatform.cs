using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PlayerStickToPlatform : MonoBehaviour
{
    private Player_Movement target;
    public PlayerStickToPlatformTrigger trigger;


    private void OnCollisionEnter(Collision collision)
    {
        if(target == null && trigger != null)
        {
            if (collision.gameObject.GetComponent<Player_Movement>() != null)
            {
                trigger.gameObject.SetActive(true);
                trigger.registerDelegates(TriggerOnTEnter, TriggerOnTExit);
            }
        }
    }

    private void TriggerOnTEnter(Collider collider)
    {
        if(target == null)
        {
            target = collider.gameObject.GetComponent<Player_Movement>();

            if(target != null)
            {
                target.gameObject.transform.SetParent(this.gameObject.transform);
            }
        }
    }

    private void TriggerOnTExit(Collider collider)
    {
        if(target != null)
        {
            target.gameObject.transform.SetParent(null);

            target = null;

            trigger.gameObject.SetActive(false);
        }
    }
}
