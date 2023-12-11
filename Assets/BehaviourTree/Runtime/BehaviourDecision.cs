using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourDecision<TConfig, TEntity> : IBehaviourDecision<TEntity>
            where TConfig : IBehaviourDecisionConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        protected TConfig Config { get; }

        public BehaviourDecision(TConfig config)
        {
            Config = config;
        }
        
        public virtual void Enter(TEntity entity) { }

        public bool GetDecision(TEntity entity)
        {
            return Config.IsReverse ? !CheckDecision(entity) : CheckDecision(entity);
        }

        public virtual void Exit(TEntity entity) { }

        protected abstract bool CheckDecision(TEntity entity);
    }
}