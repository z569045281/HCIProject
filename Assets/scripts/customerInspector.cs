
using UnityEngine;
using UnityEditor;

//name of script need to customize
[CustomEditor(typeof(placement))]
public class customerInspector : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        placement pm = (placement)target;
        if(GUILayout.Button("optimize")){
            pm.JustDoit();
        }
;    }
}