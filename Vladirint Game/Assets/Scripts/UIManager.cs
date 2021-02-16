using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static int keyCounterP;
    private static UIManager _instance;
    public GameObject gameOverCanvas;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Game Manager not found");
            }
            return _instance;
        }
    }

    public Text keysText;
    public Text livesText;

    private void Awake()
    {
        _instance = this;
    }

    private void Update()
    {
        DisplayKeys();
        DisplayLives();
    }

    void DisplayKeys()
    {
        keyCounterP = Key.keyCounter;
        keysText.text = "Keys:" + keyCounterP.ToString() + "/3";
    }

    void DisplayLives()
    {
        livesText.text = "Lives:" + PlayerHealth.lifeCounter.ToString() + "/3";
    }
  
}