using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectEventHandler : MonoBehaviour
{
    public delegate void voidEvent();
    public delegate void collisionEvent(Collision collision);
    public delegate void triggerEvent(Collider other);

    public voidEvent _Enable;
    public voidEvent _Awake;
    public voidEvent _Start;
    public voidEvent _Update;
    public collisionEvent _CollEnter;
    public collisionEvent _CollStay;
    public collisionEvent _CollExit;
    public triggerEvent _triggerEnter;
    public triggerEvent _triggerStay;
    public triggerEvent _triggerExit;


    private void OnEnable()
    {
        if (_Enable == null)
            return;

        _Enable();
    }

    private void Awake()
    {
        if (_Awake == null)
            return;

        _Awake();
    }

    void Start()
    {
        if (_Start == null)
            return;

        _Start();
    }

    void Update()
    {
        if (_Update == null)
            return;

        _Update();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (_CollEnter == null)
            return;

        _CollEnter(collision);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (_CollStay == null)
            return;

        _CollStay(collision);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (_CollExit == null)
            return;

        _CollExit(collision);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_triggerEnter == null)
            return;

        _triggerEnter(other);
    }

    private void OnTriggerStay(Collider other)
    {
        if (_triggerStay == null)
            return;

        _triggerStay(other);
    }

    private void OnTriggerExit(Collider other)
    {
        if (_triggerExit == null)
            return;

        _triggerExit(other);
    }
}
