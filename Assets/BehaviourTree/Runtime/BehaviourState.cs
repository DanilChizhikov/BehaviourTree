using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourState : IBehaviourState
    {
        public abstract void Enter();
        public abstract void Update();
        public abstract bool TryGetNextState(out IBehaviourState nextState);
        public abstract void Exit();
    }
}