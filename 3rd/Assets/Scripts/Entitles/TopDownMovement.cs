using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movemnetDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movemnetDirection);
    }

    private void Move(Vector2 direction)
    {
        _movemnetDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 10;

        _rigidbody.velocity = direction;
    }
}
