using UnityEngine;
using UnityEngine.UI;

public class btn : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Play);

        //audio buttons stuff

    }

    void Play()
    {
        AudioManager.instance.Play("btn");
    }


    public void Quit()
    {
        Application.Quit();
    }
}
