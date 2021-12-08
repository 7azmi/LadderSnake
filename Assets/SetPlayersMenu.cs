using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class SetPlayersMenu : MonoBehaviour
{
    [SerializeField] Button playButton;

    [SerializeField] Button increaseButton;
    [SerializeField] Button decreaseButton;

    [SerializeField] TMP_InputField inputField;

    int players;
    public static Action<int> SetPlayers { get; set; }
    private void Awake()
    {
        ChangeInputFieldValue(players = 2);
    }

    void ChangeInputFieldValue(int newValue)
    {
        //players = newValue;
        inputField.text = players.ToString();
    }

    public void Increase() { ChangeInputFieldValue(players++); }
    public void Decrease() { ChangeInputFieldValue(players--); }


    public void OnChangeValue()
    {
        //show or hide - button
        if (players <= 1) decreaseButton.gameObject.SetActive(false);
        else decreaseButton.gameObject.SetActive(true);
    }

    public void OnEndEdit()
    {
        try
        {
            ChangeInputFieldValue(players = Mathf.Abs(int.Parse(inputField.text)));
        }
        catch (Exception)
        {
            //if it is a dumb minus
            ChangeInputFieldValue(players = 0);
        }



    }

    public void Play()
    {
        if (players > 0) SetPlayers?.Invoke(players);
        else print("r u dumb?");//tell the player to stop missing
    }

    

}
