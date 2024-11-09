using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InBasket);
    }

    public void InBasket(GameObject go)
    {
        go.SetActive(false);
    }

 
}
