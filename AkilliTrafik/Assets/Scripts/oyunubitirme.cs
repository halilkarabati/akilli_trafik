using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunubitirme : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gayimobject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other1)
    {

        if (other1.gameObject.CompareTag("Finish"))
        {

            Debug.Log("çarptın");
            GameOver();

        }


    }

    public void GameOver()
    {
        // Oyun bittiğinde game over panelini aktifleştir

        gayimobject.SetActive(true);

    }
}
