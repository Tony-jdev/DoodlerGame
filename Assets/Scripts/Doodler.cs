using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doodler : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 10f;
    [SerializeField]private Rigidbody2D _rigidbody2D;
    private float move = 0f;
    void Start()
    {
        //_rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = _rigidbody2D.velocity;
        velocity.x = move;
        _rigidbody2D.velocity = velocity;
    }
}
