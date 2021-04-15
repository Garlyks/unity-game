using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    private float _distance = 0f;
    
    private LayerMask _boxMak;

    private GameObject _box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            Vector2.right * transform.localScale.x,
            _distance, _boxMak);

        if (hit.collider != null && Input.GetKeyDown(KeyCode.S))
        {
            _box = hit.collider.gameObject;
        }
    }
}
