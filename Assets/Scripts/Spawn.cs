using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] float _spawnTime;


    private SpawnPoint[] _points;
    private float _currentTime=0;
    private int _currentSpawnPoint=0;

    private void Awake()
    {
        _points = gameObject.GetComponentsInChildren<SpawnPoint>();
    }

    void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime >= _spawnTime)
        {
            _points[_currentSpawnPoint].Spawn();
            _currentTime = 0;
            _currentSpawnPoint++;
        }

        if (_currentSpawnPoint > _points.Length-1)
        {
            _currentSpawnPoint = 0;
        }

    }
}
