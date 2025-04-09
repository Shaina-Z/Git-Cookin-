using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public GameObject Customer;
    public int maxCustomer = 1;
    public int currentCustomer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentCustomer<maxCustomer){
        GameObject newCustomer = Instantiate(Customer, transform.position, transform.rotation);
        maxCustomer++;
        }
    }
}
