using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sayac1 : MonoBehaviour
{
    private float counter = 0f;
    public TMP_Text counterText; // TMP metin nesnesi
    public TMP_Text highscore;
    private float highsikor;

    void Start()
    {
        highsikor = PlayerPrefs.GetFloat("highscore", 0f);
        UpdateHighScoreText();
    }
    
    void Update()
    {
        counter += Time.deltaTime;
        counterText.text = counter.ToString("F2"); // Counter'ý TMP metin nesnesine aktar
    }

    void UpdateHighScoreText()
    {
        highscore.text = "En Yüksek Skor " + highsikor.ToString("F2");
    }
}
