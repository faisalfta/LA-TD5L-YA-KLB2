using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera1 : MonoBehaviour
{

    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}