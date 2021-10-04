using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _enemyCount;
    [SerializeField] private float _delaySpawn;

    private Transform[] _spawnPositions;
    private int currentNumberEnemy;

    public static int number—urrentSpawner { get; private set; }

    private void Start()
    {
        _spawnPositions = new Transform[_path.childCount];
        currentNumberEnemy = 1;
        number—urrentSpawner = 0;

        for (int i = 0; i < _spawnPositions.Length; i++)
        {
            _spawnPositions[i] = _path.GetChild(i);
        }

        StartCoroutine("Spawn");
    }
    
    private IEnumerator Spawn()
    {
        Instantiate(_enemy, _spawnPositions[number—urrentSpawner].position, Quaternion.identity);
        number—urrentSpawner++;

        if (number—urrentSpawner >= _spawnPositions.Length)
        {
            number—urrentSpawner = 0;
        }

        yield return new WaitForSeconds(_delaySpawn);
        Repeat();
    }

    private void Repeat()
    {
        if (currentNumberEnemy < _enemyCount)
        {
            currentNumberEnemy++;
            StartCoroutine("Spawn");
        }
    }
}
