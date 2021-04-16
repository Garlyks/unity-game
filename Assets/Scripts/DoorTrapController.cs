using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrapController : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("OpenDoor");
    }

    void OnTriggerExit(Collider other)
    {
        animator.SetTrigger("CloseDoor");
    }
}

