using UnityEngine;

public class GlobalManager : MonoBehaviour
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
        customerTimer += Time.deltaTime;
         if(currentCustomer<maxCustomer){
           Instantiate(Customer,transform.position,transform.rotation);
            currentCustomer++;
        }
        if(customerTimer>despawnTime){
            customerTimer=0;
            var newCustomer = GameObject.Find("Customer(Clone)");
            Destroy(newCustomer);
            currentCustomer--;
        }
        
    }
}
