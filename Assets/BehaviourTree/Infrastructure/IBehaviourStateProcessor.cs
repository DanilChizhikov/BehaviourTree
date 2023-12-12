using System;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourStateProcessor<TState> where TState : IBehaviourState
    {
        Type ServicedStateType { get; }
        
        TState Processing(TState state, bool isFirstProcessing);
    }
}