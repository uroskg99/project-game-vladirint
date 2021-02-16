using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private UIManager uiManager;
    public static int lifeCounter = 3;
    private Vector2 startPosition;


    private void Awake()
    {
        startPosition = transform.position;
        uiManager = FindObjectOfType<UIManager>().GetComponent<UIManager>();
    }

    private void Update()
    {
        if(lifeCounter == 0)
        {
            GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            FindObjectOfType<AudioManager>().Play("Dead");
            lifeCounter--;
            transform.position = startPosition;
        }
    }

    void GameOver()
    {
        uiManager.gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
