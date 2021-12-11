using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Test : MonoBehaviour
{
    //public GameObject prefab;



    private void Start()
    {
        print($"Width: {Screen.width} Height: {Screen.height}");
        //print(Screen.height);
        //print(Screen.width);
    }

    [Button]
    public void IamCrazy(int value)
    {
        GetComponent<SpriteRenderer>().material.SetFloat("_OutlineAlpha", value); //magical code, thanks to that package

        print("pos:" + transform.position);
        print("local pos:" + transform.localPosition);
        print("pos point:" + transform.TransformPoint(transform.position));
        print("local pos point:" + transform.TransformPoint(transform.localPosition));

    }
}
