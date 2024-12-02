using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPush : MonoBehaviour
{
    public int idButton;
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => DestroyAndSpawn());
    }

    void Update()
    {
        
    }

    public void DestroyAndSpawn()
    {
        Destroy(GameObject.FindWithTag("dardoEsfera"));
        SpawnerTomato.instance.SpwTomato(this.idButton);
    }
}
