using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourAction<TConfig, TEntity> : IBehaviourAction<TEntity>
            where TConfig : IBehaviourActionConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        protected TConfig Config { get; }
        
        public BehaviourAction(TConfig config)
        {
            Config = config;
        }
        
        public abstract void Enter(TEntity entity);
        public abstract void Processing(TEntity entity);
        public abstract void Exit(TEntity entity);
    }
}