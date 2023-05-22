using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DespawnFoods : MonoBehaviour
{
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        DataScore.makananTerbuang += 1;
        DataScore.scorePlayer -= 5;
        score.text = DataScore.scorePlayer.ToString();
    }
}
