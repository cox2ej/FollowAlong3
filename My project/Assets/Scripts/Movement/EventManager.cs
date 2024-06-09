using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Ensure the EventManager persists across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public event Action OnButtonPressed;

    public void ButtonPressed()
    {
        OnButtonPressed?.Invoke();
    }
}
