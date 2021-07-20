using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LogTransform))]
public class LogTransformBtns : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var myScript = (LogTransform)target;
        if (GUILayout.Button("Log Transform"))
        {
            myScript.Log();
        }
    }
}
