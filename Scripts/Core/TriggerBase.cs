using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.TriggerSystem
{
    public class TriggerBase : MonoBehaviour
    {
        [SerializeField] internal List<TagAndEvent> events = new List<TagAndEvent>();

        internal void TriggerLogic(string tag, TriggerType type)
        {
            foreach (TagAndEvent item in events)
            {
                //Search for the trigger event.
                if (tag != item.eventTag || item.triggerType == type)
                {
                    continue;
                }

                //Triggers event
                item.unityEvent?.Invoke();
            }
        }
    }
}