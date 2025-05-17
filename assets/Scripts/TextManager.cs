using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TextManager : MonoBehaviour
{
    public Text customerText;
    public TimeManager TimeManager; 
    public string[] customerSayings ={"One plain burger please!","One burger with lettuce please!",
    "One burger with lettuce and tomato please!", "Give me the whole package!"};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimeManager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        StartCoroutine(WaitOneSecond());
    }

    // Update is called once per frame
    void Update()
    {
        customerText.text=customerSayings[Random.Range(0,3)];
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
