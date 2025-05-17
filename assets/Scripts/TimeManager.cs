using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public  float GameTime;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   DontDestroyOnLoad(gameObject);
        GameTime+= Time.deltaTime;
    }
}
