using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;

    bool showMessage = true;

    [SerializeField]
    float timeToWait = 5f;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait && showMessage == true)
        {
            Debug.Log("3 seconds have elapsed!!");
            makeDropperFall();
            showMessage = false;
        }
    }

    void makeDropperFall()
    {
        renderer.enabled = true;
        rigidbody.useGravity = true;
    }
}
