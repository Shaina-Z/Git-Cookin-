using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class GlobalManager : MonoBehaviour
{
 public Transform parentTransform;
     public GameObject Customer;

    public int maxCustomer=1;
    public int currentCustomer=0;
    public int despawnTime=30;
    public TimeManager TimeManager; 

    public string[] customerSayings ={"One burger please!","One salad please!"};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimeManager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        StartCoroutine(WaitOneSecond());
       
    }

    // Update is called once per frame
    void Update()
    {
         if(currentCustomer<maxCustomer){
           Instantiate(Customer,parentTransform);
            currentCustomer++;
        }
        if(TimeManager.GameTime>despawnTime){
            TimeManager.GameTime=0;
            var newCustomer = GameObject.Find("Customer(Clone)");
            Destroy(newCustomer);
            WaitOneSecond();
            currentCustomer--;
        }
        
    }
        IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(5);
       
    }

}
