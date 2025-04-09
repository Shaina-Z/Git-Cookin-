using UnityEngine;
using System.Collections;

public class CustomerManager : MonoBehaviour
{
    public GameObject Customer;
    public int maxCustomer=1;
    public int currentCustomer=0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       if(currentCustomer<maxCustomer){
            Instantiate(Customer,transform.position,transform.rotation);
            currentCustomer++;
        } 
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
