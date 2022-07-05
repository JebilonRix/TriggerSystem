using UnityEngine;

namespace RedPanda.TriggerSystem
{
    [RequireComponent(typeof(Collider2D))]
    public class TriggerHandler2D : TriggerBase
    {
        #region Unity Methods
        private void Awake() => GetComponent<Collider2D>().isTrigger = true;  //Makes the collider as trigger.
        private void OnTriggerEnter2D(Collider2D other) => TriggerLogic(other.gameObject.tag, TriggerType.OnEnter);
        private void OnTriggerExit2D(Collider2D other) => TriggerLogic(other.gameObject.tag, TriggerType.OnExit);
        #endregion Unity Methods
    }
}