using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
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
}
