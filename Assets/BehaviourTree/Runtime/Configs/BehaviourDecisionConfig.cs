using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourDecisionConfig : ScriptableObject, IBehaviourDecisionConfig
    {
        [SerializeField] private bool _isReverse = false;

        public bool IsReverse => _isReverse;
    }
}