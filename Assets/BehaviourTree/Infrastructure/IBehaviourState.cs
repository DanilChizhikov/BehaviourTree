namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourState
    {
        void Enter();
        bool TryGetNextState(out IBehaviourState nextState);
        void Exit();
    }
}