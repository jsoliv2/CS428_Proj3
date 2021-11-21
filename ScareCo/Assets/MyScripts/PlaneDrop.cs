using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDrop : MonoBehaviour
{
    [SerializeField] private GameObject paratrooper;
    [SerializeField] private Transform spawnLocation;

    public void DropParatrooper()
    {
        Instantiate(paratrooper, spawnLocation.position, Quaternion.identity);
    }
}
