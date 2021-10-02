using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovements : MonoBehaviour
{
    public float speed;

    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    private Vector2 _position;

    private void Start()
    {
        _position = Vector2.zero;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    public void OnMovements(InputValue value)
    {
        _position = value.Get<Vector2>();
        //Set sprite animation based on speed and a deadzone when moving too slowly left or right.
        _animator.SetInteger("Direction", _position.x > 0.1f ? 1 : _position.x < -0.1f ? -1 : 0);
        //Debug.Log("Direction: " + (_position.x > 0.1f ? 1 : _position.x < -0.1f ? -1 : 0));
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _position * (speed * Time.fixedDeltaTime));
    }
}
