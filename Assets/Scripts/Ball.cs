using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float initialSpeed = 5f;
    private Rigidbody2D rb;
    private bool launched = false;

    public AudioSource hitSound;
    public AudioSource popSound;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick")) popSound.Play();
        else hitSound.Play();
    }
}
