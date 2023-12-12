using System;
using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    [Serializable]
    public sealed class BehaviourPortConfig : IBehaviourPortConfig
    {
        [SerializeField] private string _name = string.Empty;
        [SerializeField] private BehaviourStateConfig _nextState = default;

        public string Name => _name;
        public IBehaviourStateConfig NextState => _nextState;

        public BehaviourPortConfig(string name, BehaviourStateConfig nextState)
        {
            _name = name;
            _nextState = nextState;
        }
    }
}