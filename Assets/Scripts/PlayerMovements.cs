using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovements : MonoBehaviour
{
    public float speed;

    private Rigidbody2D _rigidbody2D;
    private Vector2 _position;

    private void Start()
    {
        _position = Vector2.zero;
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnMovements(InputValue value)
    {
        _position = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _position * (speed * Time.fixedDeltaTime));
    }
}
