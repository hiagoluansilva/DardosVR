using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SpawnerTomato : MonoBehaviour
{
    public GameObject tomatoPrefab;

    public static SpawnerTomato instance;

    private void Awake()
    {
        instance = this;
    }

    public void SpwTomato(int id)
    {
        if (id == 1)
        {
            Instantiate(tomatoPrefab, new Vector3(-3.337203f, 1.305969f, 0.2050877f), Quaternion.identity);
        }
        else if (id == 2)
        {
            Instantiate(tomatoPrefab, new Vector3(-1.749585f, 1.15697f, -2.361174f), Quaternion.identity);
        }
        else if (id == 3) 
        {
            Instantiate(tomatoPrefab, new Vector3(-2.061975f, 1.20697f, -7.167884f), Quaternion.identity);
        }
        
    }

    void Start()
    {

    }

}
