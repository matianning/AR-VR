using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporteur : MonoBehaviour
{
    GameObject player;
    GameObject Spawn;
    public GameObject fx;


    void Start()
    {
        Spawn = GameObject.Find("SpawnPoint");
        player = GameObject.FindWithTag("Player");
    }


    void OnTriggerEnter(Collider other)
    {
        player.transform.position = Spawn.transform.position;
        player.transform.rotation = Spawn.transform.rotation;
        Instantiate(fx, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
