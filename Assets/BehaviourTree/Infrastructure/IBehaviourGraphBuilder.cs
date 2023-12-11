namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourGraphBuilder<TEntity> where TEntity : IBehaviourEntity
    {
        IBehaviourGraphBuilder<TEntity> SetGraphConfig(IBehaviourGraphConfig<TEntity> value);
        IBehaviourGraphBuilder<TEntity> SetEntity(TEntity value);
        IBehaviourGraph<TEntity> Build();
    }
}