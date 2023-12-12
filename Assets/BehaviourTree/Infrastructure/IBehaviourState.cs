namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourState
    {
        void Enter();
        void Update();
        bool TryGetNextState(out IBehaviourState nextState);
        void Exit();
    }
}