using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverManger : MonoBehaviour
{
    public TimeManager TimeManager; 
    public GlobalManager GlobalManager; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimeManager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        GlobalManager = GameObject.FindGameObjectWithTag("GlobalManager").GetComponent<GlobalManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
        if (TimeManager.GameTime > 100 && GlobalManager.customerScore < 5)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
