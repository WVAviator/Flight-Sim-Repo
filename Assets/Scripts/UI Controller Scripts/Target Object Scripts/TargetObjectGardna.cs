using UnityEngine;

namespace FlightSim
{
    public class TargetObjectGardna : MonoBehaviour
    {
        private void Awake()
        {
            UIControllerGardna ui = GetComponentInParent<UIControllerGardna>();
            if (ui == null)
            {
                ui = GameObject.Find("UI Controllers").GetComponent<UIControllerGardna>();
            }

            if (ui == null) Debug.LogError("No UIControllerGardna component found");

            ui.AddTargetIndicator(this.gameObject);
        }
    }
}