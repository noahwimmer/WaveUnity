using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour {
    
    public float impulseForce;
    private Vector2 dir;
    private Rigidbody2D rb;

    [SerializeField]
    private float DPS;

    public float getDPS() {
        return DPS;
    }
    
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
