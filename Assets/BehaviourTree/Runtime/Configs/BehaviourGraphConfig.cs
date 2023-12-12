using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;
using XNode;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract partial class BehaviourGraphConfig : NodeGraph, IBehaviourGraphConfig
    {
        [SerializeField] private BehaviourStateConfig _enterState = default;
        [SerializeField] private BehaviourStateConfig[] _states = Array.Empty<BehaviourStateConfig>();

        public IBehaviourStateConfig EnterState => _enterState;
        public IReadOnlyList<IBehaviourStateConfig> States => _states;
    }
}