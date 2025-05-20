using UnityEngine;

public class MusicManager : MonoBehaviour
{
    AudioSource Background_music;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Background_music = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
