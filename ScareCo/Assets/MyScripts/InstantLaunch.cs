using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantLaunch : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    void Start()
    {
        if (rb != null)
        {
            rb.AddForce(new Vector3(0f, 0f, -25f), ForceMode.Impulse);
        }
    }
}
