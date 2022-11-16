using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 10;
    Rigidbody2D rb2d;

    internal void Init(Vector2 direction)
    {
        transform.right = direction;
        rb2d.AddForce(transform.right * speed, ForceMode2D.Impulse);

    }
    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }    
}
