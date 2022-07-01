using UnityEngine;
using UnityEngine.Events;

namespace RedPanda.TriggerSystem
{
    [System.Serializable]
    internal struct TagAndEvent
    {
        [SerializeField] internal string eventTag;
        [SerializeField] internal TriggerType triggerType;
        [SerializeField] internal UnityEvent unityEvent;
    }

    internal enum TriggerType
    {
        OnEnter,
        OnExit,
        OnEnterAndExit
    }
}