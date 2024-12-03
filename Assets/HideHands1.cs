using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HideHands1 : MonoBehaviour
{
    private GameObject rightHandModel;
    private GameObject leftHandModel;

    void Start()
    {
        rightHandModel = GameObject.FindWithTag("RMHand");
        leftHandModel = GameObject.FindWithTag("LMHand");

        if (rightHandModel == null || leftHandModel == null)
        {
            return;
        }

        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable == null)
        {
            return;
        }

        grabInteractable.selectEntered.AddListener(HideGrabbingHand);
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);
    }

    public void HideGrabbingHand(SelectEnterEventArgs args)
    {
        XRBaseInteractor interactor = args.interactorObject as XRBaseInteractor;
        if (interactor == null)
        {
            return;
        }

        if (interactor.CompareTag("LHand"))
        {
            if (leftHandModel != null)
            {
                leftHandModel.SetActive(false);
            }
            else
            {
            }
        }
        else if (interactor.CompareTag("RHand"))
        {
            if (rightHandModel != null)
            {
                rightHandModel.SetActive(false);
            }
            else
            {
            }
        }
    }

    public void ShowGrabbingHand(SelectExitEventArgs args)
    {
        XRBaseInteractor interactor = args.interactorObject as XRBaseInteractor;
        if (interactor == null)
        {
            return;
        }

        if (interactor.CompareTag("LHand"))
        {
            if (leftHandModel != null)
            {
                leftHandModel.SetActive(true);
            }
            else
            {
            }
        }
        else if (interactor.CompareTag("RHand"))
        {
            if (rightHandModel != null)
            {
                rightHandModel.SetActive(true);
            }
            else
            {
            }
        }
    }
}
