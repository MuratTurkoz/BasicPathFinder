using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class CreatePath : MonoBehaviour
{
    [SerializeField] private int _col;
    [SerializeField] private int _row;
    [SerializeField] private GameObject _objPrefabs;
    [SerializeField] private Transform _transform;


    public void CreateObjPath()
    {
        for (int i = 0; i < _row; i++)
        {
            for (int j = 0; j < _col; j++)
            {
             
                GameObject _obj = Instantiate(_objPrefabs, _transform);
                _obj.transform.position = new Vector3(j, 0, i);
               

            }
        }
    }

    public void RemoveObjPath()
    {
        for (int i=_transform.childCount-1; i>=0; i--)
        {
            DestroyImmediate(_transform.GetChild(i).gameObject);
        }
    }
}
