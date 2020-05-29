using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public AudioClip walk, jump, dash, slid, land;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlaySound (string clip) {
        switch (clip) {
        case "walk":
            //source.PlayOneShot(walk);
            print("walking");
            break;
        case "jump":
            //source.PlayOneShot(jump);
            print("jump");
            break;
        case "dash":
            //source.PlayOneShot(dash);
            print("dash");
            break;
        case "slid":
            //source.PlayOneShot(slid);
            print("slide");
            break;
        case "land":
            //source.PlayOneShot(land);
            print("Landed");
            break;

        }
    }
}
