using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAnimator : MonoBehaviour
{
    [SerializeField] GameObject mainPartsSprite;
    
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void UpdateAnimator(Vector3 playerDirection, Vector3 mousePosition, bool isMoving)
    {
        
        
        animator.SetBool("isMoving", isMoving);


        animator.SetFloat("direction", CalculateDirectionForAnimator(playerDirection));
        //flip animations
        animator.SetFloat("forward",playerDirection.x < 0?-1:1);
    }

    private float CalculateDirectionForAnimator(Vector3 playerDirection)
    {
        if (Mathf.Abs(playerDirection.x) > 0.5f)
        {
            return 0;
        }
        return 1;
    }
}
