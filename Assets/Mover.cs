using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    Rigidbody2D rb2d;
    MyAnimator animatorControl;
    Vector3 lastMoveDir = Vector3.zero;
    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
        animatorControl = GetComponent<MyAnimator>();
    }
    private void Update()
    {
        animatorControl.UpdateAnimator(lastMoveDir, Vector3.zero, lastMoveDir!=Vector3.zero);
    }
    public void Move(Vector3 direction){
        rb2d.velocity = direction * speed;
        lastMoveDir = direction;        
    }
}
