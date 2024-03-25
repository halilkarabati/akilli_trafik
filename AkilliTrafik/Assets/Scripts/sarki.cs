using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sarki : MonoBehaviour
{
    //public gameObject sesKontrolButonu; // UI Button nesnesi
    public AudioSource sesKaynagi; // Ses kaynaðý
    private bool sesAcik = true; // Sesin açýk veya kapalý olduðunu tutacak deðiþken

    void Start()
    {
        // Butonun týklama olayýný dinle
        //sesKontrolButonu.onClick.AddListener(delegate { SesKontrolu(); });
        sesKaynagi.Play();
    }

    void SesKontrolu()
    {
        // Ses açýksa kapat, kapalýysa aç
        sesAcik = !sesAcik;

        if (sesAcik)
        {
            sesKaynagi.mute = false; // Ses açýk
        }
        else
        {
            sesKaynagi.mute = true; // Ses kapalý
        }
    }
}
