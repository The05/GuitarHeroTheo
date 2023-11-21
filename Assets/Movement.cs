using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float WalkingSpeed = 10f;
    public float TurningSpeed = 50f;

    float vel = 0f;
    float angVel = 0f;
    void Update()
    {
        vel = Mathf.Lerp(vel, Input.GetAxisRaw("Vertical") * WalkingSpeed, 4f * Time.deltaTime);
        angVel = Mathf.Lerp(angVel, Input.GetAxisRaw("Horizontal") * TurningSpeed, 4f * Time.deltaTime);

        transform.Rotate(transform.up, angVel * Time.deltaTime);
        transform.position += (vel *Time.deltaTime) * transform.forward;


    }
}
