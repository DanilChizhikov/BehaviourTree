using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    [Serializable]
    public sealed class BehaviourTransitionConfig : IBehaviourTransitionConfig
    {
        [SerializeField] private BehaviourPortConfig _truePort = default;
        [SerializeField] private BehaviourPortConfig _falsePort = default;
        [SerializeField] private BehaviourDecisionConfig[] _decision = Array.Empty<BehaviourDecisionConfig>();

        public IBehaviourPortConfig TruePort => _truePort;
        public IBehaviourPortConfig FalsePort => _falsePort;
        public IReadOnlyList<IBehaviourDecisionConfig> Decisions => _decision;

        public BehaviourTransitionConfig(BehaviourPortConfig truePort, BehaviourPortConfig falsePort,
                                         BehaviourDecisionConfig[] decision)
        {
            _truePort = truePort;
            _falsePort = falsePort;
            _decision = decision;
        }
    }
}