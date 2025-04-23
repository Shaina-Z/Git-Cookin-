using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class InputController : MonoBehaviour
{
     public InputField inputField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){   
        
    }

    // Update is called once per frame
    void Update()
    {
        string inputText = inputField.text;
    }
     void ChangeScene(string inputText)
        {
            if(inputText=="git checkout kitchen"){
            SceneManager.LoadScene("Kitchen");
        }else if(inputText=="git checkout main"){
            SceneManager.LoadScene("Main");
        }
        }
}
