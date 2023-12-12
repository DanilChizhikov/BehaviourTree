using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public sealed class BehaviourFork
    {
        public IBehaviourPort Port { get; }
        public int Weight { get; }
        public IReadOnlyList<IBehaviourDecision> Decisions { get; }

        public BehaviourFork(IBehaviourPort port, int weight, IEnumerable<IBehaviourDecision> decisions)
        {
            Port = port;
            Weight = weight;
            Decisions = new List<IBehaviourDecision>(decisions);
        }
    }
}