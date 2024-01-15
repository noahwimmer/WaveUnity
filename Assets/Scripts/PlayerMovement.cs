using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    // TODO: find a way to stop the buggy looking movement when moving directly into walls. What causes this?

    public float moveSpeed = 7.25f;
    private Vector3 dir;
    
    // Start is called before the first frame update
    void Start() {
        
    }
    
    // Update is called once per frame
    void Update() {
        
        // Input

        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        
        transform.position += (dir.normalized * moveSpeed * Time.deltaTime);
    }

}
