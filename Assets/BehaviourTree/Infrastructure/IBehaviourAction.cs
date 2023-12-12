namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourAction
    {
        void Enter();
        void Processing();
        void Exit();
    }
}