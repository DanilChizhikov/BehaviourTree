namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourPortConfig<TEntity> where TEntity : IBehaviourEntity
    {
        string Name { get; }
        IBehaviourStateConfig<TEntity> NextState { get; }
    }
}