using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
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
        _enemyDirection.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}
