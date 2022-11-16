using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    Rigidbody2D rb2d;
    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }
    public void Move(Vector3 direction){
        rb2d.velocity = direction * speed;
    }
}
