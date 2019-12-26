using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClip : MonoBehaviour
{

    public AudioSource aSource;
    public AudioClip aClip;

    public void playClip()
    {
        aSource.clip = aClip;
        aSource.Play();
    }
}
