using System;
using UnityEngine;

namespace FlightSim
{
    [CreateAssetMenu(menuName = "Flight/Squadron")]
    public class Squadron : ScriptableObject
    {
        [SerializeField] string name;
        public string Name => name;
    }
}