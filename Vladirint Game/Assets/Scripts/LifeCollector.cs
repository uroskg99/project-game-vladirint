using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCollector : MonoBehaviour
{
    //public int playerHealth = PlayerHealth.lifeCounter;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(PlayerHealth.lifeCounter == 3)
            {
                return;
            }
            else
            {
                PlayerHealth.lifeCounter++;
                FindObjectOfType<AudioManager>().Play("Heart");
                Destroy(gameObject);
            }
        }
    }
}
