using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    // TODO: find a way to stop the buggy looking movement when moving directly into walls. What causes this?

    public float moveSpeed = 5f;
    private Vector3 movement;
    
    // Start is called before the first frame update
    void Start() {
        
    }
    
    // Update is called once per frame
    void Update() {
        
        // Input

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        transform.position += (movement.normalized * moveSpeed * Time.deltaTime);
    }

}
