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
        ScoreManager.instance.AddScore();
        go.SetActive(false);
    }

 
}
