using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    AudioSource _audio;
    // Music volume variable that will be modified
    // by dragging slider knob
    private float musicVolume = 0.10f;

    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        _audio.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
