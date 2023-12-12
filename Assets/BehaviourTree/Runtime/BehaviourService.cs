using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public sealed class BehaviourService : IBehaviourService
    {
        private readonly HashSet<IBehaviourStateFactory> _stateFactories;
        private readonly Dictionary<Type, IBehaviourStateFactory> _stateFactoriesMap;
        private readonly HashSet<IBehaviourActionFactory> _actionFactories;
        private readonly Dictionary<Type, IBehaviourActionFactory> _actionFactoriesMap;
        private readonly HashSet<IBehaviourDecisionFactory> _decisionFactories;
        private readonly Dictionary<Type, IBehaviourDecisionFactory> _decisionFactoriesMap;

        public BehaviourService(IEnumerable<IBehaviourStateFactory> stateFactories,
                                IEnumerable<IBehaviourActionFactory> actionFactories,
                                IEnumerable<IBehaviourDecisionFactory> decisionFactories)
        {
            _stateFactories = new HashSet<IBehaviourStateFactory>(stateFactories);
            _stateFactoriesMap = new Dictionary<Type, IBehaviourStateFactory>();
            _actionFactories = new HashSet<IBehaviourActionFactory>(actionFactories);
            _actionFactoriesMap = new Dictionary<Type, IBehaviourActionFactory>();
            _decisionFactories = new HashSet<IBehaviourDecisionFactory>(decisionFactories);
            _decisionFactoriesMap = new Dictionary<Type, IBehaviourDecisionFactory>();
        }
        
        public IBehaviourState CreateState(IBehaviourStateConfig config)
        {
            if (!_stateFactoriesMap.TryGetValue(config.GetType(), out IBehaviourStateFactory stateFactory))
            {
                if (!_stateFactories.TryGetServiceable(config.GetType(), out stateFactory))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            return stateFactory.Create(config);
        }

        public IBehaviourAction CreateAction(IBehaviourActionConfig config)
        {
            if (!_actionFactoriesMap.TryGetValue(config.GetType(), out IBehaviourActionFactory actionFactory))
            {
                if (!_actionFactories.TryGetServiceable(config.GetType(), out actionFactory))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            return actionFactory.Create(config);
        }

        public IBehaviourDecision CreateDecision(IBehaviourDecisionConfig config)
        {
            if (!_decisionFactoriesMap.TryGetValue(config.GetType(), out IBehaviourDecisionFactory decisionFactory))
            {
                if (!_decisionFactories.TryGetServiceable(config.GetType(), out decisionFactory))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            return decisionFactory.Create(config);
        }
    }
}