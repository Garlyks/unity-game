using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinController : MonoBehaviour
{

    public string textValue;
    public Text textElement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        textElement.text = "You Win!!";
    }

    void OnTriggerExit(Collider other)
    {
        textElement.text = "";
    }
}