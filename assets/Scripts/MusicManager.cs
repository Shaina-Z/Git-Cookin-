using UnityEngine;

public class MusicManager : MonoBehaviour
{
    AudioSource Background_music;
    public static MusicManager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Background_music = GetComponent<AudioSource>();
        
    }
void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // Destroy duplicate instances
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); // This object will persist across scenes
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
