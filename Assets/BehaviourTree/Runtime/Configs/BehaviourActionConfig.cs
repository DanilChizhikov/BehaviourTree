using MbsCore.BehaviourTree.Infrastructure;
using UnityEngine;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourActionConfig<TEntity> : ScriptableObject, IBehaviourActionConfig<TEntity>
            where TEntity : IBehaviourEntity { }
}