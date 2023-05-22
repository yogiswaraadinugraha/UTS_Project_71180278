using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverNilai : MonoBehaviour
{
    public Text jumlahBenar;
    public Text jumlahSalah;
    public Text jumlahTerbuang;
    public Text jumlahScore;

    // Start is called before the first frame update
    void Start()
    {
        jumlahBenar.text = DataScore.makananBenar.ToString();
        jumlahSalah.text = DataScore.makananSalah.ToString();
        jumlahTerbuang.text = DataScore.makananTerbuang.ToString();
        jumlahScore.text = DataScore.scorePlayer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
