using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class GlobalManager : MonoBehaviour
{
 public Transform parentTransform;
     public GameObject Customer;
public GameObject StartScreen;
    public int maxCustomer=1;
    public int currentCustomer=0;
    public int despawnTime=30;
    public int customerScore=0;
    public Text Score;
    public TimeManager TimeManager; 

    public string[] customerSayings ={"One burger please!","One salad please!"};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0;
        TimeManager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        StartCoroutine(WaitOneSecond());
       
    }

    // Update is called once per frame
    void Update()
    {
        Score.text="Customers: "+ customerScore.ToString()+"/5";
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
    [ContextMenu("Increase Score")]
    public void addPoint(){
        customerScore++;
    }
    public void startGame(){
        Time.timeScale = 1;
        StartScreen.SetActive(false);
    }
        IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(5);
       
    }

}
