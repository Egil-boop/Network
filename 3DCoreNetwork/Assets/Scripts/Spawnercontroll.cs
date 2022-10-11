using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.Mathematics;
using Unity.Netcode;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawnercontroll : NetworkSingelton<Spawnercontroll>
{
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private int maxObjectInstanceCount = 3;

    private void Awake()
    {
        // initial pool
    }

    public void SpawnObjects()
    {
        if (!IsServer)
        {
            return;
        }

        for (int i = 0; i < maxObjectInstanceCount; i++)
        {
            GameObject go = Instantiate(objectPrefab, new Vector3(Random.Range(-3, 3), 5f, Random.Range(-3, 3)),
                quaternion.identity);
            // Pool Instantiation
        }
        
    }
}