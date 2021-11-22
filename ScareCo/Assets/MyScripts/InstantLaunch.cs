using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantLaunch : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float launchSpeed = 25.0f;

    void Start()
    {
        this.gameObject.transform.parent.parent.parent = null;
        if (rb != null)
        {
            rb.AddRelativeForce(Vector3.forward * -launchSpeed, ForceMode.Impulse);
        }
    }
}
