using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourForkStateConfig<TEntity> : BehaviourStateConfig<TEntity>, IBehaviourForkStateConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        [SerializeField] private BehaviourForkConfig<TEntity>[] _forks = Array.Empty<BehaviourForkConfig<TEntity>>();

        public IReadOnlyList<IBehaviourForkConfig<TEntity>> ForkInfos => _forks;
    }
}