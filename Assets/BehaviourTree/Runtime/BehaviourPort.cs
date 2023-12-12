using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public sealed class BehaviourPort : IBehaviourPort
    {
        public IBehaviourState NextState { get; }

        public BehaviourPort(IBehaviourState nextState)
        {
            NextState = nextState;
        }
    }
}