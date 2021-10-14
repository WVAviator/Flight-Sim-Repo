using System;
using UnityEngine;

namespace FlightSim
{
    [CreateAssetMenu(menuName = "Flight/Squadron")]
    public class Squadron : ScriptableObject
    {
        [SerializeField] string squadronName;
        public string SquadronName => squadronName;
    }
}