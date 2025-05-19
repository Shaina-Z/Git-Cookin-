using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
public class InputController : MonoBehaviour
{
     public InputField inputField;
    public GameObject Bun;
    public GameObject Patty;
    public GameObject Lettuce;
    public GameObject Tomato;
    public GameObject Onion;
    public GameObject PlainBurger;
    public GameObject LettuceBurger;

    public GameObject ComboBurger;

    public GameObject FullBurger;
    public GameObject Placeholder;
    public GlobalManager GlobalManager; 
     public List<GameObject> Inventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){   
         inputField.onValueChanged.AddListener(OnInputFieldValueChanged);
         GlobalManager = GameObject.FindGameObjectWithTag("GlobalManager").GetComponent<GlobalManager>();
    }

    // Update is called once per frame
    void Update()
    {
        string inputText = inputField.text;
    }
     void OnInputFieldValueChanged(string inputText)
        {
            if(inputText=="git checkout kitchen"){
            SceneManager.LoadScene("Kitchen");
        }else if(inputText=="git checkout main"){
            SceneManager.LoadScene("Main");
        }
        if(inputText=="git pull bun"){
            Instantiate(Bun,Placeholder.transform);
            Inventory.Add(Bun);
        }
        if (inputText=="git merge patty"){
            Instantiate(PlainBurger);
            DontDestroyOnLoad(GameObject.Find("PlainBurger(Clone)"));
        }
        if (inputText == "git merge lettuce")
        {
            Destroy(GameObject.Find("Plainburger(Clone)"));
            Instantiate(LettuceBurger);
        }
        if (inputText == "git merge tomato")
        {
            Destroy(GameObject.Find("LettuceBurger(Clone)"));
            Instantiate(ComboBurger);
        }
        if (inputText == "git merge onion")
        {
            Destroy(GameObject.Find("FullBurger(Clone)"));
            Instantiate(FullBurger);
        }
        if (inputText == "git commit" && GameObject.Find("PlainBurger(Clone)"))
        {
            GlobalManager.addPoint();
        }
        }

}
