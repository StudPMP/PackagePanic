using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchPlayer : MonoBehaviour
{
    Transform Player;
    Vector3 PlayerVector;
    private void Start()
    {
        Player = GameObject.Find("Player").transform;
    }
    private void FixedUpdate()
    {
        PlayerVector = Player.position;
        PlayerVector.z = -10;
        transform.position = Vector3.Lerp(transform.position, PlayerVector, Time.deltaTime);
    }
}
