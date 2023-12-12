#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract partial class BehaviourLogicStateConfig
    {
        public IReadOnlyList<BehaviourTransitionConfig> EditorTransitionConfigs => _transitions;
        
        public void SetTransitions(BehaviourTransitionConfig[] value)
        {
            _transitions = value;
            EditorUtility.SetDirty(this);
        }

        public void SetTransitionByIndex(int index, BehaviourTransitionConfig value)
        {
            _transitions[index] = value;
            EditorUtility.SetDirty(this);
        }
    }
}
#endif