using UnityEngine;

namespace FlightSim
{
    public class TargetObjectWraith : MonoBehaviour
    {
        private void Awake()
        {
            UIControllerWraith ui = GetComponentInParent<UIControllerWraith>();
            if (ui == null)
            {
                ui = GameObject.Find("UI Controllers").GetComponent<UIControllerWraith>();
            }

            if (ui == null) Debug.LogError("No UIControllerWraith component found");

            ui.AddTargetIndicator(this.gameObject);
        }
    }
}