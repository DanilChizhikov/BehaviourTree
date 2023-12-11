using MbsCore.BehaviourTree.Infrastructure;
using XNode;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourStateConfig<TEntity> : Node, IBehaviourStateConfig<TEntity>
            where TEntity : IBehaviourEntity { }
}