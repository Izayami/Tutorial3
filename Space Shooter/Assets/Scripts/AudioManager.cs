using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   public AudioClip musicClipOne;
   public AudioClip musicClipTwo;
    // Start is called before the first frame update
    void Start()
    {
        musicClipOne = GetComponent<AudioClip>();
        musicClipTwo = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
