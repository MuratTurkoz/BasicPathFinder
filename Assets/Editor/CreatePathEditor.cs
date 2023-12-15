using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TerrainTools;
using UnityEngine;

[CustomEditor(typeof(CreatePath))]
public class CreatePathEditor :Editor
{
    public override void OnInspectorGUI()
    {
        CreatePath createPath = (CreatePath)target;
        base.OnInspectorGUI();

        if (GUILayout.Button("Create"))
        {
           
            createPath.RemoveObjPath();
            createPath.CreateObjPath();
        }

    }
}
