using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;

    private void Start()
    {
        if (transform.position.x < new Vector3(0, 0, 0).x)
            _direction = Vector3.right;
        else if (transform.position.x > new Vector3(0, 0, 0).x)
            _direction = Vector3.left;
    }

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
