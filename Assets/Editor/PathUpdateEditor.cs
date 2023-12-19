using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.TerrainTools;
[CustomEditor(typeof(PathUpdate))]
public class PathUpdateEditor : Editor
{
  public override void OnInspectorGUI()
    {
        PathUpdate _pathUpdate = (PathUpdate)target;
        base.OnInspectorGUI();
        if (GUILayout.Button("Edit"))
        {
            _pathUpdate.GenerateColor();
        }
    }
}
