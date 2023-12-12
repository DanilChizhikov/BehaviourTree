#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract partial class BehaviourGraphConfig
    {
        public void SetEnterState(BehaviourStateConfig value)
        {
            _enterState = value;
            EditorUtility.SetDirty(this);
        }

        public void UpdateStates()
        {
            var states = new List<BehaviourStateConfig>();
            for (int i = nodes.Count - 1; i >= 0; i--)
            {
                if (nodes[i] is BehaviourStateConfig stateConfig)
                {
                    states.Add(stateConfig);
                }
            }

            _states = states.ToArray();
            EditorUtility.SetDirty(this);
        }
    }
}
#endif