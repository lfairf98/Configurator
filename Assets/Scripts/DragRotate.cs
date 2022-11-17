using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRotate : MonoBehaviour
{
    public float rotationSpeed = 1f;

    float sceneWidth;
    Vector3 clickPoint;
    Quaternion startRotation;

    private void Start()
    {
        sceneWidth = Screen.width;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPoint = Input.mousePosition;
            startRotation = transform.rotation;
        }
        else if (Input.GetMouseButton(0))
        {
            float distBetween = (Input.mousePosition - clickPoint).x;
            transform.rotation = startRotation * Quaternion.Euler(Vector3.down * (distBetween / sceneWidth) * 360);
        }
    }

    /*void OnMouseDrag()
    {
        xRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        yRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.Rotate(Vector3.down, xRotation);
        transform.Rotate(Vector3.right, yRotation);
    }
    */
}
