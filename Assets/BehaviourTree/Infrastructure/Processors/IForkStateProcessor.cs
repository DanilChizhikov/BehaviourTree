namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IForkStateProcessor<TEntity> : IBehaviourStateProcessor<IBehaviourForkState<TEntity>, TEntity>
            where TEntity : IBehaviourEntity { }
}