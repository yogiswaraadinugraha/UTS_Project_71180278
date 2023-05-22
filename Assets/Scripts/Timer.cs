using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;

public class Timer : MonoBehaviour
{
    private float timerNow = 10.0f;
    private int timerCount;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerNow > 0)
        {
            timerNow -= Time.deltaTime;
            timerCount = (int)timerNow;
            timerText.text = timerCount.ToString();
            
            if (timerNow < 11)
            {
                timerText.color = Color.red;
                if (timerCount == 0)
                {
                    SceneManager.LoadScene("GameOver");
                    timerNow = 40.0f;
                    Debug.Log("TESSSS");
                }
            }
            
        }
        
    }
}
