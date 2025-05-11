using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float minX = -7.5f;
    public float maxX = 7.5f;
    public float yPos = -4f;
    void Update()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float clampedX = Mathf.Clamp(mouseWorldPos.x, minX, maxX);
        transform.position = new Vector3(clampedX, yPos, 0f);
    }
}
