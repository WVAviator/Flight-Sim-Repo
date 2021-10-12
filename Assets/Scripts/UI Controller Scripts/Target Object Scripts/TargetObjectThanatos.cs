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
                ui = GameObject.Find("World").GetComponent<UIControllerThanatos>();
            }

            if (ui == null) Debug.LogError("No UIControllerThanatos component found");

            ui.AddTargetIndicator(this.gameObject);
        }
    }
}