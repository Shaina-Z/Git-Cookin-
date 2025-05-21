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
   
    public TimeManager TimeManager;
    public ScoreManager ScoreManager;
    public int i = 1;
    AudioSource Correct_ding;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimeManager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        ScoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        StartCoroutine(WaitOneSecond());
        Correct_ding = GetComponent<AudioSource>();

       
    }

    // Update is called once per frame
    void Update()
    {
        
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
        ScoreManager.AddScore();
        Correct_ding.Play();
    }

        IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(5);
       
    }
}
