using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private int _number—urrentSpawner;

    private void Start()
    {
        _number—urrentSpawner = Spawner.numberCurrentSpawner;
    }

    private void Update()
    {
        if (_number—urrentSpawner == 0)
        {
            GetComponent<Transform>().Translate(Vector3.left * _speed * Time.deltaTime);
        }
        else if (_number—urrentSpawner == 1)
        {
            GetComponent<Transform>().Translate(Vector3.right * _speed * Time.deltaTime);
        }
    }
}
