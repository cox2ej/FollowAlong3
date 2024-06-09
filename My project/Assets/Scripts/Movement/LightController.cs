using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light lightComponent;

    private void OnEnable()
    {
        // Subscribe to the event in a delayed manner to ensure EventManager is initialized
        StartCoroutine(SubscribeToEvent());
    }

    private void OnDisable()
    {
        // Unsubscribe from the event
        if (EventManager.Instance != null)
        {
            EventManager.Instance.OnButtonPressed -= ToggleLight;
        }
    }

    private void Start()
    {
        lightComponent = GetComponent<Light>();
        if (lightComponent == null)
        {
            Debug.LogError("No Light component found on this GameObject.");
        }
    }

    private System.Collections.IEnumerator SubscribeToEvent()
    {
        yield return new WaitForEndOfFrame();

        if (EventManager.Instance != null)
        {
            EventManager.Instance.OnButtonPressed += ToggleLight;
        }
        else
        {
            Debug.LogError("EventManager instance is null in LightController.OnEnable");
        }
    }

    private void ToggleLight()
    {
        if (lightComponent != null)
        {
            lightComponent.enabled = !lightComponent.enabled;
            Debug.Log("Light toggled!");
        }
    }
}
