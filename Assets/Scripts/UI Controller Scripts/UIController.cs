using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FlightSim
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] Canvas canvas;

        [SerializeField] List<TargetIndicator> targetIndicators = new List<TargetIndicator>();

        [SerializeField] Camera MainCamera;

        [SerializeField] GameObject TargetIndicatorPrefab;

        void Update()
        {
            if (targetIndicators.Count <= 0) return;
            for (int i = 0; i < targetIndicators.Count; i++)
            {
                targetIndicators[i].UpdateTargetIndicator();
            }
        }

        public void AddTargetIndicator(GameObject target)
        {
            TargetIndicator indicator =
                Instantiate(TargetIndicatorPrefab, canvas.transform).GetComponent<TargetIndicator>();
            indicator.InitialiseTargetIndicator(target, MainCamera, canvas);
            targetIndicators.Add(indicator);
        }

    }
}