using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KindOfFoods : MonoBehaviour
{
    public string nameTag;
    public Image meme;
    public Text pointPemain;

    // Start is called before the first frame update
    void Start()
    {
        meme.enabled = false;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            DataScore.scorePlayer += 15;
            DataScore.makananBenar += 1;
            pointPemain.text = DataScore.scorePlayer.ToString();
            Destroy(collision.gameObject);
            meme.enabled = true;
            StartCoroutine(GetImageClose());
        }
        else
        {
            DataScore.scorePlayer -= 10;
            DataScore.makananSalah += 1;
            pointPemain.text = DataScore.scorePlayer.ToString();
            Destroy (collision.gameObject);
        }
    }

    IEnumerator GetImageClose()
    {
        yield return new WaitForSeconds(2);
        meme.enabled = false;
    }
}
