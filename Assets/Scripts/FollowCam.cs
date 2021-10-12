using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform rig;
    [SerializeField] Transform rig2;
    [SerializeField] Transform rig3;

    [SerializeField] float distance = 10f;
    [SerializeField] float rotationSpeed = 10f;

    Vector3 cameraPosition;
    Vector3 smoothPosition;
    float smoothTime = 0.125f;
    float angle;

    int camType = 0;

    //Switch Camera Angles Using "C" Key On Keyboard
    void Update()
    {
        if (Input.GetKeyDown("c")) camType = ++camType % 5;
    }

    void FixedUpdate()
    {
        if (camType == 0) MainCam();
        else if (camType == 1) RigCam();
        else if (camType == 2) Rig2Cam();
        else if (camType == 3) Rig3Cam();
        else if (camType == 4) BackCam();
        else MainCam();
    }
    
    void MainCam()
    {
        Vector3 moveCamTo = target.position - target.forward * 10.0f + Vector3.up * 1.0f;
        float bias = 0.96f;
        transform.position = transform.position * bias +
                                         moveCamTo * (1.0f - bias);
        transform.LookAt(target.position + target.forward * 30.0f);
    }

    void RigCam()
    {
        transform.position = rig.position;
        transform.rotation = rig.rotation;
    }

    void Rig2Cam()
    {
        transform.position = rig2.position;
        transform.rotation = rig2.rotation;
    }

    void Rig3Cam()
    {
        transform.position = rig3.position;
        transform.rotation = rig3.rotation;
    }

    void BackCam()
    {
        //Calculate Postion
        cameraPosition = target.position - (target.forward * distance) + target.up * distance * 0.5f;
        smoothPosition = Vector3.Lerp(transform.position, cameraPosition, smoothTime);
        transform.position = smoothPosition;

        //Calculate Rotation
        angle = Mathf.Abs(Quaternion.Angle(transform.rotation, target.rotation));
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, (rotationSpeed + angle) * Time.deltaTime);
    }

}