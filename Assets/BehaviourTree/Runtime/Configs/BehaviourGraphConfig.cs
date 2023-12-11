using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;
using XNode;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourGraphConfig<TEntity> : NodeGraph, IBehaviourGraphConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        [SerializeField] private BehaviourStateConfig<TEntity> _enterState = default;
        [SerializeField] private BehaviourStateConfig<TEntity>[] _states = Array.Empty<BehaviourStateConfig<TEntity>>();

        public IBehaviourStateConfig<TEntity> EnterState => _enterState;
        public IReadOnlyList<IBehaviourStateConfig<TEntity>> States => _states;
    }
}