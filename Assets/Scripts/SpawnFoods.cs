using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class SpawnFoods : MonoBehaviour
{
    public float jeda = 1.0f;
    float timer;
    public GameObject[] makanan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > jeda)
        {
            int random = Random.Range(0, makanan.Length);
            Instantiate(makanan[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
