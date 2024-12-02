using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    public int points;

    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InBasket);
    }

    public void InBasket(GameObject go)
    {
        ScoreManager.instance.AddScore(points);
        go.SetActive(false);
    }

 
}
