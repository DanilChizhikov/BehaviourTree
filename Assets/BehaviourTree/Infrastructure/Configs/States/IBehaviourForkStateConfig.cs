using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourForkStateConfig<TEntity> : IBehaviourStateConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        IReadOnlyList<IBehaviourForkConfig<TEntity>> ForkInfos { get; }
    }
}