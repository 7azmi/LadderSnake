using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

public class RollButton : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(Roll);
    }

    [Button]
    void Roll()
    {
        int steps = Random.Range(1, 6);
        Player.WhoseTurn.Move(steps);
        print(steps);
    }
}
