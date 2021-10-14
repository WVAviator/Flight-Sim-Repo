using UnityEngine;

namespace FlightSim
{
    public class TargetObjectEnemy : MonoBehaviour
    {
        private void Awake()
        {
            UIControllerEnemy ui = GetComponentInParent<UIControllerEnemy>();
            if (ui == null)
            {
                ui = GameObject.Find("UI Controllers").GetComponent<UIControllerEnemy>();
            }

            if (ui == null) Debug.LogError("No UIControllerEnemy component found");

            ui.AddTargetIndicator(this.gameObject);
        }
    }
}