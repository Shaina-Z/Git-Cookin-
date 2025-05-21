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
   public Text Score;
    public TimeManager TimeManager;
    public static int customerScore = 0; 
    public int i = 1;
    AudioSource Correct_ding;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimeManager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        StartCoroutine(WaitOneSecond());
        Correct_ding = GetComponent<AudioSource>();

       
    }

    // Update is called once per frame
    void Update()
    {
        Score.text="Customers: "+ customerScore.ToString();
         if(currentCustomer<maxCustomer){
           Instantiate(Customer,parentTransform);
            currentCustomer++;
        }
        if(TimeManager.GameTime>despawnTime*i){
            var newCustomer = GameObject.Find("Customer(Clone)");
            Destroy(newCustomer);
            WaitOneSecond();
            currentCustomer--;
            i=i+1;
        }
    }
    [ContextMenu("Increase Score")]
    public void addPoint()
    {
        customerScore++;
        Correct_ding.Play();
        
    }

        IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(5);
       
    }
}
