using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMeshAgent : MonoBehaviour
{
    private NavMeshAgent _playerAI;

    private void Awake()
    {
        _playerAI = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _playerAI.SetDestination(new Vector3(4,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
