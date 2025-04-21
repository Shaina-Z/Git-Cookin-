using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static float GameTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        GameTime+= Time.deltaTime;
    }
}
