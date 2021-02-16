using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Door : MonoBehaviour
{
    public SpriteRenderer sr;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Key.keyCounter = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<AudioManager>().Play("Gate");
    }
    private void Update()
    {
        if (Key.keyCounter == 3)
        {
            sr.color = Color.green;
            anim.SetBool("shouldOpenDoor", true);
        }
    }
}
