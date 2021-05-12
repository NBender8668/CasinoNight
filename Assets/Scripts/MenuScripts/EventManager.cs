using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    Dictionary<string, UnityEvent> events = new Dictionary<string, UnityEvent>();

    static EventManager instance = null;
    public static EventManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        instance = this;
    }

    public void Subscribe(string eventName, UnityAction listener)
    {
        UnityEvent unityEvent;
        if (events.TryGetValue(eventName, out unityEvent))
        {
            unityEvent.AddListener(listener);
        }
        else
        {
            unityEvent = new UnityEvent();
            unityEvent.AddListener(listener);
            events[eventName] = unityEvent;
        }
    }

    public void TriggerEvent(string eventName)
    {
        UnityEvent unityEvent;
        if (events.TryGetValue(eventName, out unityEvent))
        {
            unityEvent.Invoke();
        }
    }
}
