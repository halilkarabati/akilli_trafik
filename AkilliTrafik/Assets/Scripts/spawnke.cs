using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnke : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] myPrefab;
    //public GameObject myPrefab2;
    //public GameObject myPrefab3;
    
    void Start()
    {
        int n = Random.Range(0, myPrefab.Length);
        int m = Random.Range(0, myPrefab.Length);
        int ö = Random.Range(0, myPrefab.Length);
        int q = Random.Range(0, myPrefab.Length);
        Invoke("Start", 3f);
        GameObject g = Instantiate(myPrefab[n], new Vector3(183, 0, 8), Quaternion.identity);
        GameObject ü = Instantiate(myPrefab[m], new Vector3(230, 0, 63), Quaternion.Euler(0, 270, 0));
        GameObject x = Instantiate(myPrefab[ö], new Vector3(177, 0, 112), Quaternion.Euler(0, 180, 0));
        GameObject ğ = Instantiate(myPrefab[q], new Vector3(127, 0, 56), Quaternion.Euler(0, 90, 0));

        //Instantiate(myPrefab , new Vector3(183, 0, 8), Quaternion.identity);
        //Instantiate(myPrefab2, new Vector3(230, 0, 63), Quaternion.Euler(0, 270, 0));
        //Instantiate(myPrefab3, new Vector3(177, 0, 112), Quaternion.Euler(0, 180, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
