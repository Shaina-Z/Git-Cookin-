using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class GlobalManager : MonoBehaviour
{
 public Transform parentTransform;
     public GameObject Customer;

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
        if(TimeManager.GameTime>100&&customerScore<5){
            SceneManager.LoadScene("GameOver");
        }
    }
    [ContextMenu("Increase Score")]
    public void addPoint(){
        customerScore++;
    }
        IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(5);
       
    }
}
