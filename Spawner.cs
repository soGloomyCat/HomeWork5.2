using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private int _enemyCount;
    [SerializeField] private float _delaySpawn;

    private Transform[] _spawnPositions;
    private int _currentNumberEnemy;
    private int _numberCurrentSpawner;
    private int _compensationValue;

    private void Start()
    {
        _spawnPositions = new Transform[_path.childCount];
        _currentNumberEnemy = 0;
        _numberCurrentSpawner = 0;
        _compensationValue = 2;

        for (int i = 0; i < _spawnPositions.Length; i++)
        {
            _spawnPositions[i] = _path.GetChild(i);
        }

        StartCoroutine(Spawn());
    }
    
    private IEnumerator Spawn()
    {
        WaitForSeconds waiter = new WaitForSeconds(_delaySpawn);

        while (_currentNumberEnemy * _compensationValue != _enemyCount)
        {
            for (int i = 0; i < _spawnPositions.Length; i++)
            {
                if (_spawnPositions[i].position.x < new Vector3(0, 0, 0).x)
                {
                    Instantiate(_enemy, _spawnPositions[i].position, Quaternion.identity);
                    yield return waiter;
                }
                else if (_spawnPositions[i].position.x > new Vector3(0, 0, 0).x)
                {
                    Instantiate(_enemy, _spawnPositions[i].position, Quaternion.Euler(0, 180, 0));
                    yield return waiter;
                }
            }
            
            _numberCurrentSpawner++;
            _currentNumberEnemy++;

            if (_numberCurrentSpawner >= _spawnPositions.Length)
            {
                _numberCurrentSpawner = 0;
            }
        }
    }
}
