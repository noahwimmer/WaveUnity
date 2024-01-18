using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour {
    
    public float impulseForce = 3f;
    private Vector2 dir;
    private Rigidbody2D rb;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        
        // Set the enemy's initial movement direction to a random direction
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        rb.AddForce(randomDirection * impulseForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
