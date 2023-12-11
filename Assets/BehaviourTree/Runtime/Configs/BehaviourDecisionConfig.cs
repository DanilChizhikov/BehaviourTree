using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourDecisionConfig<TEntity> : ScriptableObject, IBehaviourDecisionConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        [SerializeField] private bool _isReverse = false;

        public bool IsReverse => _isReverse;
    }
}