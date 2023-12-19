using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private List<GameObject> _wayPoints = new List<GameObject>();
    [SerializeField][Range(0, 3)] private float _speed = 1;
    private Vector3 _currentPos;
    private Vector3 _nextPos;
    private float _timeScale = 0;

    private void Start()
    {
        StartCoroutine(nameof(PathFinder));
    }

    private IEnumerator PathFinder()
    {
        foreach (GameObject item in _wayPoints)
        {
            _timeScale = 0;
            _currentPos = transform.position;
            _nextPos = item.transform.position;

            while (_timeScale <= 1)
            {
                _timeScale += Time.deltaTime * _speed;
                transform.position = Vector3.MoveTowards(_currentPos, _nextPos, _timeScale);
                yield return new WaitForEndOfFrame();
            }

        }
    }
}
