using UnityEngine;

namespace FlightSim
{
    public class TargetObjectTerra : MonoBehaviour
    {
        private void Awake()
        {
            UIControllerTerra ui = GetComponentInParent<UIControllerTerra>();
            //UIControllerAllyName ui = GetComponentInParent<UIControllerAllyName>();
            if (ui == null)
            {
                ui = GameObject.Find("UI Controllers").GetComponent<UIControllerTerra>();
            }

            if (ui == null) Debug.LogError("No UIControllerEmberTerra component found");

            ui.AddTargetIndicator(this.gameObject);
        }
    }
}