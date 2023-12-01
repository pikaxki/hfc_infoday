using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreDisplay;
    public Player player;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("Obstacle")) && (player.health > 0))
        {
            score++;
        }
    }
 
}
