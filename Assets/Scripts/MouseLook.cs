﻿using System;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;

    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis

    public bool lockCursor = true;

    void Start ()
    {
        Vector3 rot = transform.rotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;

    }

    void Update ()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        Quaternion rotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = rotation;

        Cursor.lockState = lockCursor?CursorLockMode.Locked:CursorLockMode.None;
        Cursor.visible = !lockCursor;
    }
}