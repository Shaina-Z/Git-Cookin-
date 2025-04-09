using UnityEngine;
using System.Collections;

public class CustomerManager : MonoBehaviour
{
    public GameObject Customer;
    public float spawnDelay = 5f;      

    private bool customerSpawned = false;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
         
        if (!customerSpawned)
        {
            
            StartCoroutine(SpawnCustomer());
        }
    }
    private IEnumerator SpawnCustomer()
    {
        yield return new WaitForSeconds(spawnDelay);

        
        Instantiate(Customer, transform.position, Quaternion.identity);

        
        customerSpawned = true;
    }
}
