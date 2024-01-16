using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    private int score = 1;
    private int round = 1;
    private float delta = 0;

    private float maxHealth = 100f;
    private float playerHealth;

    public Image healthUI;
    
    public Text roundText;
    public Text scoreText;

    public void TakeDamage(float damage) {
        playerHealth -= damage;
    }
    
    void UpdateHUD() {
        roundText.text = "Round: " + round;
        scoreText.text = "Score: " + score;
        healthUI.fillAmount = playerHealth / maxHealth;
    }
    
    // Start is called before the first frame update
    void Start() {
        playerHealth = maxHealth;
    }

    // Update is called once per frame
    void Update() {
        delta += Time.deltaTime;
        if (delta > .25f) {
            score++;
            delta = 0f;
        }

        if (score % 90 == 0) {
            round++;
            score++; // This line is to prevent the score from increasing multiple times if the time between frames is < .25f ^^
        }
        
        UpdateHUD();
    }
}
