namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface ILogicStateProcessor<TEntity> : IBehaviourStateProcessor<IBehaviourLogicState<TEntity>, TEntity>
            where TEntity : IBehaviourEntity { }
}