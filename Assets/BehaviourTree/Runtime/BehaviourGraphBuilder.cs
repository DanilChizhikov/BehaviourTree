using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourGraphBuilder<TGraph> : IBehaviourGraphBuilder
            where TGraph : IBehaviourGraph
    {
        protected IBehaviourService BehaviourService { get; }

        public BehaviourGraphBuilder(IBehaviourService behaviourService)
        {
            BehaviourService = behaviourService;
        }

        public IBehaviourGraph Build() => GetGraph();

        public abstract void Reset();

        protected abstract TGraph GetGraph();
    }

    public abstract class BehaviourGraphBuilder<TGraph, TConfig> : BehaviourGraphBuilder<TGraph>
            where TGraph : IBehaviourGraph
            where TConfig : IBehaviourGraphConfig
    {
        protected TConfig Config { get; private set; }

        public BehaviourGraphBuilder(IBehaviourService behaviourService) : base(behaviourService) { }

        public BehaviourGraphBuilder<TGraph, TConfig> SetConfig(TConfig config)
        {
            Config = config;
            return this;
        }

        public override void Reset()
        {
            Config = default;
        }

        protected sealed override TGraph GetGraph()
        {
            IReadOnlyDictionary<IBehaviourStateConfig,IBehaviourState> stateMap = GetStateMap();
            IBehaviourState enterState = stateMap[Config.EnterState];
            return GetGraph(enterState, stateMap.Values);
        }

        protected abstract IBehaviourState CreateState(IBehaviourStateConfig config);

        protected abstract TGraph GetGraph(IBehaviourState enterState, IEnumerable<IBehaviourState> states);
        
        private IReadOnlyDictionary<IBehaviourStateConfig, IBehaviourState> GetStateMap()
        {
            var stateMap = new Dictionary<IBehaviourStateConfig, IBehaviourState>();
            for (int i = Config.States.Count - 1; i >= 0; i--)
            {
                IBehaviourStateConfig stateConfig = Config.States[i];
                IBehaviourState state = CreateState(stateConfig);
                stateMap.Add(stateConfig, state);
            }

            return stateMap;
        }
    }
}