using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourGraphBuilder<TGraph, TConfig> : IBehaviourGraphBuilder<TGraph, TConfig>
            where TGraph : IBehaviourGraph
            where TConfig : IBehaviourGraphConfig
    {
        private readonly IBehaviourService _behaviourService;

        protected TConfig GraphConfig { get; private set; }

        public BehaviourGraphBuilder(IBehaviourService behaviourService)
        {
            _behaviourService = behaviourService;
        }
        
        public IBehaviourGraphBuilder<TGraph, TConfig> SetGraphConfig(TConfig value)
        {
            GraphConfig = value;
            return this;
        }

        public TGraph Build()
        {
            
        }

        public void Reset()
        {
            GraphConfig = default;
        }
        
        
    }
}