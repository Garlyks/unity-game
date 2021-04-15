using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _groundCheckTransform;
    private bool _jumpKeyWasPressed;
    private float _horizontalInput;
    private Rigidbody _playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _jumpKeyWasPressed = Input.GetKeyDown(KeyCode.Space);
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        _playerRigidbody.velocity = new Vector3(_horizontalInput * 4, _playerRigidbody.velocity.y, 0);

        if (_jumpKeyWasPressed)
        {
            _playerRigidbody.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            _jumpKeyWasPressed = false;
        }
    }
}
