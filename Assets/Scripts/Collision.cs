using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    
    public GameManager gm;
    
    private void OnTriggerEnter2D(Collider2D other) {
        //print($"Entering {other.gameObject.name}");
    }

    void OnTriggerStay2D(Collider2D other) {
        print($"inside {other.gameObject.name}");
        if (other.gameObject.CompareTag("BasicEnemy")) {
            // Player is within the bounds of the enemy
            gm.TakeDamage(other.gameObject.GetComponent<BasicEnemyMovement>().getDPS() * Time.deltaTime);
        } else if (other.gameObject.CompareTag("SmartEnemy")) {
            gm.TakeDamage(other.gameObject.GetComponent<SmartEnemyMovement>().getDPS() * Time.deltaTime);
        } else if (other.gameObject.CompareTag("FastEnemy")) {
            gm.TakeDamage(other.gameObject.GetComponent<FastEnemyMovement>().getDPS() * Time.deltaTime);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        //print($"leaving {other.gameObject.name}");
    }
}
