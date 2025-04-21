using UnityEngine;

public class GlobalManager : MonoBehaviour
{
     public GameObject Customer;
    public int maxCustomer=1;
    public int currentCustomer=0;
    public int despawnTime=30;
    public TimeManager TimeManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimeManager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
         if(currentCustomer<maxCustomer){
           Instantiate(Customer,transform.position,transform.rotation);
            currentCustomer++;
        }
        if(TimeManager.GameTime>despawnTime){
            TimeManager.GameTime=0;
            var newCustomer = GameObject.Find("Customer(Clone)");
            Destroy(newCustomer);
            currentCustomer--;
        }
        
    }
}
