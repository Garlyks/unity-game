using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    private Rigidbody _playerRigidbody;
    public bool isGrounded;
    private readonly float _jumpForce = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump(_jumpForce);
            isGrounded = false;
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            _playerRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * 4, _playerRigidbody.velocity.y, 0);
        }
    }

    public void Jump(float jumpForce)
    {
        _playerRigidbody.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    private void OnCollisionExit()
    {
        isGrounded = false;
    }
}
