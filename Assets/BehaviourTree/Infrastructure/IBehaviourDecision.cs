namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourDecision<TEntity> where TEntity : IBehaviourEntity
    {
        void Enter(TEntity entity);
        bool GetDecision(TEntity entity);
        void Exit(TEntity entity);
    }
}