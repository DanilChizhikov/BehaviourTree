using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourLogicStateConfig<TEntity> : IBehaviourStateConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        IReadOnlyList<IBehaviourActionConfig<TEntity>> Actions { get; }
        IReadOnlyList<IBehaviourTransitionConfig<TEntity>> Transitions { get; }
    }
}