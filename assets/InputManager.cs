using UnityEngine;
using UnityEngine.SceneManagement;

public GameObject Shell;
public class InputManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var input = Shell.GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
       if( input=="kitchen"){
            SceneManager.LoadScene("Kitchen");
       }
        
    }
}
