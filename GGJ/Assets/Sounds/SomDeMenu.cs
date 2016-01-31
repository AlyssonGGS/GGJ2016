using UnityEngine;
using System.Collections;

public class SomDeMenu : MonoBehaviour {
    private static SomDeMenu instance = null;
    public static SomDeMenu Instance
    {
        get { return instance; }
    }
    void Start()
    {
        if (instance != null && instance != this) {
            Destroy(gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
        if (!GetComponent<AudioSource>().isPlaying)
            GetComponent<AudioSource>().Play();
    }
    void Update()
    {
        if(Application.loadedLevelName == "Jogar")
        {
            Destroy(gameObject);
        }
    }
}
