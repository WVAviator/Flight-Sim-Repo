using System.Collections.Generic;

namespace FlightSim.AI
{
    public class Sequence : Node
    {

        protected List<Node> children;

        public Sequence(List<Node> nodes)
        {
            children = nodes;
        }
        public override NodeState Evaluate()
        {
            bool anyChildRunning = false;
            
            foreach (Node node in children)
            {
                switch (node.Evaluate())
                {
                    case NodeState.FAILURE:
                        return Set(NodeState.FAILURE);
                    case NodeState.SUCCESS:
                        continue;
                    case NodeState.RUNNING:
                        anyChildRunning = true;
                        continue;
                    default:
                        return Set(NodeState.SUCCESS);
                }
            }

            return anyChildRunning ? Set(NodeState.RUNNING) : Set(NodeState.SUCCESS);
        }
    }
}