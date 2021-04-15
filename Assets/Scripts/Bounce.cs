using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] private Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 jumpForce = collision.impulse * 3;
        if (jumpForce.y > 6f)
        {
            jumpForce.y = 6f;
        }
        player.Jump(jumpForce);
    }
}
