using UnityEngine;

namespace FlightSim
{
    public class TargetObjectThanatos : MonoBehaviour
    {
        private void Awake()
        {
            UIControllerThanatos ui = GetComponentInParent<UIControllerThanatos>();
            if (ui == null)
            {
                ui = GameObject.Find("UI Controllers").GetComponent<UIControllerThanatos>();
            }

            if (ui == null) Debug.LogError("No UIControllerThanatos component found");

            ui.AddTargetIndicator(this.gameObject);
        }
    }
}