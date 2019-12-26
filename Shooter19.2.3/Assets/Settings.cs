using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void VolumeSilder (float volume)
    {

        //changing the exposed parameter value for our main mixer in exchange for the variable being passed in.
        audioMixer.SetFloat("Volume", volume);
    }
    public void setFullscreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
