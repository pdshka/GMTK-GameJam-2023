using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTeleport : MonoBehaviour
{
    private CheckPointManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("CheckPointManager").GetComponent<CheckPointManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger");
        if (other.CompareTag("Player"))
        {
            manager.TeleportToCheckPoint();
        }
    }
}
