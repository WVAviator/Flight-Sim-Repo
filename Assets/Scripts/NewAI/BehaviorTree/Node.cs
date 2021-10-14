using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlightSim.AI
{
    public abstract class Node
    {
        protected NodeState state;
        public NodeState State => state;

        public abstract NodeState Evaluate();

        protected NodeState Set(NodeState state)
        {
            this.state = state;
            return state;
        }
    }

    public enum NodeState
    {
        SUCCESS, RUNNING, FAILURE
    }
}
