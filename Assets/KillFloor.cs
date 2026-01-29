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
            player.position = respawn_point.position;
            player.position = new Vector3(2.302f, 1.421f, -4.342182f);
            Debug.Log("Restart level");
        }
    }
}