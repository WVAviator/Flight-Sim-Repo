using UnityEngine;

namespace FlightSim.AI
{
    class ActionNode : Node
    {
        public delegate NodeState ActionNodeDelegate();

        ActionNodeDelegate action;

        public ActionNode(ActionNodeDelegate action)
        {
            this.action = action;
        }
        
        public override NodeState Evaluate()
        {
            return Set(action());
        }
    }
}