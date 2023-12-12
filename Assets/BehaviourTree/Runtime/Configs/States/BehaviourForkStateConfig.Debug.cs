#if UNITY_EDITOR
using UnityEditor;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract partial class BehaviourForkStateConfig
    {
        public void SetForks(BehaviourForkConfig[] forks)
        {
            _forks = forks;
            EditorUtility.SetDirty(this);
        }
    }
}
#endif