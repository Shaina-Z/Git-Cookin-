using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public GlobalManager GlobalManager;
    public Text Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GlobalManager = GameObject.FindGameObjectWithTag("GlobalManager").GetComponent<GlobalManager>();
    }
   
    // Update is called once per frame
    void Update()
    {
        Score.text="Customers: "+ GlobalManager.customerScore.ToString();
    }
}
