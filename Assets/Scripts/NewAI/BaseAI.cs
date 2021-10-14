using System.Collections.Generic;
using UnityEngine;

namespace FlightSim.AI
{
    public abstract class BaseAI : AIController
    {
        protected List<Node> rootChildren;
        Selector root;

        void Awake()
        {
            rootChildren = new List<Node>();
            AddChildren();
            root = new Selector(rootChildren);
        }

        void Update()
        {
            root.Evaluate();
        }


        protected virtual void AddChildren()
        {
            
        }
    }
}