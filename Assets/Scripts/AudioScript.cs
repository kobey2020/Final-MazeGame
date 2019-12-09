using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip WalkingClip;

    public AudioSource WalkingSource;

    // Start is called before the first frame update
    void Start()
    {
        WalkingSource.clip = WalkingClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            WalkingSource.Play();
        }
    }
}
