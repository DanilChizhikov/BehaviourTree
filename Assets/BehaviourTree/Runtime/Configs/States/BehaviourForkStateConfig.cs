using System;
using System.Collections.Generic;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourForkStateConfig : BehaviourStateConfig
    {
        [SerializeField] private BehaviourForkConfig[] _forks = Array.Empty<BehaviourForkConfig>();

        public IReadOnlyList<BehaviourForkConfig> ForkInfos => _forks;
    }
}