namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourDecisionConfig<TEntity> where TEntity : IBehaviourEntity
    {
        bool IsReverse { get; }
    }
}