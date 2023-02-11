using UnityEngine;
using UnityEngine.XR;

public class MoveSpriteWithJoystick : MonoBehaviour
{
    private Vector2 joystickPosition;

    private void Update()
    {
        InputDevice leftOculusTouch = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);

        if (leftOculusTouch.TryGetFeatureValue(CommonUsages.primary2DAxis, out joystickPosition))
        {
            Vector3 newPosition = transform.position;
            newPosition.x += joystickPosition.x * Time.deltaTime;
            newPosition.y += joystickPosition.y * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}