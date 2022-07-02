using UnityEngine;
using UnityEngine.Events;

namespace RedPanda.TriggerSystem
{
    [System.Serializable]
    internal struct TagAndEvent
    {
        [SerializeField] internal string eventTag; //the trigger's tag must be same with gameObject tag
        [SerializeField] internal TriggerType triggerType; //trigger type like enter or exit
        [SerializeField] internal UnityEvent unityEvent;
    }

    internal enum TriggerType
    {
        OnEnter,
        OnExit,
        OnEnterAndExit
    }
}