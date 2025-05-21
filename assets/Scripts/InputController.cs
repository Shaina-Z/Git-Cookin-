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
    public TextManager TextManager;
    public List<GameObject> Inventory;

    private string currentInputText = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputField.onValueChanged.AddListener(OnInputFieldValueChanged);
        GlobalManager = GameObject.FindGameObjectWithTag("GlobalManager").GetComponent<GlobalManager>();
        TextManager = GameObject.FindGameObjectWithTag("TextManager").GetComponent<TextManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            if (currentInputText.Contains("git checkout kitchen"))
                SceneManager.LoadScene("Kitchen");
            else if (currentInputText.Contains("git checkout main"))
                SceneManager.LoadScene("Main");
            //else if (currentInputText.Contains("git checkout fridge"))
                //SceneManager.LoadScene("Fridge");
            //else if (currentInputText.Contains("git checkout pantry"))
                //SceneManager.LoadScene("Pantry");

            HandleGitCommands(currentInputText);

            inputField.text = "";
        }
    }

    void OnInputFieldValueChanged(string inputText)
    {
        currentInputText = inputText;
    }

    void HandleGitCommands(string inputText)
    {
        if (inputText == "git pull bun")
        {
            Instantiate(Bun, Placeholder.transform);
            Inventory.Add(Bun);
        }
        else if (inputText == "git merge patty")
        {
            Instantiate(PlainBurger);
            DontDestroyOnLoad(GameObject.Find("PlainBurger(Clone)"));
        }
        else if (inputText == "git merge lettuce")
        {
            DestroyImmediate(GameObject.Find("PlainBurger(Clone)"));
            Instantiate(LettuceBurger);
            DontDestroyOnLoad(GameObject.Find("LettuceBurger(Clone)"));
        }
        else if (inputText == "git merge tomato")
        {
            DestroyImmediate(GameObject.Find("LettuceBurger(Clone)"));
            Instantiate(ComboBurger);
            DontDestroyOnLoad(GameObject.Find("ComboBurger(Clone)"));
        }
        else if (inputText == "git merge onion")
        {
            DestroyImmediate(GameObject.Find("ComboBurger(Clone)"));
            Instantiate(FullBurger);
            DontDestroyOnLoad(GameObject.Find("FullBurger(Clone)"));
        }
        else if (inputText == "git commit")
        {
            string customerRequest = TextManager.customerText.text;

            if (customerRequest == TextManager.customerSayings[0] && GameObject.Find("PlainBurger(Clone)"))
                GlobalManager.addPoint();
            else if (customerRequest == TextManager.customerSayings[1] && GameObject.Find("LettuceBurger(Clone)"))
                GlobalManager.addPoint();
            else if (customerRequest == TextManager.customerSayings[2] && GameObject.Find("ComboBurger(Clone)"))
                GlobalManager.addPoint();
            else if (customerRequest == TextManager.customerSayings[3] && GameObject.Find("FullBurger(Clone)"))
                GlobalManager.addPoint();
            else
                GlobalManager.removePoint();
        }
    }
}
