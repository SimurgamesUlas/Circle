using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleJumpController : MonoBehaviour
{
    [SerializeField] private CircleDataTransmiter circleDataTransmiter;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float circleJmupForce;

    void FixedUpdate()
    {
        setCircleJump();
    }

    private  void setCircleJump(){

        if(circleDataTransmiter.getIsTocuh()){
        rb.velocity = Vector2.up * circleJmupForce *  Time.fixedDeltaTime;
        }
    }
}
