using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _enemyDirection;

    private void Start()
    {
        _enemyDirection = GetComponent<Transform>();
    }

    private void Update()
    {
        _enemyDirection.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
