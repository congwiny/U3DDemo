using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            audioSource.Play();
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            audioSource.Pause();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            audioSource.Stop();
        }

    }
}
