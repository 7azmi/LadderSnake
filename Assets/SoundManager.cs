using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    static AudioSource asrc;
    public static AudioClip Winning, Button, Step;
    // Start is called before the first frame update
    void Start()
    {
        asrc = GetComponent<AudioSource>();
        Winning = Resources.Load("win") as AudioClip;
        Button = Resources.Load("btn") as AudioClip;
        Step = Resources.Load("step") as AudioClip;

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public static void Play(string clipName)
    {
        switch (clipName)
        {
            case "win":
                asrc.PlayOneShot(Winning);
                break;
            case "step":
                asrc.PlayOneShot(Step);
                break;
            case "btn":
                asrc.PlayOneShot(Button);
                break;

        }
    }




    public void PlayButtonSound()
    {
        asrc.PlayOneShot(Button);
    }
}
