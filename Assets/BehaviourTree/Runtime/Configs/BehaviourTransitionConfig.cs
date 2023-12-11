using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    [Serializable]
    public sealed class BehaviourTransitionConfig<TEntity> : IBehaviourTransitionConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        [SerializeField] private BehaviourPortConfig<TEntity> _truePort = default;
        [SerializeField] private BehaviourPortConfig<TEntity> _falsePort = default;
        [SerializeField] private BehaviourDecisionConfig<TEntity>[] _decision = Array.Empty<BehaviourDecisionConfig<TEntity>>();

        public IBehaviourPortConfig<TEntity> TruePort => _truePort;
        public IBehaviourPortConfig<TEntity> FalsePort => _falsePort;
        public IReadOnlyList<IBehaviourDecisionConfig<TEntity>> Decisions => _decision;
    }
}