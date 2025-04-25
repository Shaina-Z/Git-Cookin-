using UnityEngine;
using UnityEngine.UI;
public class TextManager : MonoBehaviour
{
    public Text customerText;
    public string[] customerSayings ={"One burger please!","One salad please!"};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        customerText.text=customerSayings[Random.Range(0,1)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
