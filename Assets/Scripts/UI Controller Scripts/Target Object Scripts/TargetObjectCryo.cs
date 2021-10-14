using UnityEngine;

namespace FlightSim
{
    public class TargetObjectCryo : MonoBehaviour
    {
        private void Awake()
        {
            UIControllerCryo ui = GetComponentInParent<UIControllerCryo>();
            //UIControllerAllyName ui = GetComponentInParent<UIControllerAllyName>();
            if (ui == null)
            {
                ui = GameObject.Find("UI Controllers").GetComponent<UIControllerCryo>();
            }

            if (ui == null) Debug.LogError("No UIControllerEmberCryo component found");

            ui.AddTargetIndicator(this.gameObject);
        }
    }
}