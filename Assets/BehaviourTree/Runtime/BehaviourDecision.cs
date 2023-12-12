using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourDecision<TConfig> : IBehaviourDecision where TConfig : IBehaviourDecisionConfig
    {
        protected TConfig Config { get; }

        public BehaviourDecision(TConfig config)
        {
            Config = config;
        }
        
        public virtual void Enter() { }

        public bool GetDecision()
        {
            return Config.IsReverse ? !CheckDecision() : CheckDecision();
        }

        public virtual void Exit() { }

        protected abstract bool CheckDecision();
    }
}