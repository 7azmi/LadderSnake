using UnityEngine;
using UnityEngine.UI;

public class btn : MonoBehaviour
{
    AudioManager am;
    Button button;

    void Start()
    {
        am = FindObjectOfType<AudioManager>();
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Play);
    }

    void Play()
    {
        am.Play("btn");
    }

    public void SFX_Toggle()
    {
        if (am.gameObject.activeInHierarchy)
        {
            am.gameObject.SetActive(false);
            button.image.color = Color.gray;

        }
        else
        {
            am.gameObject.SetActive(true);
            button.image.color = Color.white;
        }
    }
    public void Music_Toggle()
    {
        AudioSource music = FindObjectOfType<Camera>().GetComponent<AudioSource>();
        if (music.enabled)
        {

            music.enabled = false;
            button.image.color = Color.gray;

        }
        else
        {
            music.enabled = true;
            button.image.color = Color.white;
        }


    
    }
    public void Quit()
    {
        Application.Quit();
    }
}
