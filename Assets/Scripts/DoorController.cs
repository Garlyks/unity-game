using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
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
        animator.SetTrigger("isNotTrapDoor");
        animator.ResetTrigger("CloseDoor");
    }

    void OnTriggerExit(Collider other)
    {
        animator.SetTrigger("CloseDoor");
        animator.ResetTrigger("CloseDoor");

    }
}
