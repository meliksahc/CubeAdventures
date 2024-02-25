using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanCollider : MonoBehaviour
{
    Animator animator;
    

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Karakter"))
        {
            animator.SetBool("Degmek", true);
            Destroy(gameObject, 0.6f);
        }
    }
}
