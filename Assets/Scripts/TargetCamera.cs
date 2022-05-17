using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCamera : MonoBehaviour
{
    [Range(0.1f, 10f)]
    public float lookSensitivity;
    [Range(0.1f, 1f)]
    public float lookSpeed;

    public Vector2 MinMaxAngle = new Vector2(-65, 65);

    private float xRot;
    private float yRot;

    private float currentXrot;
    private float currentYrot;

    private float xRotVelocity;
    private float yRotVelocity;

    void Update()
    {
        yRot += Input.GetAxis("Mouse X") * lookSensitivity; //マウスの移動.
        xRot -= Input.GetAxis("Mouse Y") * lookSensitivity; //マウスの移動.



        xRot = Mathf.Clamp(xRot, MinMaxAngle.x, MinMaxAngle.y);//上下の角度移動の最大、最小.


        currentXrot = Mathf.SmoothDamp(currentXrot, xRot, ref xRotVelocity, lookSpeed);
        currentYrot = Mathf.SmoothDamp(currentYrot, yRot, ref yRotVelocity, lookSpeed);

        transform.rotation = Quaternion.Euler(currentXrot, currentYrot, 0);

    }
}
