using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        // Logic for collecting the item
        Debug.Log("The item has been collected!");
        Destroy(gameObject);
    }
}

