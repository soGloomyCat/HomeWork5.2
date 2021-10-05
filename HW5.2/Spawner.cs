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

    public static int numberCurrentSpawner { get; private set; }

    private void Start()
    {
        _spawnPositions = new Transform[_path.childCount];
        _currentNumberEnemy = 1;
        numberCurrentSpawner = 0;

        for (int i = 0; i < _spawnPositions.Length; i++)
        {
            _spawnPositions[i] = _path.GetChild(i);
        }

        StartCoroutine(Spawn());
    }
    
    private IEnumerator Spawn()
    {
        Instantiate(_enemy, _spawnPositions[numberCurrentSpawner].position, Quaternion.identity);
        numberCurrentSpawner++;

        if (numberCurrentSpawner >= _spawnPositions.Length)
        {
            numberCurrentSpawner = 0;
        }

        yield return new WaitForSeconds(_delaySpawn);
        Repeat();
    }

    private void Repeat()
    {
        if (_currentNumberEnemy < _enemyCount)
        {
            _currentNumberEnemy++;
            StartCoroutine(Spawn());
        }
    }
}
