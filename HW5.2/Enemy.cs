using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private GameObject _enemy;
    private int _number—urrentSpawner;

    private void Start()
    {
        _enemy = this.gameObject;
        _number—urrentSpawner = Spawner.number—urrentSpawner;
    }

    private void Update()
    {
        if (_number—urrentSpawner == 0)
        {
            _enemy.transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        else if (_number—urrentSpawner == 1)
        {
            _enemy.transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
    }
}
