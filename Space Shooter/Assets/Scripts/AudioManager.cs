using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
public AudioClip musicClipOne;

public AudioClip musicClipTwo;

public AudioSource musicSource;
    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = musicClipOne;
        musicSource.clip = musicClipTwo;
    }

    // Update is called once per frame
    void Update()
    {
          
    }
}
