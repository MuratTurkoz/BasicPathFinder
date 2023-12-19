using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathUpdate : MonoBehaviour
{
    [SerializeField] private Material _material;
    public void GenerateColor()
    {

        foreach (Transform item in transform)
        {
            foreach (Transform t in item)
            {
                if (t.name == "Quad")
                {
                    t.GetComponent<MeshRenderer>().material = _material;
                }
            }
        }
        _material.color = UnityEngine.Random.ColorHSV();

    }


}
