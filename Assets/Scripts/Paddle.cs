using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float minX = -2.25f;
    public float maxX = 2.25f;
    public float yPos = -4f;
    void Update()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float clampedX = Mathf.Clamp(mouseWorldPos.x, minX, maxX);
        transform.position = new Vector3(clampedX, yPos, 0f);
    }
}
