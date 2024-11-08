using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButtonController : MonoBehaviour
{
    private menuMusic musicScript;  // Reference to the menuMusic script

    [SerializeField] KeyCode toggleMusic = KeyCode.M;

    void Start()
    {
        musicScript = GetComponent<menuMusic>();

        if (musicScript == null)
        {
            Debug.LogError("No menuMusic script found on this GameObject!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleMusic))
        {
            ToggleMusic();
        }
    }

    void ToggleMusic()
    {
        if (musicScript != null)
        {
            if (musicScript.GetComponent<AudioSource>().isPlaying)
            {
                musicScript.StopMusic();
            }
            else
            {
                musicScript.PlayMusic();
            }
        }
    }
}
