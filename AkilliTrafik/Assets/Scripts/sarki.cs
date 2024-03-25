using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sarki : MonoBehaviour
{
    //public gameObject sesKontrolButonu; // UI Button nesnesi
    public AudioSource sesKaynagi; // Ses kayna��
    private bool sesAcik = true; // Sesin a��k veya kapal� oldu�unu tutacak de�i�ken

    void Start()
    {
        // Butonun t�klama olay�n� dinle
        //sesKontrolButonu.onClick.AddListener(delegate { SesKontrolu(); });
        sesKaynagi.Play();
    }

    void SesKontrolu()
    {
        // Ses a��ksa kapat, kapal�ysa a�
        sesAcik = !sesAcik;

        if (sesAcik)
        {
            sesKaynagi.mute = false; // Ses a��k
        }
        else
        {
            sesKaynagi.mute = true; // Ses kapal�
        }
    }
}
