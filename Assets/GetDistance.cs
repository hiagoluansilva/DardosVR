using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GetDistance : MonoBehaviour
{

    public static GetDistance instance;
    private void Awake()
    {
        instance = this;
    }

    // Refer�ncia ao XR Origin (XR Rig)
    public Transform xrOrigin;

    // Refer�ncia ao objeto alvo
    public Transform targetObject;

    public float Distance()
    {
        if (xrOrigin != null && targetObject != null)
        {
            float distance = Vector3.Distance(xrOrigin.position, targetObject.position);

            return distance;
        }
        else
        {
            return 0;
        }
    }

    void Update()
    {
    }
}