using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SmartEnemyMovement : MonoBehaviour {

    private GameObject player;
    private Rigidbody2D rb;

    public float moveSpeed;
    private Vector3 dir;

    [SerializeField]
    private float dps = 30f;

    public float getDPS() {
        return dps;
    }
    
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player"); // TODO research if there is a better way to get the player in the scene
    }

    // Update is called once per frame
    void Update() {
        // dir is the direction from the smart enemy to the player
        dir = (player.transform.position - transform.position).normalized;
    }

    private void FixedUpdate() {
        rb.velocity = dir * moveSpeed;
    }
}
