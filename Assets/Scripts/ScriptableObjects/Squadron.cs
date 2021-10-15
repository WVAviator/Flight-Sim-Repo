using System;
using System.Collections.Generic;
using UnityEngine;

namespace FlightSim
{
    [CreateAssetMenu(menuName = "Flight/Squadron")]
    public class Squadron : ScriptableObject
    {
        public string SquadronName => squadronName;
        [SerializeField] string squadronName;

        public List<Squadron> FriendlySquadrons => friendlySquadrons;
        [SerializeField] List<Squadron> friendlySquadrons;

        public bool ShouldOverrideUIColor => shouldOverrideUIColor;
        [SerializeField] bool shouldOverrideUIColor;

        public Color OverrideColor => overrideColor;
        [SerializeField] Color overrideColor;
    }
}