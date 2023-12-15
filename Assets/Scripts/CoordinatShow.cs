using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

[ExecuteAlways]
public class CoordinatShow : MonoBehaviour
{
    private TextMeshPro _textMeshPro;
    private Vector2 _coordinate;

    private void Awake()
    {
        _textMeshPro = GetComponentInChildren<TextMeshPro>();
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinate();
        }
    }

    private void DisplayCoordinate()
    {
        _coordinate.x = Mathf.RoundToInt(transform.position.x/EditorSnapSettings.gridSize.x);
        _coordinate.y = Mathf.RoundToInt(transform.position.z/EditorSnapSettings.gridSize.z);
        _textMeshPro.text = $"({_coordinate.x},{_coordinate.y})";
        transform.name = _textMeshPro.text;
    }


}
