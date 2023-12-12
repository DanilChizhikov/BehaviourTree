using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    [Serializable]
    public sealed class BehaviourForkConfig : IBehaviourStateConfig
    {
        [SerializeField] private BehaviourPortConfig _port = default;
        [SerializeField, Min(1)] private int _weight = 1;
        [SerializeField] private BehaviourDecisionConfig[] _decisions = Array.Empty<BehaviourDecisionConfig>();

        public IBehaviourPortConfig Port => _port;
        public int Weight => _weight;
        public IReadOnlyList<IBehaviourDecisionConfig> Decisions => _decisions;
    }
}