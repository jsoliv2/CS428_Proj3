using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneRotation : MonoBehaviour
{
    [SerializeField] GameObject roomObj;
    [SerializeField] float rotationSpeed = 10.0f;

    bool inUse = false;

    void Update()
    {
        if (!inUse)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                StartCoroutine(rotateScene(1, 0, 0));
            }
            else if (Input.GetKeyDown(KeyCode.Y))
            {
                StartCoroutine(rotateScene(0, 1, 0));
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                StartCoroutine(rotateScene(0, 0, 1));
            }
            else { }
        }
        
    }

    public IEnumerator rotateScene(int x, int y, int z)
    {
        if (!inUse)
        {
            inUse = true;
            float currentRot = 0.0f;

            while (currentRot < 90.0f)
            {
                float rotChange = rotationSpeed;
                if (rotChange > (90.0f - currentRot))
                {
                    rotChange = (90.0f - currentRot);
                }
                currentRot += rotChange;
                roomObj.transform.Rotate(new Vector3(rotChange * x, rotChange * y, rotChange * z), Space.World);
                yield return new WaitForSeconds(0.0167f);
            }
            inUse = false;
        }
        yield return null;
    }
}
