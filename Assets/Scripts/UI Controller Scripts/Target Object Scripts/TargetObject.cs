using UnityEngine;

namespace FlightSim
{
    public class TargetObject : MonoBehaviour
    {
        private void Awake()
        {
            UIController ui = GetComponentInParent<UIController>();
            //UIControllerAllyName ui = GetComponentInParent<UIControllerAllyName>();
            if (ui == null)
            {
                ui = GameObject.Find("World").GetComponent<UIController>();
            }

            if (ui == null) Debug.LogError("No UIController component found");

            ui.AddTargetIndicator(this.gameObject);
        }
    }
}