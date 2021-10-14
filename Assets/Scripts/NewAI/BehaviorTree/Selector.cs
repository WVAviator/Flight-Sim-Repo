using System;
using System.Collections.Generic;

namespace FlightSim.AI
{
    public class Selector : Node
    {
        protected List<Node> children;

        public Selector(List<Node> nodes)
        {
            children = nodes;
        }
        
        
        public override NodeState Evaluate()
        {
            foreach (Node node in children)
            {
                switch (node.Evaluate())
                {
                    case NodeState.FAILURE:
                        continue;
                    case NodeState.SUCCESS:
                        return Set(NodeState.SUCCESS);
                    case NodeState.RUNNING:
                        return Set(NodeState.RUNNING);
                    
                    default:
                        continue;
                }
            }

            return Set(NodeState.FAILURE);
        }
    }
}