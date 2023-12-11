using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourGraphConfig<TEntity> where TEntity : IBehaviourEntity
    {
        IBehaviourStateConfig<TEntity> EnterState { get; }
        IReadOnlyList<IBehaviourStateConfig<TEntity>> States { get; }
    }
}
