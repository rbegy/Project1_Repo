using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (_input.actions["Fire"].WasPressedThisFrame())
        {
            Debug.Log("Fire Activated");
        }
    }

    private void FixedUpdate()
    {
        var dir = _input.actions["Move"].ReadValue<Vector2>();

        _rigidbody.velocity = dir * 5f;
    }
}
