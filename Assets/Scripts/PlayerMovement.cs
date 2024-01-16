using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float moveSpeed = 7.25f;
    private Vector3 dir;
    private Rigidbody2D rb;

    public GameManager gm;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update() {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() {
        rb.velocity = dir.normalized * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Enemy")) {
            // Player collided with 'Enemy'
            gm.TakeDamage(12f);
        }
    }
}
