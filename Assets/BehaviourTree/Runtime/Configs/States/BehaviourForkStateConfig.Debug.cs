#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract partial class BehaviourForkStateConfig
    {
        public IReadOnlyList<BehaviourForkConfig> EditorForks => _forks;
        
        public void SetForks(BehaviourForkConfig[] forks)
        {
            _forks = forks;
            EditorUtility.SetDirty(this);
        }
    }
}
#endif