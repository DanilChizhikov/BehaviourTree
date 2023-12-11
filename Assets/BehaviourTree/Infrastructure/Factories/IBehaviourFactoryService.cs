namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourFactoryService<TEntity> where TEntity : IBehaviourEntity
    {
        IBehaviourAction<TEntity> CreateAction(IBehaviourActionConfig<TEntity> config);
        IBehaviourDecision<TEntity> CreateDecision(IBehaviourDecisionConfig<TEntity> config);
    }
}