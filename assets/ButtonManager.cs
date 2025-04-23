using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public InputController InputController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InputController = GameObject.FindGameObjectWithTag("InputController").GetComponent<InputController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
