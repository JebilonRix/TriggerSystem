using UnityEngine;

namespace RedPanda.TriggerSystem
{
    [RequireComponent(typeof(Collider))]
    public class TriggerHandler : TriggerBase
    {
        #region Unity Methods
        private void Awake()
        {
            Collider col = GetComponent<Collider>();

            if (col.GetType() == typeof(MeshCollider))
            {
                col.GetComponent<MeshCollider>().convex = true;
            }

            col.isTrigger = true;
        }
        private void OnTriggerEnter(Collider other) => TriggerLogic(other.gameObject.tag, TriggerType.OnExit);
        private void OnTriggerExit(Collider other) => TriggerLogic(other.gameObject.tag, TriggerType.OnEnter);
        #endregion Unity Methods
    }
}