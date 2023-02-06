using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickControl : MonoBehaviour
{
    public float speed = 1.0f; // adjust to control the speed of movement

    private Transform transform;

    private void Start()
    {
        transform = GetComponent<Transform>();
    }

    private void Update()
    {
        // get the input axis values for the left joystick
        float x = Input.GetAxis("XRI_Left_Primary2DAxis_Horizontal");
        float y = Input.GetAxis("XRI_Left_Primary2DAxis_Vertical");

        // update the position of the GameObject
        Vector3 newPosition = transform.position + new Vector3(x, y, 0) * speed * Time.deltaTime;
        transform.position = newPosition;
    }
}