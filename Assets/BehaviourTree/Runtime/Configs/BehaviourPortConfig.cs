using System;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    [Serializable]
    public sealed class BehaviourPortConfig<TEntity> : IBehaviourPortConfig<TEntity> where TEntity : IBehaviourEntity
    {
        [SerializeField] private string _name = string.Empty;
        [SerializeField] private BehaviourStateConfig<TEntity> _nextState = default;

        public string Name => _name;
        public IBehaviourStateConfig<TEntity> NextState => _nextState;

        public BehaviourPortConfig(string name, BehaviourStateConfig<TEntity> nextState)
        {
            _name = name;
            _nextState = nextState;
        }
    }
}