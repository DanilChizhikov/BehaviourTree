using System;
using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    [Serializable]
    public sealed class BehaviourForkConfig<TEntity> : IBehaviourForkConfig<TEntity> where TEntity : IBehaviourEntity
    {
        [SerializeField] private BehaviourPortConfig<TEntity> _port = default;
        [SerializeField, Min(1)] private int _weight = 1;
        [SerializeField] private BehaviourDecisionConfig<TEntity>[] _decisions = Array.Empty<BehaviourDecisionConfig<TEntity>>();

        public IBehaviourPortConfig<TEntity> Port => _port;
        public int Weight => _weight;
        public IReadOnlyList<IBehaviourDecisionConfig<TEntity>> Decisions => _decisions;
    }
}