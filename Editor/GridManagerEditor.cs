using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridManager))]
public class GridManagerEditor : Editor
{


    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GridManager GM = (GridManager)target;
        if (GUILayout.Button("Activate"))
        {
            GM.Activate();
        }

    }
    
}
