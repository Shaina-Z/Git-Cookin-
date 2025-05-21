using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverManger : MonoBehaviour
{
    public TimeManager TimeManager; 
    public ScoreManager ScoreManager; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimeManager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        ScoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
        if (TimeManager.GameTime > 100 && ScoreManager.customerScore < 5)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
