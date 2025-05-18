using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputController : MonoBehaviour
{
    public InputField inputField;
    private string currentInputText = "";

    void Start()
    {
        inputField.onValueChanged.AddListener(OnInputFieldValueChanged);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (currentInputText.Contains("git checkout kitchen"))
            {
                SceneManager.LoadScene("Kitchen");
                Debug.Log("Skibidi Rizz");
            }
            else if (currentInputText.Contains("git checkout main"))
            {
                SceneManager.LoadScene("Main");
                Debug.Log("Tralalero Tralala");
            }
            else if (currentInputText.Contains("git checkout fridge"))
            {
                SceneManager.LoadScene("Fridge");
                Debug.Log("Ballerina Cappucina");
            }
            else if (currentInputText.Contains("git checkout pantry"))
            {
                SceneManager.LoadScene("Pantry");
                Debug.Log("Brr Brr Patapim");
            }
        }
    }

    void OnInputFieldValueChanged(string inputText)
    {
        currentInputText = inputText;
    }
}
