using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterControllerRight : MonoBehaviour
{

    [SerializeField] private Player player;
    // private Vector3 _offset;
    // Start is called before the first frame update
    void Start()
    {

        // _offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance < 3.5f)
        {
            //Vector3 dirToPlayer = transform.position - player.transform.position;
            //Vector3 newPos = transform.position - dirToPlayer;
            // mob.rectTransform.position = newPos;
            transform.position += new Vector3(-2 * Time.deltaTime, 0, 0);
        }
        //  if (player.transform.position.x - transform.position.x < 2f) {

        //     transform.velocity = new Vector3(0f, 2f, 0f);
        //  }
    }


    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnTriggerExit(Collider other)
    {


    }
}
