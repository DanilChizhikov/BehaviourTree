using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract partial class BehaviourLogicStateConfig : BehaviourStateConfig, IBehaviourLogicStateConfig
    {
        [SerializeField] private BehaviourActionConfig[] _actions = Array.Empty<BehaviourActionConfig>();
        [SerializeField] private BehaviourTransitionConfig[] _transitions = Array.Empty<BehaviourTransitionConfig>();

        public IReadOnlyList<IBehaviourActionConfig> Actions => _actions;
        public IReadOnlyList<IBehaviourTransitionConfig> Transitions => _transitions;
    }
}