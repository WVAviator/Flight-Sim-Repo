using System.Collections.Generic;
using UnityEngine;

namespace FlightSim.AI
{
    public class RoamingAI : BaseAI
    {
        [SerializeField] protected AIBoundary boundary;
        [SerializeField] float collisionDetectionDistance = 200;

        ActionNode collisionDetection;
        ActionNode collisionAvoidance;
        Sequence collisionSequence;
        
        ActionNode roaming;

        protected override void AddChildren()
        {
            collisionDetection = new ActionNode(DetectPotentialCollision);
            collisionAvoidance = new ActionNode(AvoidCollision);
            collisionSequence = new Sequence(new List<Node>() {collisionDetection, collisionAvoidance});
            rootChildren.Add(collisionSequence);

            AddAdditionalNodes();
            
            roaming = new ActionNode(SetNewRandomTargetPosition);
            rootChildren.Add(roaming);
            
            SetTarget(boundary.GetRandomInsideBoundary());
        }

        protected virtual void AddAdditionalNodes()
        {
        }

        NodeState SetNewRandomTargetPosition()
        {
            if (!hasReachedTarget) return NodeState.RUNNING;
            
            SetTarget(boundary.GetRandomInsideBoundary());

            return NodeState.SUCCESS;
        }

        NodeState DetectPotentialCollision()
        {
            Ray ray = new Ray(transform.position, transform.forward);
            bool isPotentialCollision = Physics.Raycast(ray, collisionDetectionDistance);
            return isPotentialCollision ? NodeState.SUCCESS : NodeState.FAILURE;
        }

        NodeState AvoidCollision()
        {
            Vector3 avoidanceVector = transform.position + Vector3.up * 250;
            
            SetTarget(avoidanceVector);
            hasReachedTarget = true; //Never actually need to get to this target, just turn until we can clear the obstacle
            
            Brake();

            return NodeState.RUNNING;
        }

        
    }
}