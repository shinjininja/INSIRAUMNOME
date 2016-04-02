using UnityEngine;
using System.Collections;
using System;

public class Bla : MonoBehaviour
{
    public GameObject Colisor;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
        transform.Translate(0f, Input.GetAxis("Vertical") * Time.deltaTime, 0f);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "01_0")
        {
            Console.WriteLine("Demonio");
        }
    }
}
