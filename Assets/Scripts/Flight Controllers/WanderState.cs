using System.Collections;
using System;
using UnityEngine;

namespace FlightSim
{
    public class WanderState : AIState
    {
        public override Vector3 GetNewTargetPosition(AIBoundary bounds)
        {
            return bounds.GetRandomInsideBoundary();
        }

    }
}