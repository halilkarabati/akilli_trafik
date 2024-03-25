using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class space : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider AAAA; // Duvarın collider'ı
    private bool isOpen = true; // Duvarın açık mı kapalı mı olduğunu belirten bayrak

    public Collider bb; // Arkadaki araçların collider'ı
    private bool acikmi = false; // Arkadaki araçların etkin olup olmadığını belirten bayrak

    private bool duvarKapandi = false; // Duvarın kapanıp kapanmadığını belirten bayrak

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!duvarKapandi)
            {
                duvarKapandi = true;
                Invoke("KapaliDuvarinArdindakiAraclariilerlet", 2f); // Duvar kapatıldıktan sonra 2 saniye sonra araçların ilerlemesi için fonksiyonu çağır
                AAAA.enabled = false; // Duvarın collider'ını kapat
                ToggleCollider(); // Arkadaki araçların collider'ını değiştir
            }
        }
    }

    void ToggleCollider()
    {
        if (AAAA != null && bb != null)
        {
            isOpen = !isOpen;
            acikmi = !acikmi;
            AAAA.enabled = isOpen; // Duvarın collider'ını açık veya kapalı yap
            bb.enabled = acikmi; // Arkadaki araçların collider'ını açık veya kapalı yap
        }
        else
        {
            Debug.LogWarning("Hedef Collider atanmamış!");
        }
    }

    void KapaliDuvarinArdindakiAraclariilerlet()
    {
        // Burada araçların ilerlemesi için gerekli işlemleri yapabilirsiniz
        // Örnek olarak araçların hızını artırabilir veya araçların durduğu konuma göre yeni bir konuma hareket ettirebilirsiniz
    }
    
    
}
