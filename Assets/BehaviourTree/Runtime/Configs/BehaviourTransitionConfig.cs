using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    [Serializable]
    public sealed class BehaviourTransitionConfig
    {
        [SerializeField] private BehaviourPortConfig _truePort = default;
        [SerializeField] private BehaviourPortConfig _falsePort = default;
        [SerializeField] private BehaviourDecisionConfig[] _decision = Array.Empty<BehaviourDecisionConfig>();

        public IBehaviourPortConfig TruePort => _truePort;
        public IBehaviourPortConfig FalsePort => _falsePort;
        public IReadOnlyList<IBehaviourDecisionConfig> Decisions => _decision;
    }
}