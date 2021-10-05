using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private int _numberCurrentSpawner;

    private void Start()
    {
        _numberCurrentSpawner = Spawner.numberCurrentSpawner;
    }

    private void Update()
    {
        if (_numberCurrentSpawner == 0)
        {
            GetComponent<Transform>().Translate(Vector3.left * _speed * Time.deltaTime);
        }
        else if (_numberCurrentSpawner == 1)
        {
            GetComponent<Transform>().Translate(Vector3.right * _speed * Time.deltaTime);
        }
    }
}
