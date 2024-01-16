using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour {
    
    public float impulseForce = 3f;
    private Vector2 dir;

    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        
        // Set the enemy's initial movement direction to a random direction
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        rb.AddForce(randomDirection * impulseForce, ForceMode2D.Impulse);
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
        print("on collision enter");
        // Invert the velocity component when colliding with a wall
        Vector2 normal = collision.GetContact(0).normal;
        rb.AddForce(normal * impulseForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
    {
        
    }
}
