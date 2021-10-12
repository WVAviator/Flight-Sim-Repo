using UnityEngine;

namespace FlightSim
{
    public class TargetObjectSpecter : MonoBehaviour
    {
        private void Awake()
        {
            UIControllerSpecter ui = GetComponentInParent<UIControllerSpecter>();
            if (ui == null)
            {
                ui = GameObject.Find("World").GetComponent<UIControllerSpecter>();
            }

            if (ui == null) Debug.LogError("No UIControllerSpecter component found");

            ui.AddTargetIndicator(this.gameObject);
        }
    }
}