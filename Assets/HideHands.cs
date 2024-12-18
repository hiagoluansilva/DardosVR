using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HideHands : MonoBehaviour
{
    public GameObject rightHandModel;
    public GameObject leftHandModel;

    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHand);
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);
    }

    public void HideGrabbingHand(SelectEnterEventArgs args)
    { 
        if (args.interactorObject.transform.tag == "LHand") 
        {
            leftHandModel.SetActive(false);
        }
        else if(args.interactorObject.transform.tag == "RHand")
        {
            rightHandModel.SetActive(false);
        }
    }


    public void ShowGrabbingHand(SelectExitEventArgs args) 
    {
        if (args.interactorObject.transform.tag == "LHand")
        {
            leftHandModel.SetActive(true);
        }
        else if (args.interactorObject.transform.tag == "RHand")
        {
            rightHandModel.SetActive(true);
        }
    }
}
