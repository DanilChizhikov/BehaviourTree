using MbsCore.BehaviourTree.Infrastructure;
using MbsCore.BehaviourTree.Runtime;
using UnityEngine;

namespace BehaviourTree.Example
{
    public class BehaviourServiceBootstrap : MonoBehaviour
    {
        private static IBehaviourService _service;

        public static IBehaviourService Service => _service;

        private void Awake()
        {
            if (Service != null)
            {
                Destroy(gameObject);
                return;
            }

            _service = new BehaviourService();
        }
    }

    internal sealed class ExampleLogicState : BehaviourLogicState
    {
        public override void Enter()
        {
            
        }

        public override void Update()
        {
            
        }

        public override bool TryGetNextState(out IBehaviourState nextState)
        {
            
        }

        public override void Exit()
        {
            
        }
    }
}