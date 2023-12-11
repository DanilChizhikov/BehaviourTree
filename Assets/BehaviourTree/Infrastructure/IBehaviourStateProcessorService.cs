using System;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourStateProcessorService<TEntity> where TEntity : IBehaviourEntity
    {
        bool TryGetProcessor(Type stateType, out IBehaviourStateProcessor<IBehaviourState<TEntity>, TEntity> processor);
    }
}