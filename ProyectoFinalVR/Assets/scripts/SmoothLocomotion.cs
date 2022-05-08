using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class SmoothLocomotion : MonoBehaviour
{
    public SteamVR_Action_Vector2 moveValue;
    public float maxSpeed;
    public float sensitivity;
    public float collidingDistance;
    public Rigidbody head;


    float speed = 0;
   
    void Update()
    {
        RaycastHit hit;

        if(head.SweepTest(Player.instance.hmdTransform.TransformDirection(Vector3.forward), out hit, collidingDistance))
        {

        }
        else
        {
            if (moveValue.axis.y > 0)
            {
                Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(0, 0, moveValue.axis.y));
                speed = moveValue.axis.y * sensitivity;
                speed = Mathf.Clamp(speed, 0, maxSpeed);
                transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
            }
        }
    }
}
