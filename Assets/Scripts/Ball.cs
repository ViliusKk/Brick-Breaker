using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float initialSpeed = 5f;
    private Rigidbody2D rb;
    private bool launched = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.velocity = Vector2.zero;
    }

    void Update()
    {
        if (!launched && Input.GetKeyDown(KeyCode.Space))
        {
            launched = true;
            rb.velocity = new Vector2(Random.Range(-1f, 1f), 1f).normalized * initialSpeed;
        }
    }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     Vector2 velocity = rb.velocity;
    //     float speed = rb.velocity.magnitude;
    //
    //     if (Mathf.Abs(velocity.y) < 0.2f)
    //     {
    //         velocity.y = (velocity.y >= 0) ? 0.3f : -0.3f;
    //         rb.velocity = velocity.normalized * speed;
    //     }
    // }
}
