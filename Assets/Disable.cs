using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    public int points;
    public float distance;

    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InBasket);
    }

    public void InBasket(GameObject go)
    {
        distance = GetDistance.instance.Distance();

        if (distance < 4.5)
        {
            points *= 1;
        }
        else if(distance < 8.5)
        {
            points *= 2;
        }
        else if (distance < 15)
        {
            points *= 3;
        }
        
        ScoreManager.instance.AddScore(points);

        go.SetActive(false);
    }

}
