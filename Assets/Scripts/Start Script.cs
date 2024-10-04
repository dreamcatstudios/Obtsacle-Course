using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InitialScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject startingPoint;

    void Start()
    {
        player.transform.position = startingPoint.transform.position;
    }
}
