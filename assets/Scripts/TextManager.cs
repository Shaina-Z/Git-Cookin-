using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TextManager : MonoBehaviour
{
    public Text customerText;
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
        customerText.text=customerSayings[Random.Range(0,1)];
        if(TimeManager.GameTime==30){
            customerText.text="This sucks! I'm outta here!";
            WaitOneSecond();
        }
    }
     IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(5);
       
    }
}
