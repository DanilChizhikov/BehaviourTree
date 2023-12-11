using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourLogicStateConfig<TEntity> : BehaviourStateConfig<TEntity>, IBehaviourLogicStateConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        [SerializeField] private BehaviourActionConfig<TEntity>[] _actions = Array.Empty<BehaviourActionConfig<TEntity>>();
        [SerializeField] private BehaviourTransitionConfig<TEntity>[] _transitions = Array.Empty<BehaviourTransitionConfig<TEntity>>();

        public IReadOnlyList<IBehaviourActionConfig<TEntity>> Actions => _actions;
        public IReadOnlyList<IBehaviourTransitionConfig<TEntity>> Transitions => _transitions;
    }
}