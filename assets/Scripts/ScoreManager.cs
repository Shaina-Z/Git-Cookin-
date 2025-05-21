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
        } 
            Instance = this;
            DontDestroyOnLoad(gameObject); 
    }

    public void AddScore() {
        int points = 1;
        customerScore+=points;
    }
    // Update is called once per frame
    void Update()
    {
        Score.text="Customers: "+ customerScore.ToString();
    }
}
