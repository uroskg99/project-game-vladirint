using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static int keyCounter = 0;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            keyCounter++;
            FindObjectOfType<AudioManager>().Play("Collect");
        }
    }

}
