using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class InputController : MonoBehaviour
{
     public InputField inputField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){   
        inputField.onValueChanged.AddListener(OnInputFieldValueChanged);
    }

    // Update is called once per frame
    void Update()
    {
        string inputText = inputField.text;
    }
     void OnInputFieldValueChanged(string inputText)
        {
            if(inputText=="git checkout kitchen")
        {
            SceneManager.LoadScene("Kitchen");
        }else if(inputText=="git checkout main")
        {
            SceneManager.LoadScene("Main");
        }else if (inputText=="git checkout fridge")
        {
            SceneManager.LoadScene("Fridge");
        }else if(inputText == "git checkout pantry")
        {
            SceneManager.LoadScene("Pantry");
        }
        }
}
