using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float acceleration;
    public float rotationSpeed;
    public bool canDrift = false;
    public float maxSpeed;

    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AddSpeed();
        AddRotation();
        if(!canDrift)
            AdjustRotation();
    }

    void AddSpeed()
    {
        //Vorwärts/Rückwärts
        if(rigid.velocity.magnitude <= maxSpeed)
        {
            float speed = Input.GetAxis("Vertical") * acceleration;
            Vector3 velocity = transform.forward * speed;
            rigid.AddForce(velocity);
        }
    }

    void AddRotation()
    {
        //Auto rotieren
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        transform.Rotate(Vector3.up, rotation);
    }

    void AdjustRotation()
    {
        Vector3 velocity = rigid.velocity;
        velocity = Vector3.Project(velocity, transform.forward);
        rigid.velocity = velocity;
    }

    public float GetSpeed()
    {
        return rigid.velocity.magnitude;
    }
}
