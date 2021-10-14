using UnityEngine;

namespace FlightSim
{
    public class TargetObjectEmber : MonoBehaviour
    {
        private void Awake()
        {
            UIControllerEmber ui = GetComponentInParent<UIControllerEmber>();
            //UIControllerAllyName ui = GetComponentInParent<UIControllerAllyName>();
            if (ui == null)
            {
                ui = GameObject.Find("UI Controllers").GetComponent<UIControllerEmber>();
            }

            if (ui == null) Debug.LogError("No UIControllerEmber component found");

            ui.AddTargetIndicator(this.gameObject);
        }
    }
}