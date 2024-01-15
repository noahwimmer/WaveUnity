using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour {
    
    public float moveSpeed = 3f;
    private Vector2 dir;

    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();

        Vector2 screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
        
        // Set the enemy's initial movement direction to a random direction
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        rb.velocity = randomDirection * moveSpeed;
        
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
        // Invert the velocity component when colliding with a wall
        Vector2 normal = collision.GetContact(0).normal;
        rb.velocity = new Vector2(
            normal.x != 0 ? -rb.velocity.x : rb.velocity.x,
            normal.y != 0 ? -rb.velocity.y : rb.velocity.y
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
