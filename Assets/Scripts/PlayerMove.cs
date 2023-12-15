using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private List<Transform> _paths = new List<Transform>();
    [SerializeField][Range(1, 5)] private float _speed = 1f;
    private Vector3 startPos;
    private Vector3 endPos;
    private float _timePercent = 0f;


    private void Start()
    {
        StartCoroutine(nameof(FollowPath));
    }

    private IEnumerator FollowPath()
    {
        foreach (Transform path in _paths)
        {
            startPos = transform.position;
            endPos = path.position;
            _timePercent = 0f;
            while (_timePercent < 1)
            {
                _timePercent += Time.deltaTime*_speed;
                transform.position = Vector3.MoveTowards(startPos, endPos, _timePercent);

                yield return new WaitForEndOfFrame();
            }
        }
    }
}
