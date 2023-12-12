namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourGraph
    {
        bool IsPlaying { get; }
        
        void Enter();
        void Update();
        void Exit();
    }
}