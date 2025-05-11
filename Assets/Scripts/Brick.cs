using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int health = 1;
    GameManager manager;

    private void Start()
    {
        manager = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;

        if (health <= 0)
        {
            Destroy(gameObject);
            manager.AddScore();
        }
    }
}
