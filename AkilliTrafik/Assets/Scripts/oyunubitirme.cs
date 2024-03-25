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

            Debug.Log("çarptýn");
            GameOver();

        }


    }

    public void GameOver()
    {
        // Oyun bittiðinde game over panelini aktifleþtir

        gayimobject.SetActive(true);

    }
}
