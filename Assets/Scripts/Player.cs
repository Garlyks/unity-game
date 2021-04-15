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
    public bool isGrounded;
    public Vector3 jump;
    
    public float jumpForce = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, jumpForce, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _playerRigidbody.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        _horizontalInput = Input.GetAxis("Horizontal");
    }
    
    void OnCollisionStay(){
       isGrounded = true;
    }

    private void FixedUpdate()
    {
        _playerRigidbody.velocity = new Vector3(_horizontalInput * 4, _playerRigidbody.velocity.y, 0);
    }
}
