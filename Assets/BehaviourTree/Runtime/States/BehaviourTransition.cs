using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public sealed class BehaviourTransition : IBehaviourTransition
    {
        public IBehaviourPort TruePort { get; }
        public IBehaviourPort FalsePort { get; }
        public IReadOnlyList<IBehaviourDecision> Decisions { get; }

        public BehaviourTransition(IBehaviourPort truePort, IBehaviourPort falsePort, IEnumerable<IBehaviourDecision> decisions)
        {
            TruePort = truePort;
            FalsePort = falsePort;
            Decisions = new List<IBehaviourDecision>(decisions);
        }
    }
}