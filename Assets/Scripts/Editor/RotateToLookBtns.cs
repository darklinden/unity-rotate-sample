using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RotateToLook))]
public class RotateToLookBtns : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var myScript = (RotateToLook)target;
        if (GUILayout.Button("Look Transform"))
        {
            myScript.Look();
        }
    }
}
