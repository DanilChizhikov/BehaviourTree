namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourAction<TEntity>
    {
        void Enter(TEntity entity);
        void Processing(TEntity entity);
        void Exit(TEntity entity);
    }
}