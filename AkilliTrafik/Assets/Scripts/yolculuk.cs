using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yolculuk : MonoBehaviour
{
    // Start is called before the first frame update
    //public Rigidbody arabamdacia;
    public float hiz = 1f;
    private Collider characterCollider;
    private Rigidbody characterRigidbody;
    public GameObject alt;
    
    
    void Start()
    {
        //Invoke("Update", 1f);
        characterCollider = GetComponent<Collider>();
        characterRigidbody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 thrustDirection = transform.forward;
        //transform.Translate(Vector3.forward * Time.deltaTime* hiz);
        characterRigidbody.AddForce(thrustDirection * hiz, ForceMode.Impulse);
        
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

        GameObject spawnedPrefab = Instantiate(alt, transform.position, Quaternion.identity);
        Time.timeScale = 0f;

    }


}
