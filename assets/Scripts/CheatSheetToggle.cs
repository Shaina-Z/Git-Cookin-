using UnityEngine;
using UnityEngine.UI;

public class CheatSheetToggle : MonoBehaviour
{
    public GameObject CheatSheetPanel;  // The whole panel with image + exit button
    public GameObject CloseButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CheatSheetPanel.SetActive(false);
        CloseButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCheatSheet()
    {
        CheatSheetPanel.SetActive(true);
        CloseButton.SetActive(true);
    }

    public void HideCheatSheet()
    {
        CheatSheetPanel.SetActive(false);
        CloseButton.SetActive(false);
    }
}