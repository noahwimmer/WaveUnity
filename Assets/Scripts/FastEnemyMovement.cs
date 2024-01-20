using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastEnemyMovement : MonoBehaviour {

    public float impulseForce;
    private Vector2 dir;
    private Rigidbody2D rb;

    [SerializeField] private float dps;

    public float getDPS() {
        return dps;
    }
    
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();

        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        rb.AddForce(randomDirection * impulseForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
