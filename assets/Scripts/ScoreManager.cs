using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
     public static ScoreManager Instance; 
    public int customerScore = 0; 
    public Text Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(this.gameObject);
        } else {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
    }

    public void AddScore() {
        customerScore++;
    }
    // Update is called once per frame
    void Update()
    {
        Score.text="Customers: "+ customerScore.ToString();
    }
}
