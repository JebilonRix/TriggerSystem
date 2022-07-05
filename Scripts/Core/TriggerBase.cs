﻿using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.TriggerSystem
{
    public class TriggerBase : MonoBehaviour
    {
        [SerializeField] internal List<TagAndEvent> events = new List<TagAndEvent>();

        /// <summary>
        ///This method works about reverse of the Trigger type. For example if you want to works an event on enter, you should call this method with reverse tag like on exit.
        /// </summary>
        /// <param name="tag">The object tag which triggers the event</param>
        /// <param name="type"> Type of trigger</param>
        internal void ReverseTriggerLogic(string tag, TriggerType type)
        {
            foreach (TagAndEvent item in events)
            {
                //Search for the trigger event.
                if (tag != item.eventTriggerObjectTag || item.triggerType == type)
                {
                    continue;
                }

                //Triggers the event
                item.unityEvent?.Invoke();
            }
        }
    }
}