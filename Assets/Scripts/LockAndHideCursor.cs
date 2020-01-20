﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockAndHideCursor : MonoBehaviour
{
    public GameObject crosshair;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        // crosshair.transform.position = new Vector2(target.x, target.y);
    }
}
