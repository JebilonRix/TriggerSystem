using UnityEngine;

namespace RedPanda.TriggerSystem
{
    [RequireComponent(typeof(Collider))]
    public class TriggerHandler : TriggerBase
    {
        #region Unity Methods
        private void Awake()
        {
            //Finds the trigger<
            Collider col = GetComponent<Collider>();

            //Checks if the trigger is mesh collision.
            if (col.GetType() == typeof(MeshCollider))
            {
                col.GetComponent<MeshCollider>().convex = true;
            }

            //Makes the collider as trigger.
            col.isTrigger = true;
        }
        private void OnTriggerEnter(Collider other) => TriggerLogic(other.gameObject.tag, TriggerType.OnEnter);
        private void OnTriggerExit(Collider other) => TriggerLogic(other.gameObject.tag, TriggerType.OnExit);
        #endregion Unity Methods
    }
}