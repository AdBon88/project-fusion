using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Oculus.XR;
using System;

public class OculusController : MonoBehaviour
{
    XRController controller;

    private void Awake()
    {
        controller = GetComponent<XRController>();
    }

    private void Update()
    {
    
        Console.WriteLine("HERE");
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue)
        {
            // Code to change properties of game objects goes here
        }

        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonValue) && secondaryButtonValue)
        {
            // Code to change properties of game objects goes here
        }
    }
}



// using UnityEngine;
// using System;

// public class JoystickMapper : MonoBehaviour
// {
//     public float speed = 10.0f;
//     private Transform gameObjectTransform;

//     void Start()
//     {
//         gameObjectTransform = GetComponent<Transform>();
//     }

//     void Update()
//     {
//         float horizontal = Input.GetAxis("XRI_Left_Primary2DAxis_Horizontal");
//         Console.WriteLine(horizontal);
//         float vertical = Input.GetAxis("XRI_Left_Primary2DAxis_Vertical");
//         Vector3 position = gameObjectTransform.position;
//         position.x += horizontal * speed * Time.deltaTime;
//         position.y += vertical * speed * Time.deltaTime;
//         gameObjectTransform.position = position;
//     }
// }