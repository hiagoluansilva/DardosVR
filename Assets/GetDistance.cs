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

    // Referência ao XR Origin (XR Rig)
    public Transform xrOrigin;

    // Referência ao objeto alvo
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