using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public int health = 3;
    private Vector2 targetPos;
    public float Yincerment;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public GameObject gameOver;
    public TextMeshProUGUI healthDisplay;

    private bool isGameOver = false;

    private void Update()
    {
        healthDisplay.text = health.ToString();

        if (isGameOver)
        {
            return; 
        }


        if (health <= 0)
        {
            GameOver();
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincerment);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincerment);
        }
    }

    private void GameOver()
    {
        isGameOver = true;
        gameOver.SetActive(true);
        Destroy(gameObject);
    }
}

