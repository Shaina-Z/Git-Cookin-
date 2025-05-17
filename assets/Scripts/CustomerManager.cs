using UnityEngine;
using System.Collections;

public class CustomerManager : MonoBehaviour
{
    public GameObject Customer;
    public int maxCustomer=1;
    public int currentCustomer=0;
    public int despawnTime=30;
    public float customerTimer=0;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(currentCustomer<maxCustomer){
            Instantiate(Customer,transform.position,transform.rotation);
            currentCustomer++;
        } 
        customerTimer += Time.deltaTime;
        if(customerTimer>despawnTime){
            customerTimer=0;
            Destroy(Customer);
            currentCustomer--;
        }
    }
}
