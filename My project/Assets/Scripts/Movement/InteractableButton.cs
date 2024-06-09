using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableButton : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Button pressed!");
        EventManager.Instance.ButtonPressed();
    }
}
