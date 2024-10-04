using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;

    [SerializeField]
    GameObject startObject;

    void Start()
    {
        PrintInstruction();
        transform.position = startObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD");
        Debug.Log("Don't hit the wall");
    }

    void MovePlayer()
    {
        float xType = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed * -1;
        float zType = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed * -1;

        transform.Translate(xType, 0, zType);
    }
}
