using System;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourStateProcessorService
    {
        bool TryGetProcessor(Type stateType, out IBehaviourStateProcessor<IBehaviourState> processor);
    }
}