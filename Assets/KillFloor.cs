using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFloor : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           player.gameObject.GetComponent<CharacterController>().enabled = false;
            player.position = respawn_point.position;
            player.gameObject.GetComponent<CharacterController>().enabled = true;
            
            Debug.Log("Restart level");
        }
    }
}