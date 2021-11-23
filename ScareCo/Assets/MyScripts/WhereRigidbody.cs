using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhereRigidbody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody[] rbs = GetComponentsInChildren<Rigidbody>();
        Debug.Log(rbs.Length);
        foreach (Rigidbody rb in rbs)
        {
            Destroy(rb);
        }
    }
}
