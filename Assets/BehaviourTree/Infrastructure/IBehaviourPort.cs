namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourPort<TEntity> where TEntity : IBehaviourEntity
    {
        IBehaviourState<TEntity> NextState { get; }
    }
}