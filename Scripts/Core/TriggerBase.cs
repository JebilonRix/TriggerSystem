using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.TriggerSystem
{
    public class TriggerBase : MonoBehaviour
    {
        [SerializeField] internal List<TagAndEvent> events = new List<TagAndEvent>();

        internal void TriggerLogic(string tag, TriggerType type)
        {
            Debug.Log("test");

            foreach (TagAndEvent item in events)
            {
                if (tag != item.eventTag || item.triggerType == type)
                {
                    continue;
                }

                item.unityEvent?.Invoke();
            }
        }
    }
}