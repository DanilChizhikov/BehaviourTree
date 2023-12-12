using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourForkStateConfig : BehaviourStateConfig, IBehaviourForkStateConfig
    {
        [SerializeField] private BehaviourForkConfig[] _forks = Array.Empty<BehaviourForkConfig>();

        public IReadOnlyList<IBehaviourForkConfig> ForkInfos => _forks;
    }
}