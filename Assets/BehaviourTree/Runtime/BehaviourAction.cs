using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourAction<TConfig> : IBehaviourAction
            where TConfig : IBehaviourActionConfig
    {
        protected TConfig Config { get; }
        
        public BehaviourAction(TConfig config)
        {
            Config = config;
        }
        
        public abstract void Enter();
        public abstract void Processing();
        public abstract void Exit();
    }
}