using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlightSim
{
    public class PlayerGroundRespawn : MonoBehaviour
    {
        [SerializeField] private Transform player;
        [SerializeField] private Transform respawnPoint;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                player.transform.position = respawnPoint.transform.position;
                Physics.SyncTransforms();
            }
        }
    }
}