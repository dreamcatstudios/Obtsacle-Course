using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField]
    int rotationSpeed = 10;

    [SerializeField]
    int speedBump;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its X-axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime * speedBump, 0);
    }
}
