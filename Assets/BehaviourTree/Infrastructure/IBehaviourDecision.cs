namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourDecision
    {
        void Enter();
        bool GetDecision();
        void Exit();
    }
}